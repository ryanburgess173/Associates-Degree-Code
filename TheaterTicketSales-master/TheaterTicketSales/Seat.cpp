/*
	Johnathan R. Burgess, CSC-234 Advanced C++ Programming
	April 28th, 2019
	Final Project II
*/

#include "Seat.h"

Seat::Seat()
{
	price = 0.0;
	soldStatus = 0;
}
Seat::Seat(double p) {
	price = p;
	// by default seats are unsold
	soldStatus = 0;
}

Seat::~Seat()
{
}

double Seat::GetPrice() {
	return price;
}
void Seat::SetPrice(double p) {
	price = p;
}
int Seat::GetStatus() {
	return soldStatus;
}
void Seat::SetStatus(int st) {
	if (st == 1) {
		soldStatus = 1;
	}
	else if (st == 0) {
		soldStatus = 0;
	}
}