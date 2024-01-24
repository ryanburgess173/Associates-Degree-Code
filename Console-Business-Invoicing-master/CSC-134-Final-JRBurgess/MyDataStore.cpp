#include "MyDataStore.h"
#include <fstream>

MyDataStore* MyDataStore::iInstance;
Customer customers[5];
void getCustomerList(Customer[], int);

MyDataStore::MyDataStore() {
	std::cout << "In constructor ..." << std::endl;
	getCustomerList(customers, 5);
}

MyDataStore* MyDataStore::GetInstance() {
	if (iInstance == NULL) {
		iInstance = new MyDataStore();
	}
	return iInstance;
}
void MyDataStore::getBooks(Book books[], int size) {
	std::ifstream input;
	input.open("Text.txt");
	std::string ISBN, title, author;
	double price = 0.0;

	int i = 0;
	while (!input.eof()) {
		input >> title;
		input >> author;
		input >> ISBN;
		input >> price;
		Book b = Book(title, author, ISBN, price);
		if (i < 6) {
			books[i] = b;
			i++;
		}
	}
}
Customer MyDataStore::getCustomer(int customerId) {
	for (int j = 0; j < 6; j++) {
		int num = customers[j].getID();
		if (num == customerId) {
			return customers[j];
		}
	}
}
void getCustomerList(Customer cust[], int size) {
	std::ifstream input2;
	input2.open("Customer.txt");
	int customerId;
	std::string firstN, lastN, street, city, state, zip;

	int i = 0;
	while (!input2.eof()) {
		input2 >> customerId;
		input2 >> firstN;
		input2 >> lastN;
		input2 >> street;
		input2 >> city;
		input2 >> state;
		input2 >> zip;
		Address addr = Address(street, city, state, zip);
		Customer c = Customer(customerId, firstN, lastN, addr);
		if (i < 6) {
			cust[i] = c;
			i++;
		}
	}
}