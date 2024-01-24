/*  Johnathan R. Burgess C++ Programming class 8/23/2018
	This is my C++ playground for small ideas and things to try out.
*/

// PREPROCESSOR DIRECTIVE
#include <iostream>
//using namespace std;

//void practice1();
void ASCII_Chart();

int main() {

	ASCII_Chart();

	system("pause");
	return 0;
}
/*void practice1() {
	int x = 10;
	int y = 4;
	cout << x / y << "\t";
	cout << "Remainder:" << x % y << endl;
}*/

// ASCII Chart function
void ASCII_Chart() {
	int start, end;
	std::cout << "Enter the ASCII chart start point, put a space, then enter the ASCII chart end point:" << std::endl;
	std::cin >> start >> end;
	// Loops through 256 numbers
	for (int i = start; i <= end; i++) {
		// Assigns the value of i to ASCII_Value_Generic each iteration
		char ASCII_Value_Generic = i;
		// outputs the number stored in i for this iteration, along with the corresponding ASCII value
		std::cout << "The ASCII value of " << i << " is "
			<< ASCII_Value_Generic << std::endl;
	}
}