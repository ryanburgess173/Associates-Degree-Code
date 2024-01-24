/*
	Johnathan R. Burgess, CSC-234 Advanced C++ Programming
	April 28th, 2019
	Final Project II
*/

#pragma once
#include "Seat.h"
#include <string>
#include <sstream>
#include <vector>

class TicketManager
{
public:
	TicketManager();
	std::vector<int> jsToUpdate;
	std::string seatingChart;

private:
	Seat SeatStructures[15][30];

public:
	void AddSeat(Seat s, int i, int j);
	Seat GetSeat(int i, int j);

	std::string SalesReport();

	void SetSeatingChart();
	std::string GetSeatingChart();

	std::string TicketRequest(TicketManager &tm, int startingSeatRequested, int numberOfSeatsRequested, int desiredRow);

	~TicketManager();
};

