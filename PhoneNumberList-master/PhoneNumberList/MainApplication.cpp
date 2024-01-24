/*
	Johnathan R. Burgess
	Advanced C++ Programming
	3/3/2019
*/

#include <iostream>
#include <cstring>
#include <fstream>
#include <string>
#include <vector>
#include "Contact.h"

using namespace std;

void getData(vector<Contact> &contacts);
string input();
void FindContacts(string substring, vector<Contact> &contacts);

int main() {
	vector<Contact> contacts;
	getData(contacts);
	string substring = input();
	FindContacts(substring, contacts);

	system("pause");
	return 0;
}

void getData(vector<Contact> &contacts) {
	ifstream filename;
	filename.open("PhoneNumbers.txt");
	if (!filename) {
		cout << "Error opening data file\n";
	}
	else {
		while (!filename.eof()) {
			char tempFirstName[30], tempLastName[30], tempPhoneNumber[14];
			filename >> tempFirstName >> tempLastName >> tempPhoneNumber;
			contacts.push_back(Contact(tempFirstName, tempLastName, tempPhoneNumber));
		}
	}
	filename.close();
}
string input() {
	string name;
	cout << "Enter a name to search for in your contacts book: ";
	cin >> name;
	return name;
}
void FindContacts(string substring, vector<Contact> &contacts) {
	bool somethingFound = false;
	for (int i = 0; i < contacts.size(); i++) {
		string thisLastName = contacts.at(i).getLastName();
		string thisFirstName = contacts.at(i).getFirstName();
		string thisPhoneNumber = contacts.at(i).getPhoneNumber();
		if (strstr(thisLastName.c_str(), substring.c_str())) {
			cout << thisFirstName << " " << thisLastName << " " << thisPhoneNumber << endl;
			somethingFound = true;
		}
		else if (strstr(thisFirstName.c_str(), substring.c_str())) {
			cout << thisFirstName << " " << thisLastName << " " << thisPhoneNumber << endl;
			somethingFound = true;
		}
	}
	if (!somethingFound) {
		cout << "Sorry, no contact found." << endl;
	}
}