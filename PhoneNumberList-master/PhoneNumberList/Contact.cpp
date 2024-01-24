/*
	Johnathan R. Burgess
	Advanced C++ Programming
	3/3/2019
*/

#include "Contact.h"

Contact::Contact() {

}

Contact::Contact(char tempFN[30], char tempLN[30], char tempPN[14])
{
	strcpy_s(this->firstName, tempFN);
	strcpy_s(this->lastName, tempLN);
	strcpy_s(this->phoneNumber, tempPN);
}

Contact::~Contact()
{
}
std::string Contact::getLastName() {
	return this->lastName;
}
std::string Contact::getFirstName() {
	return this->firstName;
}
std::string Contact::getPhoneNumber() {
	return this->phoneNumber;
}