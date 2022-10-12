;make-point function that add the value into the list
(define (make-point x-cor y-cor)
    (cons x-cor y-cor))

;get-x value
(define (get-x point)
    (car point))

;get-y value
(define (get-y point)
    (cdr point))

;change into positive number
(define (abs number)
    (if ( or (> number 0) (= number 0))
        number
        (* -1 number)))


;calculate the distance
(define (cald x1 y1 x2 y2)
 (sqrt(+ (square (- x2 x1)) (square (- y2 y1)) ) )(floor->exact 100.0) )

;print the variables into one line
(define (print . something)
    (for-each display something))


;calculate distance between two points
(define (distance point1 point2)

      (let (
             (x1 (get-x point1))
             (y1 (get-y point1))
             (x2 (get-x point2))
             (y2 (get-y point2)))


             display (cald x1 y1 x2 y2)
             ))


;determine if three points creates the line
(define (is-line point1 point2 point3)

      (let (
                (x1 (get-x point1))
                (y1 (get-y point1));A
                (x2 (get-x point2))
                (y2 (get-y point2));B
                (x3 (get-x point3))
                (y3 (get-y point3)));C

                (cond
                (( eqv? (abs(+ (+ (* x3 (- y1 y2)) (* x1 (- y2 y3))) (* x2 (- y3 y1)))) 0) "#t") ; if area between three line is 0 then it is line
                (else "#f"))))


;determine if three points creates the triangle ( area > 0)
;then create triangle-perimeter
(define (triangle-perimeter point1 point2 point3)

     (let (
               (x1 (get-x point1))
               (y1 (get-y point1));A
               (x2 (get-x point2))
               (y2 (get-y point2));B
               (x3 (get-x point3))
               (y3 (get-y point3)));C

               (cond
              (( eqv? (abs(+ (+ (* x3 (- y1 y2)) (* x1 (- y2 y3))) (* x2 (- y3 y1)))) 0) "#f")
                 (else display ( + ( + (cald x1 y1 x2 y2) (cald x2 y2 x3 y3)) (cald x3 y3 x1 y1)))))); add the distance between three points


;determine if three points creates the triangle ( area > 0)
;then create triangle-area
(define (triangle-area point1 point2 point3)

     (let (
              (x1 (get-x point1))
              (y1 (get-y point1));A
              (x2 (get-x point2))
              (y2 (get-y point2));B
              (x3 (get-x point3))
              (y3 (get-y point3)));C

              (cond
              (( eqv? (abs(+ (+ (* x3 (- y1 y2)) (* x1 (- y2 y3))) (* x2 (- y3 y1)))) 0) "#f")
               (else display (* ( abs(+ (+ (* x3 (- y1 y2)) (* x1 (- y2 y3))) (* x2 (- y3 y1))) ) 0.5)))))


;determine if three points creates the triangle ( area > 0)
;then print out information about triangle
(define (process-triangle point1 point2 point3)

        (let (
              (x1 (get-x point1))
              (y1 (get-y point1));A
              (x2 (get-x point2))
              (y2 (get-y point2));B
              (x3 (get-x point3))
              (y3 (get-y point3));C
              (rTd ( / 180 3.141592653589))) ;radian -> degree

              (cond
              (( or (or (eqv? (cald x1 y1 x2 y2) 0) (eqv? (cald x2 y2 x3 y3) 0)) (eqv? (cald x3 y3 x1 y1) 0) ) display "Not a Triangle")
              ((eqv? (abs(+ (+ (* x3 (- y1 y2)) (* x1 (- y2 y3))) (* x2 (- y3 y1)))) 0) display "Not a Triangle")
              (else


                   (print "Side 1 = ") (print (cald x1 y1 x2 y2))
                   (newline)
                   (print "Side 2 = ") (print (cald x2 y2 x3 y3))
                   (newline)
                   (print "Side 3 = ") (print (cald x3 y3 x1 y1))
                   (newline)
                   (print "Perimeter = ")(print ( + ( + (cald x1 y1 x2 y2) (cald x2 y2 x3 y3)) (cald x3 y3 x1 y1)))
                   (newline)
                   (print "Area = ")(print (* ( abs(+ (+ (* x3 (- y1 y2)) (* x1 (- y2 y3))) (* x2 (- y3 y1))) ) 0.5))
                   (newline)
                   (print "Angle 1 = ") (print (acos (/ (- (+ (square(cald x3 y3 x1 y1)) (square(cald x3 y3 x2 y2))) (square(cald x1 y1 x2 y2)))  (* (* (cald x3 y3 x1 y1) (cald x3 y3 x2 y2) ) 2))))
                   (print "  ")  (print (* (acos (/ (- (+ (square(cald x3 y3 x1 y1)) (square(cald x3 y3 x2 y2))) (square(cald x1 y1 x2 y2)))  (* (* (cald x3 y3 x1 y1) (cald x3 y3 x2 y2) ) 2))) rTd))
                   (newline)
                   (print "Angle 2 = ") (print (acos (/ (- (+ (square(cald x1 y1 x2 y2)) (square(cald x1 y1 x3 y3))) (square(cald x2 y2 x3 y3)))  (* (* (cald x1 y1 x2 y2) (cald x1 y1 x3 y3) ) 2))))
                   (print "  ") (print ( * (acos (/ (- (+ (square(cald x1 y1 x2 y2)) (square(cald x1 y1 x3 y3))) (square(cald x2 y2 x3 y3)))  (* (* (cald x1 y1 x2 y2) (cald x1 y1 x3 y3) ) 2))) rTd))
                   (newline)
                   (print "Angle 3 = ") (print (acos (/ (- (+ (square(cald x2 y2 x3 y3)) (square(cald x2 y2 x1 y1))) (square(cald x3 y3 x1 y1)))  (* (* (cald x2 y2 x3 y3) (cald x2 y2 x1 y1) ) 2))))
                   (print "  ") (print (* (acos (/ (- (+ (square(cald x2 y2 x3 y3)) (square(cald x2 y2 x1 y1))) (square(cald x3 y3 x1 y1)))  (* (* (cald x2 y2 x3 y3) (cald x2 y2 x1 y1) ) 2))) rTd))
                   (newline)
                   (newline)
                    ))))


;check if the points creates the square
(define (is-square point1 point2 point3 point4)

    (let (
              (x1 (get-x point1))
              (y1 (get-y point1));A
              (x2 (get-x point2))
              (y2 (get-y point2));B
              (x3 (get-x point3))
              (y3 (get-y point3));C
              (x4 (get-x point4))
              (y4 (get-y point4)));D

              (cond
              ;if the distance between two points is 0
              (( or (or (eqv? (cald x1 y1 x2 y2) 0) (eqv? (cald x2 y2 x3 y3) 0)) (or (eqv? (cald x3 y3 x4 y4) 0) (eqv? (cald x4 y4 x1 y1) 0)) )
              display "Not a Square")

              ;S1: when first two points are equal, all perimeter & diagonal must be equal
              ((and (and (and (eqv? (cald x1 y1 x2 y2) (cald x1 y1 x3 y3)) (eqv? (cald x1 y1 x2 y2) (cald x2 y2 x4 y4))) (eqv? (cald x1 y1 x2 y2) (cald x3 y3 x4 y4))); 4 perimeters are equal
                    (eqv? (cald x1 y1 x4 y4) (cald x2 y2 x3 y3))) ; 2 diagonals are equal
              display "#t")

              ;S2: When first point is (sqrt2) times of second points
              ((and (and (eqv? (cald x1 y1 x2 y2) (* (cald x1 y1 x3 y3) (sqrt 2) )) (eqv? (cald x1 y1 x2 y2) (cald x3 y3 x4 y4))) ; 2 diagonals are equal
                    (and (and (eqv? (cald x1 y1 x3 y3) (cald x2 y2 x4 y4)) (eqv? (cald x1 y1 x3 y3) (cald x2 y2 x3 y3)))  (eqv? (cald x1 y1 x3 y3) (cald x1 y1 x4 y4)))) ; 4 perimeters are equal
              display "#t")

              ;S3: When the second point is (sqrt 2) times of first points
              ((and (and (eqv? (* (sqrt 2) (cald x1 y1 x2 y2) ) (cald x1 y1 x3 y3)) (eqv? (cald x1 y1 x3 y3) (cald x2 y2 x4 y4))) ; 2 diagonals are equal
                    (and (and (eqv? (cald x1 y1 x2 y2) (cald x3 y3 x4 y4)) (eqv? (cald x1 y1 x2 y2) (cald x2 y2 x3 y3))) (eqv? (cald x1 y1 x2 y2) (cald x1 y1 x4 y4)))) ; 4 perimeters are equal
              display "#t")

              (else display "Not a Square"))))


;calculate the perimeter of square
(define (square-perimeter point1 point2 point3 point4)

    (let (
              (x1 (get-x point1))
              (y1 (get-y point1));A
              (x2 (get-x point2))
              (y2 (get-y point2));B
              (x3 (get-x point3))
              (y3 (get-y point3));C
              (x4 (get-x point4))
              (y4 (get-y point4)));D

              (cond
              ;if the distance between two points is 0
              (( or (or (eqv? (cald x1 y1 x2 y2) 0) (eqv? (cald x2 y2 x3 y3) 0)) (or (eqv? (cald x3 y3 x4 y4) 0) (eqv? (cald x4 y4 x1 y1) 0)) )
              (display "Not a Square"))

              ;S1: when first two points are equal, all perimeter & diagonal must be equal
              ((and (and (and (eqv? (cald x1 y1 x2 y2) (cald x1 y1 x3 y3)) (eqv? (cald x1 y1 x2 y2) (cald x2 y2 x4 y4))) (eqv? (cald x1 y1 x2 y2) (cald x3 y3 x4 y4))); 4 perimeters are equal
                    (eqv? (cald x1 y1 x4 y4) (cald x2 y2 x3 y3))) ; 2 diagonals are equal
              display (* (cald x1 y1 x2 y2) 4 ))

              ;S2: When first point is (sqrt2) times of second points
              ((and (and (eqv? (cald x1 y1 x2 y2) (* (cald x1 y1 x3 y3) (sqrt 2) )) (eqv? (cald x1 y1 x2 y2) (cald x3 y3 x4 y4))) ; 2 diagonals are equal
                    (and (and (eqv? (cald x1 y1 x3 y3) (cald x2 y2 x4 y4)) (eqv? (cald x1 y1 x3 y3) (cald x2 y2 x3 y3)))  (eqv? (cald x1 y1 x3 y3) (cald x1 y1 x4 y4)))) ; 4 perimeters are equal
              display (* (cald x1 y1 x3 y3) 4 ))

              ;S3: When the second point is (sqrt 2) times of first points
              ((and (and (eqv? (* (sqrt 2) (cald x1 y1 x2 y2) ) (cald x1 y1 x3 y3)) (eqv? (cald x1 y1 x3 y3) (cald x2 y2 x4 y4))) ; 2 diagonals are equal
                    (and (and (eqv? (cald x1 y1 x2 y2) (cald x3 y3 x4 y4)) (eqv? (cald x1 y1 x2 y2) (cald x2 y2 x3 y3))) (eqv? (cald x1 y1 x2 y2) (cald x1 y1 x4 y4)))) ; 4 perimeters are equal
              display (* (cald x1 y1 x2 y2) 4 ))

              (else (display "Not a Square")))))

;calculate the area of square
(define (square-area point1 point2 point3 point4)

    (let (
              (x1 (get-x point1))
              (y1 (get-y point1));A
              (x2 (get-x point2))
              (y2 (get-y point2));B
              (x3 (get-x point3))
              (y3 (get-y point3));C
              (x4 (get-x point4))
              (y4 (get-y point4)));D

              (cond
              ;if the distance between two points is 0
              (( or (or (eqv? (cald x1 y1 x2 y2) 0) (eqv? (cald x2 y2 x3 y3) 0)) (or (eqv? (cald x3 y3 x4 y4) 0) (eqv? (cald x4 y4 x1 y1) 0)) )
              (display "Not a Square"))

              ;S1: when first two points are equal, all perimeter & diagonal must be equal
              ((and (and (and (eqv? (cald x1 y1 x2 y2) (cald x1 y1 x3 y3)) (eqv? (cald x1 y1 x2 y2) (cald x2 y2 x4 y4))) (eqv? (cald x1 y1 x2 y2) (cald x3 y3 x4 y4))); 4 perimeters are equal
                    (eqv? (cald x1 y1 x4 y4) (cald x2 y2 x3 y3))) ; 2 diagonals are equal
              display ( square(cald x1 y1 x2 y2)  ))

              ;S2: When first point is (sqrt2) times of second points
              ((and (and (eqv? (cald x1 y1 x2 y2) (* (cald x1 y1 x3 y3) (sqrt 2) )) (eqv? (cald x1 y1 x2 y2) (cald x3 y3 x4 y4))) ; 2 diagonals are equal
                    (and (and (eqv? (cald x1 y1 x3 y3) (cald x2 y2 x4 y4)) (eqv? (cald x1 y1 x3 y3) (cald x2 y2 x3 y3)))  (eqv? (cald x1 y1 x3 y3) (cald x1 y1 x4 y4)))) ; 4 perimeters are equal
              display ( square(cald x1 y1 x3 y3) ))

              ;S3: When the second point is (sqrt 2) times of first points
              ((and (and (eqv? (* (sqrt 2) (cald x1 y1 x2 y2) ) (cald x1 y1 x3 y3)) (eqv? (cald x1 y1 x3 y3) (cald x2 y2 x4 y4))) ; 2 diagonals are equal
                    (and (and (eqv? (cald x1 y1 x2 y2) (cald x3 y3 x4 y4)) (eqv? (cald x1 y1 x2 y2) (cald x2 y2 x3 y3))) (eqv? (cald x1 y1 x2 y2) (cald x1 y1 x4 y4)))) ; 4 perimeters are equal
              display ( square(cald x1 y1 x2 y2) ))

              (else (display "Not a Square")))))


;create the information about the square
(define (process-square point1 point2 point3 point4)


    (let (
              (x1 (get-x point1))
              (y1 (get-y point1));A
              (x2 (get-x point2))
              (y2 (get-y point2));B
              (x3 (get-x point3))
              (y3 (get-y point3));C
              (x4 (get-x point4))
              (y4 (get-y point4)));D

              (cond
              ;if the distance between two points is 0
              (( or (or (eqv? (cald x1 y1 x2 y2) 0) (eqv? (cald x2 y2 x3 y3) 0)) (or (eqv? (cald x3 y3 x4 y4) 0) (eqv? (cald x4 y4 x1 y1) 0)) )
              (display "Not a Square") )

              ;S1: when first two points are equal, all perimeter & diagonal must be equal
              ((and (and (and (eqv? (cald x1 y1 x2 y2) (cald x1 y1 x3 y3)) (eqv? (cald x1 y1 x2 y2) (cald x2 y2 x4 y4))) (eqv? (cald x1 y1 x2 y2) (cald x3 y3 x4 y4))); 4 perimeters are equal
                    (eqv? (cald x1 y1 x4 y4) (cald x2 y2 x3 y3))) ; 2 diagonals are equal

              ;print the output
              (print "Side = ") (print (cald x1 y1 x2 y2))
              (newline)
              (print "Perimeter = ")(print ( * (cald x1 y1 x2 y2) 4))
              (newline)
              (print "Area = ")(print ( square(cald x1 y1 x2 y2)))
              (newline)
              (newline))

              ;S2: When first point is (sqrt2) times of second points
              ((and (and (eqv? (cald x1 y1 x2 y2) (* (cald x1 y1 x3 y3) (sqrt 2) )) (eqv? (cald x1 y1 x2 y2) (cald x3 y3 x4 y4))) ; 2 diagonals are equal
                         (and (and (eqv? (cald x1 y1 x3 y3) (cald x2 y2 x4 y4)) (eqv? (cald x1 y1 x3 y3) (cald x2 y2 x3 y3)))  (eqv? (cald x1 y1 x3 y3) (cald x1 y1 x4 y4)))) ; 4 perimeters are equal

              (print "Side = ") (print (cald x1 y1 x3 y3))
              (newline)
              (print "Perimeter = ")(print ( * (cald x1 y1 x3 y3) 4))
              (newline)
              (print "Area = ")(print ( square(cald x1 y1 x3 y3)))
              (newline)
              (newline))

              ;S3: When the second point is (sqrt 2) times of first points
              ((and (and (eqv? (* (sqrt 2) (cald x1 y1 x2 y2) ) (cald x1 y1 x3 y3)) (eqv? (cald x1 y1 x3 y3) (cald x2 y2 x4 y4))) ; 2 diagonals are equal
                    (and (and (eqv? (cald x1 y1 x2 y2) (cald x3 y3 x4 y4)) (eqv? (cald x1 y1 x2 y2) (cald x2 y2 x3 y3))) (eqv? (cald x1 y1 x2 y2) (cald x1 y1 x4 y4)))) ; 4 perimeters are equal

              (print "Side = ") (print (cald x1 y1 x2 y2))
              (newline)
              (print "Perimeter = ")(print ( * (cald x1 y1 x2 y2) 4))
              (newline)
              (print "Area = ")(print ( square(cald x1 y1 x2 y2)))
              (newline)
              (newline))

              (else (display "Not a Square")))))
