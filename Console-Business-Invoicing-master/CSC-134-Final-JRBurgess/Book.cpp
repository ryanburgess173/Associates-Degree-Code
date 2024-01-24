#include "Book.h"
#include <sstream>

Book::Book()
{
}

Book::Book(std::string title, std::string author, std::string ISBN, double price) {
	this->ISBN = ISBN;
	this->author = author;
	this->title = title;
	this->price = price;
}
Book::~Book()
{
}
void Book::setISBN(std::string ISBN) {
	int character_Count = 0;
	for (int i = ISBN.length(); i > 0; i--) {
		character_Count++;
	}
	if ((character_Count == 9) || (character_Count == 13)) {
		this->ISBN = ISBN;
	}
	else {
		this->ISBN = "0";
	}
}
std::string Book::getISBN() {
	return this->ISBN;
}
void Book::setAuthor(std::string author) {
	this->author = author;
}
std::string Book::getAuthor() {
	return this->author;
}
void Book::setTitle(std::string title) {
	this->title = title;
}
std::string Book::getTitle() {
	return this->title;
}
void Book::setPrice(double price) {
	if ((price >= 1.00) && (price <= 200.00)) {
		this->price = price;
	}
	else {
		this->price = 0.0;
	}
}
double Book::getPrice() {
	return this->price;
}
std::string Book::print() {
	std::stringstream s;
	s << ISBN << " " << author << " " << title << " " << price;
	return s.str();
}