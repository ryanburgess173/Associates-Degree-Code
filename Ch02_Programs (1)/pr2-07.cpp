// Johnathan R. Burgess, Chapter 2, example 7 from the book modified.

// PREPROCESSOR DIRECTIVE
#include <iostream>
using namespace std;

// MAIN FUNCTION, which is an int function
int main2(){

	int number; // declaring an integer variable named number

	number = 5.75; // assigning the integer 5 to the variable number (it chops off the .75 because this is NOT a double variable type)

	// program output
	cout << "The value of number is " << "number" << endl;
	cout << "The value of number is " <<  number  << endl;

	// Re-assigning a value of 7 to the variable number
	number = 7;

	// more program output
	cout << "Now the value of number is " << number << endl;
	
	// pausing the console
	system("pause");

	// returning a value of 0 to satisfy the integer main() function
	return 0;
}