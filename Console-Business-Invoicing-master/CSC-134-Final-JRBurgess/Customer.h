#pragma once
#include <string>
#include "Address.h"
class Customer
{
public:
	Customer();
	Customer(int custID, std::string firstName, std::string lastName, Address address);
	~Customer();

	void setID(int custID);
	int getID();

	void setFname(std::string firstName);
	std::string getFname();

	void setLname(std::string lastName);
	std::string getLname();

	void setAddress(Address address);
	Address getAddress();

	std::string print();

private:
	int custID;
	std::string firstName;
	std::string lastName;
	Address address;
};

