/*
	Johnathan R. Burgess
	CSC-134, C++ Programming
	Arrays Practice
	11/6/2018
*/

#include <iostream>
#include <iomanip>

using namespace std;

void main2() {
	int i = 50;
	int array1[50];
	
	for (int a = 0; a < i; a++) {
		array1[a] = a * a * a; // a cubed
	}

	for (int b = 0; b < i; b++) {
		cout << setw(2) << b << " cubed equals: " << setw(10) << array1[b] << endl;
	}
	system("pause");
}