// Example 8-3
#include <iostream>
#include <fstream>

using namespace std;

int main(){
	const int NUM_EMPLOYEES = 6;
	int hours[NUM_EMPLOYEES];
	int count = 0;
	
	ifstream inputFile;

	//Open the data file.
	inputFile.open("work.dat");

	if(!inputFile)
		cout << "Error opening data file\n";
	else{
		while (count < NUM_EMPLOYEES && inputFile >> hours[count])
			count++;
		inputFile.close();
		cout << "The hours worked by each employee are\n";
		for(int employee = 0; employee < count; employee++){
			cout << "Employee " << employee+1 << ": ";
			cout << hours[employee] << endl;
		}
	}
	return 0;
}
