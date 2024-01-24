# Chapter-6-Problems
Programming Exercise 6.7
(Financial application: compute the future investment value)

Write a method that computes future investment value at a given interest rate for a specified number of years. The future investment is determined using the formula in Programming Exercise 2.21.

Use the following method header:

public static double futureInvestmentValue( double investmentAmount, double monthlyInterestRate, int years)

For example, futureInvestmentValue(10000, 0.05/12, 5) returns 12833.59.

Write a test program that prompts the user to enter the investment amount (e.g., 1000) and the interest rate (e.g., 9%) and prints a table that displays future value for the years from 1 to 30, as shown below:

The amount invested: 1000
Annual interest rate: 9
Years Future Value
1 1093.80
2 1196.41
...
29 13467.25
30 14730.57

Class Name: Exercise06_07

--------------------------------------------------------------------------------------------------------------------------------
Programming Exercise 6.23
(Occurrences of a specified character)

Write a method that finds the number of occurrences of a specified character in a string using the following header:

public static int count(String str, char a)

For example, count("Welcome", 'e') returns 2.

Write a test program that prompts the user to enter a string followed by a character and displays the number of occurrences of the character in the string.

﻿SAMPLE RUN:
﻿

Enter a string: We the people

Enter a character: e

The number of occurrences of e in We the people is 4

Class Name: Exercise06_23

------------------------------------------------------------------------------------------------------------------------------
Programming Exercise 6.25
(Convert milliseconds to hours, minutes, and seconds)

Write a method that converts milliseconds to hours, minutes, and seconds using the following header:

public static String convertMillis(long millis)

The method returns a string as hours:minutes:seconds.

For example,

convertMillis(5500) returns a string 0:0:5,
convertMillis(100000) returns a string 0:1:40
convertMillis(555550000) returns a string 154:19:10.

Write a test program that prompts the user to enter a long integer for milliseconds and displays a string in the format of hours:minutes:seconds.
﻿
﻿SAMPLE RUN:

Enter time in milliseconds: 555550000

154:19:10

Class Name: Exercise06_25
