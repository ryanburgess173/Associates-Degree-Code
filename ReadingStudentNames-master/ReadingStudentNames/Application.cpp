/*
	Johnathan R. Burgess, 3/23/2019
*/
#include <iostream>
#include <fstream>
#include <string>
#include <vector>


using namespace std;

// NameList data type is really just a vector of strings
typedef vector<string> NameList;

// filename constant
const string filename = "Students.txt";

// main
int main() {

	fstream file;
	NameList students;
	string first_name, last_name;

	file.open(filename);
	if (file.fail()) {
		cout << "The file does not exist. Sorry." << endl;
		return 1;
	}

	while (file >> first_name >> last_name) {
		string full_name = first_name + last_name;
		students.push_back(full_name);
	}

	// clear the end of file flag (allows additional file I/O)
	file.clear();

	string date;
	cout << "Enter today's date: ";
	cin >> date;

	file << "\nFile read from on: " << date;

	file.close();

	system("pause");
	return 0;
}