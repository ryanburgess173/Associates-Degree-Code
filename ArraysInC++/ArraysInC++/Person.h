#pragma once
#include <string>
class Person
{
public:
	Person();
	~Person();
	Person(std::string firstName, std::string lastName);

private:
	std::string firstName;
	std::string lastName;

public:
	void setFirstName(std::string fname);
	std::string getFirstName();
	void setLastName(std::string lname);
	std::string getLastName();
};

