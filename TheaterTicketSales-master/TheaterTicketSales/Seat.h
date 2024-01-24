/*
	Johnathan R. Burgess, CSC-234 Advanced C++ Programming
	April 28th, 2019
	Final Project II
*/

#pragma once
#include <iostream>
class Seat
{
public:
	Seat();
	Seat(double p);
	~Seat();

	int soldStatus;
private:
	// this will hold the price and sold status for each seat object
	double price;
public:
	double GetPrice();
	void SetPrice(double price);
	int GetStatus();
	void SetStatus(int st);
};
