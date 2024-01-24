// JOHNATHAN R. BURGESS, 10/12/2018
#include <iostream>
#include <string>
using namespace std;

int getProductAndSum(int x, int y, int &sum);

void main() {
	int x;
	int y;
	int sum = 0;
	x = 10;
	y = 5;
	int product = getProductAndSum(x, y, sum);

	cout << product << " " << sum << endl;

	system("pause");
}
int getProductAndSum(int x, int y, int &sum) {
	sum = x + y;
	return x * y;
}