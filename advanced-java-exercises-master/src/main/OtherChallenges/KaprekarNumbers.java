package main.OtherChallenges;

import java.util.ArrayList;

/*

Kaprekar numbers
TaskKaprekar numbers
You are encouraged to solve this task according to the task description, using any language you may know.
A positive integer is a Kaprekar number if:

It is 1
The decimal representation of its square may be split once into two parts consisting of positive integers which sum to the original number.

Note that a split resulting in a part consisting purely of 0s is not valid, as 0 is not considered positive.

Example Kaprekar numbers
{\displaystyle 2223} is a Kaprekar number, as {\displaystyle 2223*2223=4941729}, {\displaystyle 4941729} may be split to {\displaystyle 494} and {\displaystyle 1729}, and {\displaystyle 494+1729=2223}.
The series of Kaprekar numbers is known as A006886, and begins as {\displaystyle 1,9,45,55,...}.
Example process
10000 (1002) splitting from left to right:

The first split is [1, 0000], and is invalid; the 0000 element consists entirely of 0s, and 0 is not considered positive.
Slight optimization opportunity: When splitting from left to right, once the right part consists entirely of 0s, no further testing is needed; all further splits would also be invalid.
Task description
Generate and show all Kaprekar numbers less than 10,000.

Extra credit
Optionally, count (and report the count of) how many Kaprekar numbers are less than 1,000,000.

Extra extra credit
The concept of Kaprekar numbers is not limited to base 10 (i.e. decimal numbers); if you can, show that Kaprekar numbers exist in other bases too.

For this purpose, do the following:

Find all Kaprekar numbers for base 17 between 1 and 1,000,000 (one million);
Display each of them in base 10 representation;
Optionally, using base 17 representation (use letters 'a' to 'g' for digits 10(10) to 16(10)), display each of the numbers, its square, and where to split the square.

For example, 225(10) is "d4" in base 17, its square "a52g", and a5(17) + 2g(17) = d4(17), so the display would be something like:
225   d4  a52g  a5 + 2g
Reference
The Kaprekar Numbers by Douglas E. Iannucci (2000). PDF version

 */
public class KaprekarNumbers {

    private ArrayList<Integer> kaprekarNumbers;

    public KaprekarNumbers() {
        this.kaprekarNumbers = new ArrayList<>();
    }

    public ArrayList<Integer> findKaprekarNumbers() {

        ArrayList<Integer> list = new ArrayList<>();
        String whole, half1, half2;
        int half1Num, half2Num;

        for (int i = 1; i < 1001; i++) {

            if (i == 1) {
                this.kaprekarNumbers.add(i);
            }
            else {
                whole = Integer.toString(i*i);

                for(int j=0; j<whole.length(); j++){

                    half1 = whole.substring(0, j);
                    half2 = whole.substring(j+1);
                    half1Num = Integer.parseInt(half1);
                    half2Num = Integer.parseInt(half2);

                    if((half1Num + half2Num) == i*i){
                        this.kaprekarNumbers.add(i);
                    }
                }
            }
        }
        return list;
    }

}
