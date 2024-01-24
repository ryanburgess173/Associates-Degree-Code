#pragma once
#include <string>
class Book
{
public:
	Book();
	~Book();
	Book(std::string title, std::string author, std::string ISBN, double price);

private:
	std::string ISBN;
	std::string author;
	std::string title;
	double price;

public:
	void setISBN(std::string ISBN);
	std::string getISBN();
	void setAuthor(std::string author);
	std::string getAuthor();
	void setTitle(std::string title);
	std::string getTitle();
	void setPrice(double price);
	double getPrice();
	std::string print();
};