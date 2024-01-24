/* 
	Johnathan R. Burgess, CSC-134 C++ Programming, 8/28/2018.
	Chapter 3 Playground for testing and practicing chapter principles.
*/

// PREPROCESSOR DIRECTIVE
//-------------------------
#include <iostream>
#include <cmath>
//-------------------------

int getGrades();

int main2() {

	int g1 = 1, g2 = 2, g3 = 4;

	double average, avg1, avg2;

	average = static_cast<double>(g1 + g2 + g3) / 3;
	// average = (double)(grade1 + grade2 + grade3) / 3; works also
	avg1 = (g1 + g2 + g3) / 3;
	avg2 = static_cast<double>((g1 + g2 + g3) / 3);

	std::cout << average << std::endl;
	std::cout << avg1 << std::endl;
	std::cout << avg2 << std::endl;

	system("pause");
	return 0;
}
void MathOperators() {
	double x = 3.4615;
	double z = 5.42;
	const double pi = 3.14159;
	int t = abs(x);
	double y = cos(x);
	double u = sin(x);
	double i = exp(x);
	double o = fmod(x, z);
	double p = log(x);
	double a = log10(x);
}
int getGrades() {

	int grade1, grade2, grade3;

	std::cout << "Enter three grades seperated by a space (example: 75 86 83)" << std::endl;
	std::cin >> grade1 >> grade2 >> grade3;

	return grade1, grade2, grade3;
}