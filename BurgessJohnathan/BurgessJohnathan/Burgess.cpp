/*
Johnathan R. Burgess 8/30/2018
C++ Programming Class, GTCC, CSC-134
This is my original work.
*/

// PREPROCESSOR DIRECTIVE
///////////////////////////////////////////////////////////////////
// gives access to the cin and cout operators
#include <iostream> // including the iostream library

// gives access to stream manipulator
#include <iomanip> // library for manipulating input and output
//////////////////////////////////////////////////////////////////

//using namespace std; // using namespace standard. This is a way to have the same function names and keep them organized.

// MAIN FUNCTION (integer type)
int main() {

	// initialization of variables
	double x, y, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p;

	x = 1.5234;
	y = 8.6432;
	
	// table values
	a = 5.2;
	b = 7.8;
	c = 5.0;
	d = 2.4;
	e = 7.9;
	f = 1.3;
	g = 2.6653;
	h = 24.24;
	i = 321.32;
	j = 7.89;
	k = 0.34;
	l = 9.87;
	m = 92.1382883;
	n = 91.21;
	o = 9.1;
	p = 999.11;

	std::cout << std::showpoint; // forces the display of decimal points
	std::cout << std::setprecision(2) << std::fixed; // sets precision to 2 decimal places
	// program output
	std::cout << std::left << std::setw(10) << "Column1" << std::left << std::setw(10) << "Column2" << std::left << std::setw(10) << "Column3" << std::endl
		<< std::left << std::setw(10) << a << std::left << std::setw(10) << b << std::right << std::setw(10) << c << std::endl
		<< std::left << std::setw(10) << d << std::left << std::setw(10) << e << std::right << std::setw(10) << f << std::endl
		<< std::left << std::setw(10) << g << std::left << std::setw(10) << h << std::right << std::setw(10) << i << std::endl
		<< std::left << std::setw(10) << j << std::left << std::setw(10) << k << std::right << std::setw(10) << l << std::endl
		<< std::left << std::setw(10) << m << std::left << std::setw(10) << n << std::right << std::setw(10) << o << std::endl
		<< std::left << std::setw(10) << p << std::endl;

	// system pause command to keep the console open
	system("pause");

	// returns the integer value zero
	return 0;
}