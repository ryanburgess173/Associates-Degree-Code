/*
Johnathan R. Burgess 9/11/2018
C++ Programming Class, GTCC, CSC-134
This is my original work.
*/

// PREPROCESSOR DIRECTIVE
#include <iostream> // including the iostream library
using namespace std; // using namespace standard. This is a way to have the same function names and keep them organized.

void logicalOp();
void enumPractice();

// MAIN FUNCTION
int main() {
	system("color 0B");
	cout << "Hello"; // cout (console output) is part of the iostream library. "<<" is an insertion operator.
	int y = 10;
	if (0 < y && y < 100) {
		cout << "\t.\n";
	}
	int x;
	cout << "Enter an option: ";
	cin >> x;
	cout << "1 - 2+2=?" << endl;
	cout << "2 - 2*2=?" << endl;
	switch (x) {
		case 1:
			cout << "2+2=" << (2 + 2);
			break;
		case 2:
			cout << "2*2=" << (2 * 2);
			break;
		default:
			cout << "No valid option found for " << x;
			break;
	}
	cout << endl;
	//logicalOp();
	enumPractice();
	// system pause command to keep the console open
	system("pause");

	// returns the integer value zero
	return 0;
}
void logicalOp() {
	int age;
	cout << "Enter age: ";
	cin >> age;
	(age < 21) ? (cout << "You cannot drink.\n") : (cout << "You can drink!\n");
}
void enumPractice() {
	enum Example { // enums have to be integers
		A, B, C, // defaults to 0, 1, 2, etc
		Q = 5, V = 12, Z = 12 // forcing values overriding the defaults
	};
	Example value = B;
	if (value == B) {
		// Do something here.
	}

	std::cin.get();
}