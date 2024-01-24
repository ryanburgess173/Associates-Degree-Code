/*
	Johnathan R. Burgess, CSC-134 C++ Programming
	11/6/2018, In Class Work
*/

#include <iostream>
#include "Person.h"

using namespace std;

void main() {

	const int size = 10;

	float test_Scores[size];

	Person names[5];

	names[0] = Person("Jason", "Byrley");
	names[1] = Person("Louie", "Chiurco");
	names[2] = Person("Jack", "Clemens");
	names[3] = Person("Ricardo", "Lopez");
	names[4] = Person("Gus", "Clemens");

	for (int i = 0; i < size; i++) {
		test_Scores[i] = 100 * ((i+1) / 2.0);
	}

	for (int a = 0; a < 5; a++) {
		cout << names[a].getFirstName() << ' ' << names[a].getLastName() << '\t' << test_Scores[a] << endl; // Where the array lives in memory
	}

	system("pause");

}