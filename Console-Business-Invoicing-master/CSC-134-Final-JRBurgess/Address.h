#pragma once
#include <string>
class Address
{
public:
	Address();
	Address(std::string street, std::string city,
		std::string state, std::string zip);
	~Address();

private:
	std::string street;
	std::string city;
	std::string state;
	std::string zip;

public:
	void setStreet(std::string street);
	std::string getStreet();
	void setCity(std::string city);
	std::string getCity();
	void setState(std::string state);
	std::string getState();
	void setZip(std::string zip);
	std::string getZip();
	std::string print();
};