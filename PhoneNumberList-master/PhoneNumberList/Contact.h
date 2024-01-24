/*
	Johnathan R. Burgess
	Advanced C++ Programming
	3/3/2019
*/
#include <cstring>
#include <string>
class Contact
{
public:
	Contact();
	Contact(char tempFN[30], char tempLN[30], char tempPN[14]);
	~Contact();
	std::string getLastName();
	std::string getFirstName();
	std::string getPhoneNumber();
private:
	char firstName[30];
	char lastName[30];
	char phoneNumber[14];
};