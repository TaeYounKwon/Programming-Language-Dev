package main

import (
	"bufio"
	"fmt"
	"os"
	//	"bytes"
	"regexp"
	"unicode"
)

func main(){
	reader := bufio.NewReader(os.Stdin)
	fmt.Println("Enter a string: ")
	input, _ := reader.ReadString('\n')
	// Declare regular expressions 'handlers'
	float_regex, _ := regexp.Compile("^[0-9][0-9]*\\.[0-9][0-9]*")
	email_regex, _ := regexp.Compile("^[a-z,A-Z,0-9]+@[a-z][a-z]*\\.[a-z][a-z]+")
	string_regex, _ := regexp.Compile("\\.*(?:[0-9][A-Z]|[A-Z][0-9]|[\\dA-Z])\\.*")
	num_regex, _ := regexp.Compile("^[0-9][0-9]*")
	ws_regex, _ := regexp.Compile("^\\s")
/*
We want
-only numbers
-only floating point numbers
-only valid emails a@a.aa
-only strings that contain at least one digit, at least one capital
 */
	// Program logic
	flag := true
	var current_position int
	var current_char rune
	for flag {
		if ws_regex.MatchString(input) {
			input = input[1:]
		} else if email_regex.MatchString(input){
			current_position = 0
			current_char = rune(input[current_position])
			for unicode.IsLetter(current_char) || unicode.IsNumber(current_char){
				current_position = current_position + 1
				if current_position >= len(input){
					break
				}
				current_char = rune(input[current_position])
				if current_char == '@' || current_char == '.' {
					current_position = current_position + 1
					current_char = rune(input[current_position])
				}
			}
			lexeme := input[:current_position]
			input = input[current_position:]
			fmt.Println("EMAIL", lexeme)

		} else if string_regex.MatchString(input) {
			current_position = 0
			current_char = rune(input[current_position])
			for unicode.IsLetter(current_char) || unicode.IsNumber(current_char) {
				current_position = current_position + 1
				if current_position >= len(input) {
					break
				}
				current_char = rune(input[current_position])
				if current_char == ' ' {
					current_position = current_position + 1
					if current_position >= len(input) {
						break
					}
					current_char = rune(input[current_position])
				}
			}
			lexeme := input[:current_position]
			input = input[current_position:]
			fmt.Println("String", lexeme)
		} else if float_regex.MatchString(input){
			current_position = 0
			current_char = rune(input[current_position])
			for unicode.IsNumber(current_char) {
				current_position = current_position + 1
				if current_position >= len(input){
					break
				}
				current_char = rune(input[current_position])
				if current_char == '.' {
					current_position = current_position + 1
					current_char = rune(input[current_position])
				}
			}
			lexeme := input[:current_position]
			input = input[current_position:]
			fmt.Println("FLOAT", lexeme)

		}else if num_regex.MatchString(input){
			current_position = 0
			current_char = rune(input[current_position])
			for unicode.IsNumber(current_char) {
				current_position = current_position + 1
				if current_position >= len(input){
					break
				}
				current_char = rune(input[current_position])
			}
			lexeme := input[:current_position]
			input = input[current_position:]
			fmt.Println("NUMBER", lexeme)

		} else {
			fmt.Println("Lexical Error")
			flag = false
		}
		if len(input) == 0 {
			flag = false
		}
	} 


}
