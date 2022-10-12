%CHECK IF TWO POINTS CREATE HORIZONTAL LINE
horizontal(point2d(X1,Y1), point2d(X2,Y2)) :-
    Y1 =:= Y2,
    X1 =\= X2.

%CHECK IF TWO POINTS CREATE VERTICAL LINE
vertical(point2d(X1,Y1), point2d(X2,Y2)) :-
    X1 =:= X2,
    Y1 =\= Y2.

%CALCULATE THE DISTANCE BETWEEN TWO POINTS
distance(point2d(X1,Y1), point2d(X2,Y2), Dist) :-
    Dist is sqrt((X2-X1)^2 + (Y2 - Y1)^2).

%CALCULATE THE ANGLE BETWEEN THREE LINE
angle(A, B, C, FinalVal) :-
    CalVal is acos((B^2 + C^2 - A^2)/(2*B*C)),
    FinalVal is CalVal*(180/pi).

%CALCULATE THE AREA BETWEEN THREE POINTS
area(point2d(X1,Y1), point2d(X2,Y2), point2d(X3,Y3), A) :-
    A is abs((X1*(Y2-Y3) + X2*(Y3-Y1) + X3*(Y1-Y2))/2).

%CHECK IF THREE POINTS CREATES TRIANGLE
triangle(point2d(X1,Y1), point2d(X2,Y2), point2d(X3,Y3)) :-
    area(point2d(X1,Y1), point2d(X2,Y2), point2d(X3,Y3), A),
    A > 0.000000000000001.
%CHECK IF THREE POINTS CREATES LINE
line(point2d(X1,Y1), point2d(X2,Y2), point2d(X3,Y3)) :-
    area(point2d(X1,Y1), point2d(X2,Y2), point2d(X3,Y3), A),
    A < 0.000000000000001.

%CHECK IF ALL THREE POINTS CREATES NEARLY 60 DEGREE
equilateral(point2d(X1,Y1), point2d(X2,Y2), point2d(X3,Y3)) :-
    triangle(point2d(X1,Y1), point2d(X2,Y2), point2d(X3,Y3)),
    distance(point2d(X1, Y1), point2d(X2, Y2), A),
    distance(point2d(X1, Y1), point2d(X3, Y3), B),
    distance(point2d(X3, Y3), point2d(X2, Y2), C),
    angle(A, B, C, FIRST),
    angle(B, C, A, SECOND),
    angle(C, A, B, THIRD),
    (
    FIRST < 60.000000000001,
    FIRST > 59.999999999999;
    SECOND < 60.000000000001,
    SECOND > 59.999999999999;
    THIRD < 60.000000000001,
    THIRD > 59.999999999999
    ).

%CHECK IF THREE POINTS CREATES ISOSCELES
%THE TWO ANGLE MUST NEED TO BE VERY CLOSE TO EACH OTHER
isosceles(point2d(X1,Y1), point2d(X2,Y2), point2d(X3,Y3)) :-
    triangle(point2d(X1, Y1), point2d(X2, Y2), point2d(X3,Y3)),
    distance(point2d(X1, Y1), point2d(X2, Y2), A),
    distance(point2d(X1, Y1), point2d(X3, Y3), B),
    distance(point2d(X3, Y3), point2d(X2, Y2), C),
   (
    A =\= B,
    A > C - 0.000000000001,
    A < C + 0.000000000001;

    A =\= B,
    B > C - 0.000000000001,
    B < C + 0.000000000001;

    A =\= C,
    A > B - 0.000000000001,
    A < B + 0.000000000001;

    A > B - 0.000000000001,
    A < B + 0.000000000001,
    A > C - 0.000000000001,
    A < C + 0.000000000001
    ).

%CHECK IF THREE POINTS CREATES RIGHT TRIANGLE
%AT LEAST ONE ANGLE NEEDS TO BE NEARLY 90 DEGREE
right(point2d(X1,Y1), point2d(X2,Y2), point2d(X3,Y3)) :-
    triangle(point2d(X1,Y1), point2d(X2,Y2), point2d(X3,Y3)),
    distance(point2d(X1, Y1), point2d(X2, Y2), A),
    distance(point2d(X1, Y1), point2d(X3, Y3), B),
    distance(point2d(X3, Y3), point2d(X2, Y2), C),
    angle(A, B, C, FIRST),
    angle(B, C, A, SECOND),
    angle(C, A, B, THIRD),
    (
    FIRST < 90.000000000001,
    FIRST > 89.999999999999;
    SECOND < 90.000000000001,
    SECOND > 89.999999999999;
    THIRD < 90.000000000001,
    THIRD > 89.999999999999
    ).

%CHECK IF THREE POINTS CREATES ACUTE
%EACH ANGLE NEED TO BE LESS THAN NEARLY 90 DEGREE
acute(point2d(X1,Y1), point2d(X2,Y2), point2d(X3,Y3)) :-
    triangle(point2d(X1,Y1), point2d(X2,Y2), point2d(X3,Y3)),
    distance(point2d(X1, Y1), point2d(X2, Y2), A),
    distance(point2d(X1, Y1), point2d(X3, Y3), B),
    distance(point2d(X3, Y3), point2d(X2, Y2), C),
    angle(A, B, C, FIRST),
    angle(B, C, A, SECOND),
    angle(C, A, B, THIRD),

    FIRST < 89.999999999999,
    SECOND < 89.999999999999,
    THIRD < 89.999999999999.

%CHECK IF THREE POINTS CREATES OBTUSE
%EACH ANGLE NEED TO BE MORE THAN NEARLY 90 DEGREE
obtuse(point2d(X1,Y1), point2d(X2,Y2), point2d(X3,Y3)) :-
    triangle(point2d(X1,Y1), point2d(X2,Y2), point2d(X3,Y3)),
    distance(point2d(X1, Y1), point2d(X2, Y2), A),
    distance(point2d(X1, Y1), point2d(X3, Y3), B),
    distance(point2d(X3, Y3), point2d(X2, Y2), C),
    angle(A, B, C, FIRST),
    angle(B, C, A, SECOND),
    angle(C, A, B, THIRD),
    (
    FIRST > 90.000000000001;
    SECOND > 90.000000000001;
    THIRD > 90.000000000001
    ).

%CHECK IF THREE POINTS CREATES SCALENE
scalene(point2d(X1,Y1), point2d(X2,Y2), point2d(X3,Y3)) :-
    triangle(point2d(X1,Y1), point2d(X2,Y2), point2d(X3,Y3)),
    distance(point2d(X1, Y1), point2d(X2, Y2), A),
    distance(point2d(X1, Y1), point2d(X3, Y3), B),
    distance(point2d(X3, Y3), point2d(X2, Y2), C),
    A =\= B,
    A =\= C,
    C =\= B.

%CHECK IF THREE POINTS CREATES SQUARE
%USE THE LENGTH OF EACH POINTS TO EVALUATE THE TEST
square(point2d(X1,Y1), point2d(X2,Y2), point2d(X3,Y3), point2d(X4,Y4)) :-
    triangle(point2d(X1,Y1), point2d(X2,Y2), point2d(X3,Y3)),
    triangle(point2d(X4,Y4), point2d(X2,Y2), point2d(X3,Y3)),
    distance(point2d(X1, Y1), point2d(X2, Y2), A),
    distance(point2d(X2, Y2), point2d(X3, Y3), B),
    distance(point2d(X3, Y3), point2d(X4, Y4), C),
    distance(point2d(X4, Y4), point2d(X1, Y1), D),
    distance(point2d(X1, Y1), point2d(X3, Y3), Z),
    distance(point2d(X2, Y2), point2d(X4, Y4), Y),

    (
     %Z, Y DIAGONAL
     A > B - 0.000000000001,
     A < B + 0.000000000001,
     %A == C
     A > C - 0.000000000001,
     A < C + 0.000000000001,
     %A == D
     A > D - 0.000000000001,
     A < D + 0.000000000001,
     %Z == Y
     Z > Y - 0.000000000001,
     Z < Y + 0.000000000001;

     %A, C DIAGONAL
     A > C - 0.000000000001,
     A < C + 0.000000000001,
     B > D - 0.000000000001,
     B < D + 0.000000000001,
     B > Z - 0.000000000001,
     B < Z + 0.000000000001,
     B > Y - 0.000000000001,
     B < Y + 0.000000000001;

     %B, D DIAGONAL
     B > D - 0.000000000001,
     B < D + 0.000000000001,
     A > C - 0.000000000001,
     A < C + 0.000000000001,
     A > Z - 0.000000000001,
     A < Z + 0.000000000001,
     A > Y - 0.000000000001,
     A < Y + 0.000000000001
     ).
query(line(point2d(0,0), point2d(2,4), point2d(5,0))).
query(line(point2d(0,0), point2d(3,2), point2d(6,4))).
query(line(point2d(0,0), point2d(5,0), point2d(2.5,sqrt(18.75)))).
query(triangle(point2d(0,0), point2d(2,4), point2d(5,0))).
query(triangle(point2d(0,0), point2d(3,2), point2d(6,4))).
query(triangle(point2d(0,0), point2d(5,0), point2d(2.5,sqrt(18.75)))).
query(equilateral(point2d(0,0), point2d(2,4), point2d(5,0))).
query(isosceles(point2d(0,0), point2d(2,4), point2d(5,0))).
query(right(point2d(0,0), point2d(2,4), point2d(5,0))).
query(scalene(point2d(0,0), point2d(2,4), point2d(5,0))).
query(acute(point2d(0,0), point2d(2,4), point2d(5,0))).
query(obtuse(point2d(0,0), point2d(2,4), point2d(5,0))).
query(equilateral(point2d(0,0), point2d(5,0), point2d(2.5,sqrt(18.75)))).
query(isosceles(point2d(0,0), point2d(5,0), point2d(2.5,sqrt(18.75)))).
query(right(point2d(0,0), point2d(5,0), point2d(2.5,sqrt(18.75)))).
query(scalene(point2d(0,0), point2d(5,0), point2d(2.5,sqrt(18.75)))).
query(acute(point2d(0,0), point2d(5,0), point2d(2.5,sqrt(18.75)))).
query(obtuse(point2d(0,0), point2d(5,0), point2d(2.5,sqrt(18.75)))).
query(line(point2d(1,2), point2d(2,4), point2d(3,6))).
query(line(point2d(1,2), point2d(2,4), point2d(3,8))).
query(line(point2d(1,2), point2d(2,4), point2d(10,20))).
query(vertical(point2d(1,2), point2d(2,4))).
query(vertical(point2d(1,2), point2d(1,4))).
query(vertical(point2d(1,2), point2d(3,2))).
query(horizontal(point2d(1,2), point2d(2,4))).
query(horizontal(point2d(1,2), point2d(1,4))).
query(horizontal(point2d(1,2), point2d(3,2))).
query(triangle(point2d(1,2), point2d(2,4), point2d(3,6))).
query(triangle(point2d(1,2), point2d(2,4), point2d(3,8))).
query(triangle(point2d(1,2), point2d(2,4), point2d(10,20))).
query(triangle(point2d(2,3), point2d(6,3), point2d(4,3 + sqrt(12)))).
query(equilateral(point2d(2,3), point2d(6,3), point2d(4,3 + sqrt(12)))).
query(isosceles(point2d(2,3), point2d(6,3), point2d(4,3 + sqrt(12)))).
query(right(point2d(2,3), point2d(6,3), point2d(4,3 + sqrt(12)))).
query(scalene(point2d(2,3), point2d(6,3), point2d(4,3 + sqrt(12)))).
query(acute(point2d(2,3), point2d(6,3), point2d(4,3 + sqrt(12)))).
query(obtuse(point2d(2,3), point2d(6,3), point2d(4,3 + sqrt(12)))).
query(triangle(point2d(2,2), point2d(5,2), point2d(3.5,-2))).
query(equilateral(point2d(2,2), point2d(5,2), point2d(3.5,-2))).
query(isosceles(point2d(2,2), point2d(5,2), point2d(3.5,-2))).
query(right(point2d(2,2), point2d(5,2), point2d(3.5,-2))).
query(scalene(point2d(2,2), point2d(5,2), point2d(3.5,-2))).
query(acute(point2d(2,2), point2d(5,2), point2d(3.5,-2))).
query(obtuse(point2d(2,2), point2d(5,2), point2d(3.5,-2))).
query(triangle(point2d(0,0), point2d(-2,2), point2d(4,4))).
query(equilateral(point2d(0,0), point2d(-2,2), point2d(4,4))).
query(isosceles(point2d(0,0), point2d(-2,2), point2d(4,4))).
query(right(point2d(0,0), point2d(-2,2), point2d(4,4))).
query(scalene(point2d(0,0), point2d(-2,2), point2d(4,4))).
query(acute(point2d(0,0), point2d(-2,2), point2d(4,4))).
query(obtuse(point2d(0,0), point2d(-2,2), point2d(4,4))).
query(triangle(point2d(1,1), point2d(3,1), point2d(4,3))).
query(equilateral(point2d(1,1), point2d(3,1), point2d(4,3))).
query(isosceles(point2d(1,1), point2d(3,1), point2d(4,3))).
query(right(point2d(1,1), point2d(3,1), point2d(4,3))).
query(scalene(point2d(1,1), point2d(3,1), point2d(4,3))).
query(acute(point2d(1,1), point2d(3,1), point2d(4,3))).
query(obtuse(point2d(1,1), point2d(3,1), point2d(4,3))).
query(triangle(point2d(3,1), point2d(9,1), point2d(6,4))).
query(equilateral(point2d(3,1), point2d(9,1), point2d(6,4))).
query(isosceles(point2d(3,1), point2d(9,1), point2d(6,4))).
query(right(point2d(3,1), point2d(9,1), point2d(6,4))).
query(scalene(point2d(3,1), point2d(9,1), point2d(6,4))).
query(acute(point2d(3,1), point2d(9,1), point2d(6,4))).
query(obtuse(point2d(3,1), point2d(9,1), point2d(6,4))).
query(square(point2d(2,4),point2d(5,7),point2d(8,4),point2d(5,1))). /* yes */
query(square(point2d(2,4),point2d(5,7),point2d(8,4),point2d(5,0))). /* no */
query(square(point2d(3,1),point2d(2,4),point2d(5,5),point2d(6,2))). /* yes */
query(square(point2d(-1,1),point2d(-1,3),point2d(1,3),point2d(1,0))). /* no */
query(square(point2d(-1,1),point2d(-1,3),point2d(1,3),point2d(1,1))). /* yes */
query(square(point2d(5,4),point2d(5,1),point2d(2,1),point2d(2,4))). /* yes */
query(square(point2d(2,0),point2d(1,2),point2d(2,4),point2d(3,2))). /* no */


writeln(T) :- write(T), nl.

main:- forall(query(Q), Q -> (writeln('yes')) ; (writeln('no'))),
	halt.
