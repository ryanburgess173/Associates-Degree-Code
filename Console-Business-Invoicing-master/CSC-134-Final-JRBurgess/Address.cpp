#include "Address.h"
#include <sstream>


Address::Address()
{
}


Address::~Address()
{
}

Address::Address(std::string street, std::string city,
	std::string state, std::string zip) {

	this->street = street;
	this->city = city;
	this->state = state;
	this->zip = zip;

}

void Address::setStreet(std::string street) {
	this->street = street;
}
std::string Address::getStreet() {
	return this->street;
}
void Address::setCity(std::string city) {
	this->city = city;
}
std::string Address::getCity() {
	return this->city;
}
void Address::setState(std::string state) {
	this->state = state;
}
std::string Address::getState() {
	return this->state;
}
void Address::setZip(std::string zip) {
	this->zip = zip;
}
std::string Address::getZip() {
	return this->zip;
}
std::string Address::print() {
	std::stringstream s;
	s << street << " " << city << " " << state << " " << zip;
	return s.str();
}