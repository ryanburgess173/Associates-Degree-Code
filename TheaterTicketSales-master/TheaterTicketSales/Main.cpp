/*
	Johnathan R. Burgess, CSC-234 Advanced C++ Programming
	April 28th, 2019
	Final Project II
*/

#include <iostream>
#include <fstream>
#include "Seat.h"
#include <string>
#include "TicketManager.h"

// Menu function
void Menu(TicketManager tm);
// RequestTickets function
void RequestTickets(TicketManager tm);
void Report(TicketManager tm);
// =======================================================================================
// main function
// =======================================================================================
int main() {

	const int ROWS = 15;
	const int COLUMNS = 30;

	// This is our TicketManager object 'tm'.
	// This will hold all of our data.
	TicketManager tm = TicketManager();

	// define a couple of fstreams
	std::fstream seatAvailability, seatPrices;

	seatAvailability.open("SeatAvailability.dat", std::ios::in);
	if (!seatAvailability) {
		std::cout << "Error opening data file.\n";
	}
	else {
		seatPrices.open("SeatPrices.dat", std::ios::in);
		if (!seatPrices) {
			std::cout << "Error opening data file.\n";
		}
		else {
			for (int i = 0; i < ROWS; i++) {
				std::string line;
				seatAvailability >> line;
				double price;
				seatPrices >> price;
				for (int j = 0; j < COLUMNS; j++) {
					Seat currentSeat = Seat();
					if (line[j] == '#') {
						currentSeat.soldStatus = 0;
					}
					else if (line[j] == '*') {
						currentSeat.soldStatus = 1;
					}
					currentSeat.SetPrice(price);
					tm.AddSeat(currentSeat, i, j);
				}
			}
		}
	}
	seatAvailability.close();
	seatPrices.close();

	// Displays the menu for the user
	Menu(tm);

	system("pause");
	return 0;
}
// =======================================================================================

// =======================================================================================
// Menu function
// =======================================================================================
void Menu(TicketManager tm) {
	int op;
	do{
		std::cout << " Menu " << std::endl;
		std::cout << " 1.Seating Chart " << std::endl;
		std::cout << " 2.Request Tickets " << std::endl;
		std::cout << " 3.Print Sales " << std::endl;
		std::cout << " 4.Exit " << std::endl;
		std::cout << "Choice: ";
		std::cin >> op;

		while (op < 1 || op > 4)
		{
			std::cout << "Please Enter Your Choice Again: " << std::endl;
			std::cin >> op;
		}

		switch (op)
		{

		// Seating Chart item selected by user
		case 1:
			std::cout << std::endl;
			tm.SetSeatingChart();
			std::cout << tm.GetSeatingChart();
			break;

		// Ticket Request Item Selected by user
		case 2:
			RequestTickets(tm);
			break;
		// Sales Report item selected by user
		case 3:
			Report(tm);
			break;

		// Exit item selected by user
		case 4:
			break;
		}
	} while (op != 4);
}
// =======================================================================================

// =======================================================================================
// RequestTickets function
// =======================================================================================
void RequestTickets(TicketManager tm) {
	int numberOfSeatsRequested;
	std::cout << "How many seats do you wish to purchase? :";
	
	// If the input is valid:
	if (std::cin >> numberOfSeatsRequested) {
		// do
		// checks to see if the user requested a number between 1 and 30
		if ((numberOfSeatsRequested > 0) && (numberOfSeatsRequested < 31)) {
			int desiredRow;
			std::cout << "What is your desired row? :";

			// If the input is valid:
			if (std::cin >> desiredRow) {
				// do
				// checks to see if the user requested a number between 1 and 15
				if ((desiredRow > 0) && (desiredRow < 16)) {
					int startingSeatRequested;
					std::cout << "What starting seat number? :";

					// If the input is valid:
					if (std::cin >> startingSeatRequested) {
						// do
						// checks to see if the user requested a number between 1 and 30
						if ((startingSeatRequested > 0) && (startingSeatRequested < 31)) {
							std::string output = tm.TicketRequest(tm, startingSeatRequested, numberOfSeatsRequested, desiredRow);
							std::cout << output << std::endl;
							if (output[4] == 'P') {
								std::cout << "Do you wish to purchase these tickets? (y/n) :";
								std::string input;
								if (std::cin >> input) {
									for (int i = 0; i < tm.jsToUpdate.size(); i++) {

										//==================================================================
										// THIS IS THE PART OF THE PROGRAM THAT IS NOT WORKING
										//==================================================================
										//std::cout << std::boolalpha << tm.GetSeat(desiredRow, tm.jsToUpdate.at(i)).soldStatus << std::endl;
										Seat seat = Seat();
										seat.SetStatus(1);
										tm.AddSeat(seat, desiredRow, tm.jsToUpdate.at(i));
										//==================================================================
									}
									// Updates the seating chart
									tm.SetSeatingChart();
								}
								else {
									std::cout << "Invalid input. Sorry." << std::endl;
								}
							}
						}
						else {
							std::cout << "Invalid entry. Please try again later." << std::endl;
						}
					}
					// otherwise
					else {
						// do
						std::cout << "Invalid input. Try again later." << std::endl;
					}
				}
				else {
					std::cout << "Invalid entry. Please try again later." << std::endl;
				}
			}
			// otherwise
			else {
				// do
				std::cout << "Invalid input. Try again later." << std::endl;
			}
		}
		else {
			std::cout << "Invalid entry. Please try again later." << std::endl;
		}
	}
	// otherwise
	else {
		// do
		std::cout << "Invalid input. Try again later." << std::endl;
	}
	
}
// =======================================================================================

void Report(TicketManager tm) {
	std::string report = tm.SalesReport();
	std::cout << report << std::endl;
}