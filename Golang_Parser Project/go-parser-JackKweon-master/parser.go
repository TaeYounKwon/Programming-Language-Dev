package main

import (
	"bufio"
	"container/list"
	"fmt"
	"log"
	"os"
	"regexp"
	"unicode"
)

func main() {
	if len(os.Args)==1{

	fmt.Println("\nPlease type the File Name to Command Line\n")

	} else{

		file, err := os.Open((os.Args[1]))
		if err != nil {
			log.Fatal(err)
		}

		defer func(file *os.File) {
			err := file.Close()
			if err != nil {

			}
		}(file)

		scanner := bufio.NewScanner(file)
		lex := true
		syn := true
		testExist := false
		tokenName := list.New()
		tokenVal := list.New()
		point1 := list.New()
		point2 := list.New()
		idName := list.New()
		testInfo := list.New()
		idCount := 0

		triList := list.New()
		triList.PushBack("line")
		triList.PushBack("triangle")
		triList.PushBack("vertical")
		triList.PushBack("horizontal")
		triList.PushBack("equilateral")
		triList.PushBack("isosceles")
		triList.PushBack("right")
		triList.PushBack("scalene")
		triList.PushBack("acute")
		triList.PushBack("obtuse")


		for scanner.Scan() {
			if err := scanner.Err(); err != nil {
				log.Fatal(err)
			}

			input := scanner.Text()

			// Declare regular expressions 'handlers'
			id_regex, _ := regexp.Compile("^[a-z][a-z]*")
			num_regex, _ := regexp.Compile("^[0-9][0-9]*")
			ws_regex, _ := regexp.Compile("^\\s")
			enter_regex, _ := regexp.Compile("^\\n")
			semi_regx, _ := regexp.Compile("^;")
			comma_regx, _ := regexp.Compile("^,")
			period_regx, _ := regexp.Compile("^\\.")
			lparen_regx, _ := regexp.Compile("^\\(")
			rparen_regx, _ := regexp.Compile("^\\)")
			assign_regx, _ := regexp.Compile("^=")
			tri_regx, _ := regexp.Compile("^triangle")
			square_regx, _ := regexp.Compile("^square")
			test_regx, _ := regexp.Compile("^test")
			point_regx, _ := regexp.Compile("^point")

			// Program logic
			flag := true
			var current_position int
			var current_char rune

			for flag {

				if ws_regex.MatchString(input) {
					input = input[1:]
				}else if enter_regex.MatchString(input) {
					input = input[1:]
				}else if id_regex.MatchString(input) {
					current_position = 0
					current_char = rune(input[current_position])
					for unicode.IsLetter(current_char) {
						current_position = current_position + 1
						if current_position >= len(input) {
							break
						}
						current_char = rune(input[current_position])
					}
					lexeme := input[:current_position]
					input = input[current_position:]

					if tri_regx.MatchString(lexeme) {
						tokenVal.PushBack(lexeme)
						tokenName.PushBack("TRIANGLE")
					} else if square_regx.MatchString(lexeme) {
						tokenName.PushBack("SQUARE")
						tokenVal.PushBack(lexeme)
					} else if test_regx.MatchString(lexeme) {
						tokenName.PushBack("TEST")
						tokenVal.PushBack(lexeme)
					} else if point_regx.MatchString(lexeme) {
						tokenName.PushBack("POINT")
						tokenVal.PushBack(lexeme)
					} else {
						tokenName.PushBack("ID")
						tokenVal.PushBack(lexeme)
					}
				} else if num_regex.MatchString(input) {
					current_position = 0
					current_char = rune(input[current_position])
					for unicode.IsNumber(current_char) {
						current_position = current_position + 1
						if current_position >= len(input) {
							break
						}
						current_char = rune(input[current_position])
					}
					lexeme := input[:current_position]
					input = input[current_position:]
					tokenName.PushBack("NUMBER")
					tokenVal.PushBack(lexeme)
				} else if semi_regx.MatchString(input) {
					current_position = 1
					lexeme := input[:current_position]
					tokenVal.PushBack(lexeme)
					input = input[current_position:]
					tokenName.PushBack("SEMICOLON")
				} else if comma_regx.MatchString(input) {
					current_position = 1
					lexeme := input[:current_position]
					tokenVal.PushBack(lexeme)
					input = input[current_position:]
					tokenName.PushBack("COMMA")
				} else if assign_regx.MatchString(input) {
					current_position = 1
					lexeme := input[:current_position]
					tokenVal.PushBack(lexeme)
					input = input[current_position:]
					tokenName.PushBack("ASSIGN")
				} else if period_regx.MatchString(input) {
					current_position = 1
					lexeme := input[:current_position]
					tokenVal.PushBack(lexeme)
					input = input[current_position:]
					tokenName.PushBack("PERIOD")
				} else if lparen_regx.MatchString(input) {
					current_position = 1
					lexeme := input[:current_position]
					tokenVal.PushBack(lexeme)
					input = input[current_position:]
					tokenName.PushBack("LPAREN")
				} else if rparen_regx.MatchString(input) {
					current_position = 1
					lexeme := input[:current_position]
					tokenVal.PushBack(lexeme)
					input = input[current_position:]
					tokenName.PushBack("RPAREN")
				} else {
					lexeme :=input[:current_position]
					input = input[current_position:]
					tokenVal.PushBack(lexeme)
					lex = false
					goto outLexer
				}
				if len(input) == 0 {
					flag = false
				}
			}
		}
	outLexer:

		//Syntax
		if lex == false {
			fmt.Printf("Lexical error %s not recognized\n", tokenVal.Back().Value)
			goto endCode
		} else if tokenName.Back().Value != "PERIOD" {
			fmt.Printf("Syntax error %v found NUMBER expected!\n", tokenVal.Back().Value)
			goto endCode
		} else {
			countID := 0
			j := tokenVal.Front()
			for i := tokenName.Front(); i != nil; i = i.Next() {

				if i.Value == "ID" {
					if i.Next().Value == "ASSIGN" {
						idCount = idCount + 1
						idName.PushBack(j.Value)
						i = i.Next()
						j = j.Next()

						if i.Next().Value == "POINT" {
							i = i.Next()
							j = j.Next()
							if i.Next().Value == "LPAREN" {
								i = i.Next()
								j = j.Next()
								if i.Next().Value == "NUMBER" {
									i = i.Next()
									j = j.Next()
									point1.PushBack(j.Value)
									if i.Next().Value == "COMMA" {
										i = i.Next()
										j = j.Next()
										if i.Next().Value == "NUMBER" {
											i = i.Next()
											j = j.Next()
											point2.PushBack(j.Value)
											if i.Next().Value == "RPAREN" {
												i = i.Next()
												j = j.Next()
												if i.Next().Value == "SEMICOLON" {
													countID = countID + 1
													j = j.Next()
												} else if i.Next().Value == "PERIOD" {
													break
												} else {
													j = j.Next()
													fmt.Printf("Syntax error %v found SEMICOLON expected!", j.Value)
													syn = false
													break
												}
											} else {
												j = j.Next()
												fmt.Printf("Syntax error %v found RPAREN expected!", j.Value)
												syn = false
												break
											}
										} else {
											j = j.Next()
											fmt.Printf("Syntax error %v found NUMBER expected!", j.Value)
											syn = false
											break
										}
									} else {
										j = j.Next()
										fmt.Printf("Syntax error %v found COMMA expected!", j.Value)
										syn = false
										break
									}
								} else {
									j = j.Next()
									fmt.Printf("Syntax error %v found NUMBER expected!", j.Value)
									syn = false
									break
								}
							} else {
								j = j.Next()
								fmt.Printf("Syntax error %v found LPAREN expected!", j.Value)
								syn = false
								break
							}
						} else {
							j = j.Next()
							fmt.Printf("Syntax error %v found POINT expected!", j.Value)
							syn = false
							break
						}
					} else {
						j = j.Next()
						fmt.Printf("Syntax error %v found ASSIGN expected!", j.Value)
						syn = false
						break
					}
				} else if i.Value == "TEST" {
					if i.Next().Value == "LPAREN" {
						i = i.Next()
						j = j.Next()

						if i.Next().Value == "TRIANGLE" {
							i = i.Next()
							j = j.Next()
							testInfo.PushBack(j.Value)
							if countID >= 3 {

								if i.Next().Value == "COMMA" {
									i = i.Next()
									j = j.Next()

									if i.Next().Value == "ID" {
										i = i.Next()
										j = j.Next()
										testInfo.PushBack(j.Value)

										if i.Next().Value == "COMMA" {
											i = i.Next()
											j = j.Next()

											if i.Next().Value == "ID" {
												i = i.Next()
												j = j.Next()
												testInfo.PushBack(j.Value)

												if i.Next().Value == "COMMA" {
													i = i.Next()
													j = j.Next()

													if i.Next().Value == "ID" {
														i = i.Next()
														j = j.Next()
														testInfo.PushBack(j.Value)

														if i.Next().Value == "RPAREN" {
															i = i.Next()
															j = j.Next()

															if i.Next().Value == "SEMICOLON" {
																j = j.Next()
															} else if i.Next().Value == "PERIOD" {
																break
															} else {
																j = j.Next()
																fmt.Printf("Syntax error %v found SEMICOLON expected!", j.Value)
																syn = false
																break
															}
														} else {
															j = j.Next()
															fmt.Printf("Syntax error %v found RPAREN expected!", j.Value)
															syn = false
															break
														}
													} else {
														j = j.Next()
														fmt.Printf("Syntax error %v found ID expected!", j.Value)
														syn = false
														break
													}
												} else {
													j = j.Next()
													fmt.Printf("Syntax error %v found COMMA expected!", j.Value)
													syn = false
													break
												}
											} else {
												j = j.Next()
												fmt.Printf("Syntax error %v found ID expected!", j.Value)
												syn = false
												break
											}
										} else {
											j = j.Next()
											fmt.Printf("Syntax error %v found COMMA expected!", j.Value)
											syn = false
											break
										}
									} else {
										j = j.Next()
										fmt.Printf("Syntax error %v found ID expected!", j.Value)
										syn = false
										break
									}
								} else {
									j = j.Next()
									fmt.Printf("Syntax error %v found COMMA expected!", j.Value)
									syn = false
									break
								}
							} else {
								fmt.Printf("Syntax error LESS THAN THREE ID FOUND, AT LEAST THREE ID expected!")
								syn = false
								break
							}
						} else if i.Next().Value == "SQUARE" {
							i = i.Next()
							j = j.Next()
							testInfo.PushBack(j.Value)
							if countID >= 4 {

								if i.Next().Value == "COMMA" {
									i = i.Next()
									j = j.Next()

									if i.Next().Value == "ID" {
										i = i.Next()
										j = j.Next()
										testInfo.PushBack(j.Value)

										if i.Next().Value == "COMMA" {
											i = i.Next()
											j = j.Next()

											if i.Next().Value == "ID" {
												i = i.Next()
												j = j.Next()
												testInfo.PushBack(j.Value)

												if i.Next().Value == "COMMA" {
													i = i.Next()
													j = j.Next()

													if i.Next().Value == "ID" {
														i = i.Next()
														j = j.Next()
														testInfo.PushBack(j.Value)

														if i.Next().Value == "COMMA" {
															i = i.Next()
															j = j.Next()

															if i.Next().Value == "ID" {
																i = i.Next()
																j = j.Next()
																testInfo.PushBack(j.Value)

																if i.Next().Value == "RPAREN" {
																	i = i.Next()
																	j = j.Next()

																	if i.Next().Value == "SEMICOLON" {
																		j = j.Next()

																	} else if i.Next().Value == "PERIOD" {
																		break
																	} else {
																		j = j.Next()
																		fmt.Printf("Syntax error %v found SEMICOLON expected!", j.Value)
																		syn = false
																		break
																	}
																} else {
																	j = j.Next()
																	fmt.Printf("Syntax error %v found RPAREN expected!", j.Value)
																	syn = false
																	break
																}
															} else {
																j = j.Next()
																fmt.Printf("Syntax error %v found ID expected!", j.Value)
																syn = false
																break
															}
														} else {
															j = j.Next()
															fmt.Printf("Syntax error %v found COMMA expected!", j.Value)
															syn = false
															break
														}
													} else {
														j = j.Next()
														fmt.Printf("Syntax error %v found ID expected!", j.Value)
														syn = false
														break
													}
												} else {
													j = j.Next()
													fmt.Printf("Syntax error %v found COMMA expected!", j.Value)
													syn = false
													break
												}
											} else {
												j = j.Next()
												fmt.Printf("Syntax error %v found ID expected!", j.Value)
												syn = false
												break
											}
										} else {
											j = j.Next()
											fmt.Printf("Syntax error %v found COMMA expected!", j.Value)
											syn = false
											break
										}
									} else {
										j = j.Next()
										fmt.Printf("Syntax error %v found ID expected!", j.Value)
										syn = false
										break
									}
								} else {
									j = j.Next()
									fmt.Printf("Syntax error %v found COMMA expected!", j.Value)
									syn = false
									break
								}
							} else {
								fmt.Printf("Syntax error LESS THAN THREE ID FOUND, AT LEAST FOUR ID expected!")
								syn = false
								break
							}
						} else {
							j = j.Next()
							fmt.Printf("Syntax error %v found TRIANGLE or SQUARE expected!", j.Value)
							syn = false
							break
						}
					} else {
						j = j.Next()
						fmt.Printf("Syntax error %v found LPAREN expected!", j.Value)
						syn = false
						break
					}
				} else {
					fmt.Printf("Syntax error %v found ID or TEST expected!", j.Value)
					syn = false
					break
				}
				i = i.Next()
				j = j.Next()
			}
		}

		if syn == false {
			testExist = true

		} else if len(os.Args) != 3 {

			testExist = true
			fmt.Println("\n/* Processing Input File ", os.Args[1])
			fmt.Println("/* Lexical and Syntax analysis passed")
			fmt.Println("/* Please add \"-s\" or \"-p\" next to the file name in the command line !!")

		} else if os.Args[2] == "-s" {
			fmt.Println(";Processing Input File ", os.Args[1])
			fmt.Println(";Lexical and Syntax analysis passed")
			fmt.Println(";Generating Scheme Code")

			for i := testInfo.Front(); i != nil; i = i.Next() {
				var countElement = 1
				testCheck := true

				if i.Value == "square" {
					testExist = true
					i = i.Next()

					fmt.Printf("(process-square")
					for testCheck {
						if i.Value == idName.Front().Value {
							fmt.Printf(" (make-point %v %v)", point1.Front().Value, point2.Front().Value)
							if countElement == 4 {
								fmt.Printf(")\n")
								testCheck = false
							} else {
								i = i.Next()
							}
						} else if i.Value == idName.Front().Next().Value {
							fmt.Printf(" (make-point %v %v)", point1.Front().Next().Value, point2.Front().Next().Value)
							if countElement == 4 {
								fmt.Printf(")\n")
								testCheck = false
							} else {
								i = i.Next()
							}
						} else if i.Value == idName.Back().Prev().Value {
							fmt.Printf(" (make-point %v %v) ", point1.Front().Next().Next().Value, point2.Front().Next().Next().Value)
							if countElement == 4 {
								fmt.Printf(")\n")
								testCheck = false
							} else {
								i = i.Next()
							}
						} else if i.Value == idName.Back().Value {
							fmt.Printf(" (make-point %v %v)", point1.Back().Value, point2.Back().Value)
							if countElement == 4 {
								fmt.Printf(")\n")
								testCheck = false
							} else {
								i = i.Next()
							}
						} else {
							fmt.Printf(" (make-point error error)")
							if countElement == 4 {
								fmt.Printf(")\n")
							} else {
								i = i.Next()
							}
						}
						countElement = countElement + 1
					}

				} else if i.Value == "triangle" {
					testExist = true
					i = i.Next()

					fmt.Printf("(process-triangle")
					for testCheck {
						if i.Value == idName.Front().Value {
							fmt.Printf(" (make-point %v %v)", point1.Front().Value, point2.Front().Value)
							if countElement == 3 {
								fmt.Printf(")\n")
								testCheck = false
							} else {
								i = i.Next()
							}
						} else if i.Value == idName.Front().Next().Value {
							fmt.Printf(" (make-point %v %v)", point1.Front().Next().Value, point2.Front().Next().Value)
							if countElement == 3 {
								fmt.Printf(")\n")
								testCheck = false
							} else {
								i = i.Next()
							}
						} else if i.Value == idName.Back().Prev().Value {
							fmt.Printf(" (make-point %v %v) ", point1.Front().Next().Next().Value, point2.Front().Next().Next().Value)
							if countElement == 3 {
								fmt.Printf(")\n")
								testCheck = false
							} else {
								i = i.Next()
							}
						} else if i.Value == idName.Back().Value {
							fmt.Printf(" (make-point %v %v)", point1.Back().Value, point2.Back().Value)
							if countElement == 3 {
								fmt.Printf(")\n")
								testCheck = false
							} else {
								i = i.Next()
							}
						} else {
							fmt.Printf(" (make-point error error)")
							if countElement == 3 {
								fmt.Printf(")\n")
							} else {
								i = i.Next()
							}
						}
						countElement = countElement + 1
					}
				} else {

				}

			}

		} else if os.Args[2] == "-p" {
			fmt.Println("/* Processing Input File ", os.Args[1])
			fmt.Println("   Lexical and Syntax analysis passed")
			fmt.Println("   Generating Prolog Code */")

			for i := testInfo.Front(); i != nil; i = i.Next() {

				testCheck := true

				if i.Value == "square" {
					testExist = true
					i = i.Next()
					var countElement = 1

					fmt.Printf("\n/* Processing test (square, %v, %v, %v, %v) */", i.Value, i.Next().Value, i.Next().Next().Value, i.Next().Next().Next().Value)
					fmt.Printf("\nquery(square(")
					for testCheck {
						if i.Value == idName.Front().Value {

							fmt.Printf("point2d(%v, %v)", point1.Front().Value, point2.Front().Value)
							if countElement == 4 {
								fmt.Printf("))\n")
								testCheck = false
							} else {
								fmt.Printf(", ")
								i = i.Next()
							}
						} else if i.Value == idName.Front().Next().Value {
							fmt.Printf("point2d(%v, %v)", point1.Front().Next().Value, point2.Front().Next().Value)
							if countElement == 4 {
								fmt.Printf("))\n")
								testCheck = false
							} else {
								fmt.Printf(", ")
								i = i.Next()
							}
						} else if i.Value == idName.Back().Prev().Value {
							fmt.Printf("point2d(%v, %v)", point1.Back().Prev().Value, point2.Back().Prev().Value)
							if countElement == 4 {
								fmt.Printf("))\n")
								testCheck = false
							} else {
								fmt.Printf(", ")
								i = i.Next()
							}
						} else if i.Value == idName.Back().Value {
							fmt.Printf("point2d(%v, %v)", point1.Back().Value, point2.Back().Value)
							if countElement == 4 {
								fmt.Printf("))\n")
								testCheck = false
							} else {
								fmt.Printf(", ")
								i = i.Next()
							}
						} else {
							fmt.Printf("(make-point error error)")
							if countElement == 4 {
								fmt.Printf("))\n")
							} else {
								fmt.Printf(", ")
								i = i.Next()
							}
						}
						countElement = countElement + 1
					}

				} else if i.Value == "triangle" {
					i = i.Next()
					fmt.Printf("\n/* Processing test (triangle, %v, %v, %v) */\n", i.Value, i.Next().Value, i.Next().Next().Value)

					testExist = true
					for t := triList.Front(); t != nil; t = t.Next() {

						var countElement = 1
						fmt.Printf("query(%v(", t.Value)
						for testCheck {
							if i.Value == idName.Front().Value {
								fmt.Printf("point2d(%v, %v)", point1.Front().Value, point2.Front().Value)
								if countElement == 3 {
									fmt.Printf(")).\n")
									testCheck = false
								} else {
									fmt.Printf(", ")
									i = i.Next()
								}

							} else if i.Value == idName.Front().Next().Value {
								fmt.Printf("point2d(%v, %v)", point1.Front().Next().Value, point2.Front().Next().Value)
								if countElement == 3 {
									fmt.Printf(")).\n")
									testCheck = false
								} else {
									fmt.Printf(", ")
									i = i.Next()
								}

							} else if i.Value == idName.Back().Prev().Value {
								fmt.Printf("point2d(%v, %v)", point1.Back().Prev().Value, point2.Back().Prev().Value)
								if countElement == 3 {
									fmt.Printf(")).\n")
									testCheck = false
								} else {
									fmt.Printf(", ")
									i = i.Next()
								}

							} else if i.Value == idName.Back().Value {
								fmt.Printf("point2d(%v, %v)", point1.Back().Value, point2.Back().Value)
								if countElement == 3 {
									fmt.Printf(")).\n")
									testCheck = false
								} else {
									fmt.Printf(", ")
									i = i.Next()
								}

							} else {
								fmt.Printf("(make-point error error)")
								if countElement == 3 {
									fmt.Printf(")).\n")
									testCheck = false
								} else {
									fmt.Printf(", ")
									i = i.Next()
								}
							}
							countElement = countElement + 1
						}
						if t.Value == "obtuse" {
							fmt.Printf("")
						} else {
							i = i.Prev()
							i = i.Prev()
							testCheck = true
						}
					}
				} else {

				}

			}
			fmt.Printf("\n/* Query Processing */\n")
			fmt.Printf("writeIn(T) :-write(T), nl.\n")
			fmt.Printf("main:-forall(query(Q), Q-> (writeIn('yes')) ; (writenIn('no'))),\n")
			fmt.Printf("     halt.\n")

		} else {
			testExist = true
			fmt.Println("\n/* Processing Input File ", os.Args[1])
			fmt.Println("/* Lexical and Syntax analysis passed")
			fmt.Println("/* INVALID INPUT  !!")
			fmt.Println("/* Please add \"-s\" or \"-p\" next to the file name in the command line !!")
		}
		if testExist == false {
			fmt.Printf("\n; NO TEST STATEMENT IN THE FILE\n")
		}
	}
	endCode:
		fmt.Println("Thanks for using the program!\n")
}
