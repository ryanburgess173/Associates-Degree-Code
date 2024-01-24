// Johnathan R. Burgess
// Student ID: 1763590
// CSC-234 Advanced C++ Programming
// Final Project I: Sequence Sum
// April 27th-28th, 2019

#include <iostream>
#include "OddSeq.h"
#include "AbstractSeq.h"

using namespace std;

int getInput();
int getInput2(int k);

int main() {
	// K and M will be fetched from these functions
	int k, m;
	k = getInput();
	m = getInput2(k);
	cout << endl;

	// Create a new seq
	AbstractSeq* as = new OddSeq();
	// print the seq
	as->printSeq(k,m);
	// backspace characters to help format our output
	cout << "\b\b }";

	// sum of sequence elements
	cout << endl << "Is your sequence and the sum of all of these elements is: " << endl;
	cout << as->sumSeq(k, m);
	cout << endl;

	// does the process over again
	k = getInput();
	m = getInput2(k);
	cout << endl;
	as = new OddSeq();
	as->printSeq(k, m);
	cout << "\b\b }";
	cout << endl << "Is your sequence and the sum of all of these elements is: " << endl;
	cout << as->sumSeq(k, m);
	cout << endl;

	system("pause");
	return 0;
}

// gets our input for k
int getInput() {
	int k = 0;
	// if valid
	try {
		cout << "Enter the index to start at: ";
		cin >> k;
	}
	catch (exception e) {
		cout << "You entered something other than a number. Try again." << endl;
		getInput();
	}
	if (k < 0) {
		cout << "You must enter a number of 0 or greater. Try again." << endl;
		getInput();
	}
	else {
		return k;
	}
}
// gets our input for m and validates based on k which we pass to it
int getInput2(int k) {
	int m;
	cout << "Enter the index to end at: ";
	// if it is valid execute this block:
	if (std::cin >> m) {
		if (m < 0) {
			cout << "You must enter a number of 0 or greater. Try again." << endl;
			getInput2(k);
		}
		else if (m <= k) {
			cout << "You must enter a number bigger than your starting index. Try again." << endl;
			getInput2(k);
		}
		return m;
	}
	// if it is invalid exit the program
	else {
		cout << "You entered something other than a NUMBER." << endl;
		cout << "Application closing." << endl;
		exit(1);
	}
}