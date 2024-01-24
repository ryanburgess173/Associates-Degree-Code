/*
Johnathan R. Burgess 8/21/2018
This is my original work. ABC Problem from RosettaCode
*/
// PREPROCESSOR DIRECTIVE
#include <iostream> // including the iostream library
#include <iomanip> // allows output manipulation in formatting
#include <string> // allows for string data type
#include <fstream> // allows for file I/O
#include <list>
using namespace std; // using namespace standard. This is a way to have the same function names and keep them organized.
int LengthOfString(string str);
// MAIN FUNCTION
int main() {
	char letter1;
	char l1[26], l2[26];
	// Open a file of numbers:
	ifstream readFile;
	readFile.open("letterSets.txt");
	
	// populates the 2 arrays
	//==================================================
	int count1 = 0, count2 = 0;
	int currentColumn = 1;
	while (readFile >> letter1) {
		if ((letter1 != '(') && (letter1 != ')')) {
			if (currentColumn == 1) {
				l1[count1] = letter1;
				currentColumn = 2;
				count1++;
			}
			else if (currentColumn == 2) {
				l2[count2] = letter1;
				currentColumn = 1;
				count2++;
			}
		}
		else {
			continue;
		}
	}
	//==================================================

	// variables and user input
	//==================================
	string word;
	cout << "Enter a word: ";
	cin >> word;
	int ln = LengthOfString(word);
	bool isTrue = true;
	bool hasBeenUsed[20];
	string newAssembled;
	//==================================

	// populates the hasBeenUsed boolean array
	for (int a = 0; a < count1; a++) {
		hasBeenUsed[a] = false;
	}

	// checking algorithm
	//=============================================================
	// loops through each letter in the word
	for (int i = 0; i < ln; i++) {

		// loops through set
		for (int j = 0; j <= sizeof(l1); j++) {

			// if the set hasn't been previously used
			if (hasBeenUsed[j] == false) {

				// if their is a character match between one item
				// in the set and the letter of the word:
				if ((l1[j] == word[i]) || (l2[j] == word[i])) {
					// sets it's value to used
					hasBeenUsed[j] = true;
					// adds the letter to an assembled word for comparison
					newAssembled += word[i];
					// breaks out of loop
					break;
				}
				else {
					continue;
				}
			}
		}
	}
	// if the newly assembled word does not match the original
	if (word != newAssembled) {
		//output false.
		cout << "False." << endl;
	}
	// else
	else{
		cout << "True." << endl;
	}

	readFile.close();
	// system pause command to keep the console open
	system("pause");
	return 0;
}
// this function gets the length of the string
int LengthOfString(string str) {
	//gets length of string:
	int i = 0;
	while (str[i] != '\0') {
		++i;
	}
	return i;
}