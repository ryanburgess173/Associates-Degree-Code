// This program can't find its variable.
#include <iostream>
using namespace std;

int main()
{
	int value;
	cout << value;   // ERROR! value has not been defined yet!
	
	value = 100;
	return 0;
}
