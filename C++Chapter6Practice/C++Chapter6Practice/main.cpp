#include <iostream>
#include <string>

using namespace std;

void main() {
	int x;
	int y;
	x = 10;
	y = 5;
	increment(4, 5);

	system("pause");
}
void increment(int z, int w) {
	z++;
	w++;
	cout << z << " " << w << endl;
}