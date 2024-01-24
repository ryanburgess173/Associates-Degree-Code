#include "Customer.h"
#include <sstream>


Customer::Customer()
{
}


Customer::~Customer()
{
}

Customer::Customer(int custID, std::string firstName, std::string lastName, Address address) {
	this->custID = custID;
	this->firstName = firstName;
	this->lastName = lastName;
	this->address = address;
}

void Customer::setID(int custID) {
	this->custID = custID;
}
int Customer::getID() {
	return this->custID;
}

void Customer::setFname(std::string firstName) {
	this->firstName = firstName;
}
std::string Customer::getFname() {
	return this->firstName;
}

void Customer::setLname(std::string lastName) {
	this->lastName = lastName;
}
std::string Customer::getLname() {
	return this->lastName;
}

void Customer::setAddress(Address address) {
	this->address = address;
}
Address Customer::getAddress() {
	return this->address;
}

std::string Customer::print() {
	std::stringstream s;
	s << custID << " " << firstName << " " << lastName << std::endl << 
		address.getStreet() << '\n' << address.getCity() << ", " << address.getState()
		<< ' ' << address.getZip() << std::endl;
	return s.str();
}