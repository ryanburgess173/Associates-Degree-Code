/*
	Johnathan R. Burgess, CSC-234 Advanced C++ Programming
	April 28th, 2019
	Final Project II
*/

#include "Seat.h"
#include "TicketManager.h"

TicketManager::TicketManager()
{
}
TicketManager::~TicketManager()
{
}

void TicketManager::AddSeat(Seat s, int i, int j) {
	SeatStructures[i][j] = s;
}
Seat TicketManager::GetSeat(int i, int j) {
	return SeatStructures[i][j];
}
std::string TicketManager::SalesReport() {
	int sold = 0;
	int available = 0;
	double sales = 0.0;
	for (int i = 0; i < 15; i++) {
		for (int j = 0; j < 30; j++) {
			if (GetSeat(i, j).soldStatus == 1) {
				sold += 1;
				sales += GetSeat(i, j).GetPrice();
			}
			else {
				available += 1;
			}
		}
	}
	std::stringstream ss;
	ss << "Seats Sold........:  " << sold << std::endl;
	ss << "Seats Available...:  " << available << std::endl;
	ss << "Total Sales.......: $" << sales << std::endl;
	std::string strToReturn;
	strToReturn = ss.str();
	return strToReturn;
}
void TicketManager::SetSeatingChart() {
	std::stringstream ss;
	ss << "        ";
	for (int i = 0; i < 10; i++) {
		ss << i;
	}
	for (int i = 0; i < 10; i++) {
		ss << i;
	}
	for (int i = 0; i < 10; i++) {
		ss << i;
	}
	ss << "\n";
	for (int i = 0; i < 15; i++) {
		ss << "Row " << (i+1) << ":\t";
		for (int j = 0; j < 30; j++) {
			Seat cS = GetSeat(i, j);
			bool cSStat = cS.soldStatus;
			if (cSStat == 1) {
				ss << "*";
			}
			if (cSStat == 0) {
				ss << "#";
			}
		}
		ss << "\n";
	}
	// convert our string stream into a string
	// and assign it to our string variable 'seatingChart'
	seatingChart = ss.str();
}
std::string TicketManager::GetSeatingChart() {
	return seatingChart;
}

std::string TicketManager::TicketRequest(TicketManager &tm, int startingSeatRequested, int numberOfSeatsRequested, int desiredRow) {
	double totalPrice = 0.0;
	bool problemOccured = false;
	std::stringstream ss;
	for (int j = startingSeatRequested; j < (startingSeatRequested + numberOfSeatsRequested); j++) {
		
		bool check = tm.GetSeat(desiredRow-1, j-1).soldStatus;
		if (check == 1) {
			ss << std::endl;
			ss << "===ERROR======================================" << std::endl;
			ss << "This seating arrangement is not available." << std::endl;
			ss << "Seat #" << j << " on Row #" << desiredRow << " is not available." << std::endl;
			ss << "==============================================" << std::endl;
			totalPrice = 0.0;
			problemOccured = true;
			break;
		}
		if (check == 0) {
			// increments the total price
			totalPrice += tm.GetSeat(desiredRow, j).GetPrice();
			jsToUpdate.push_back(j);
		}
		else {
			std::cout << "PROGRAMMER: issue with your data." << std::endl;
		}
	}
	if (!problemOccured) {
		ss << std::endl;
		ss << "===PURCHASE===================================" << std::endl;
		ss << "Number of Seats...:  " << numberOfSeatsRequested << std::endl;
		ss.precision(2);
		ss << "Price Per Seat....: $" << std::fixed << tm.GetSeat(desiredRow, 0).GetPrice() << std::endl;
		ss << "Total.............: $" << std::fixed << totalPrice << std::endl;
		ss << "==============================================" << std::endl;
	}
	std::string strToReturn = ss.str();
	return strToReturn;
}