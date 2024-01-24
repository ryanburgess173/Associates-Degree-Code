#include "Person.h"

Person::Person()
{
}
Person::Person(std::string firstName, std::string lastName) {
	this->firstName = firstName;
	this->lastName = lastName;
}

Person::~Person()
{
}

void Person::setFirstName(std::string fname) {
	firstName = fname;
}
std::string Person::getFirstName() {
	return firstName;
}
void Person::setLastName(std::string lname) {
	lastName = lname;
}
std::string Person::getLastName() {
	return lastName;
}
