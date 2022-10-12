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
