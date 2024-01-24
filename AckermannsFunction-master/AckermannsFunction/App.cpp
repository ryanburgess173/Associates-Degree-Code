/*
	Johnathan R. Burgess, Ackermann's Function project

	This is my own, original work.
*/
#include <iostream>
#include <vector>

using namespace std;

typedef vector<int> Set;
typedef vector<Set> List;

int A(int m, int n);
void Passer(List lst);

int main() {
	List main_list;
	Set set1 = { 0,0 };
	main_list.push_back(set1);
	Set set2 = { 0,1 };
	main_list.push_back(set2);
	Set set3 = { 1,1 };
	main_list.push_back(set3);
	Set set4 = { 1,2 };
	main_list.push_back(set4);
	Set set5 = { 1,3 };
	main_list.push_back(set5);
	Set set6 = { 2,2 };
	main_list.push_back(set6);
	Set set7 = { 3,2 };
	main_list.push_back(set7);
	
	Passer(main_list);

	system("pause");
	return 0;
}

void Passer(List lst) {
	List list = lst;
	for (int i = 0; i < list.size(); i++) {
		int a = list.at(i)[0];
		int b = list.at(i)[1];
		int x = A(a, b);
		cout << "A(" << a << ", " << b << ") = " << x << endl;
	}
}

// Ackermann-Peter function:
int A(int m, int n) {
	if (m == 0) {
		return (n + 1);
	}
	if (n == 0) {
		return A(m - 1, 1);
	}
	else {
		return A(m - 1, A(m, n - 1));
	}
}
