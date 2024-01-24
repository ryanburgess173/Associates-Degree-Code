#pragma once
#include "Book.h"
#include "Customer.h"
#include <iostream>
class MyDataStore
{
private:
	static MyDataStore* iInstance;

public:
	static MyDataStore* GetInstance();
	static void getBooks(Book books[], int size);
	static Customer getCustomer(int customerId);

private:
	// private constructor
	MyDataStore();
};

