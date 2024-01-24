#include "MyDataStore.h"
#include "Book.h"
using namespace std;

void main() {
	MyDataStore* obj1 = MyDataStore::GetInstance();
	MyDataStore* obj2 = MyDataStore::GetInstance();

	//cout << obj1 << endl;
	//cout << obj2 << endl;

	Book b1 = Book();
	Book b2 = Book();

	//cout << &b1 << endl;
	//cout << &b2 << endl;

	// declare a book array....
	Book books[6];
	//send array to get books...
	MyDataStore::getBooks(books, 6);
	// loop through the filled in book array and just show authors
	for (Book b : books) {
		//cout << b.getAuthor() << endl;
	}

	Customer c1 = MyDataStore::getCustomer(2345);
	cout << c1.print() << endl;

	for (int i = 0; i < 6; i++) {
		cout << books[i].getTitle() << endl;
		cout << books[i].getAuthor() << endl;
		cout << books[i].getPrice() << endl << endl;
	}
	
	system("pause");
}