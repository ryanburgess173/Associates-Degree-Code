/*
	Johnathan R. Burgess, 10/26/2018
	CSC-134 C++ Programming
	Chapter 6 Project
	This is my own, original work
*/

// PREPROCESSOR DIRECTIVE:
 //==========================
#include <iostream> // for input and output
#include <iomanip> // for output formatting
#include <string> // String Library! :D (even though 
// character arrays are built in, this is a requirement for this project)
#include <fstream> // used for file I/O
//==========================

// Function prototypes:
bool isBookFiction(char fiction);
double getFee(int quantity, char genre, bool isFiction);
double calcBookSalesAndTax(double price, int quantity, double &taxTotal);
std::string setGenre(char genre);
void printoutput(std::ofstream &outPutFile, std::string customerID, std::string bookTitle, std::string bookGenre,
	bool isFiction, int quantity, double price, double subTotal, double taxTotal, double extraFee, double total);
void displayTotals(std::ofstream &outPutFile, double totalSales, int totalOrders);

// main function (type int)
int main() {
	// initializing character arrays to hold strings
	// (max character count of 100)
	std::string bookTitle; // title (string type) variable
	std::string author;
	std::string ISBN;
	std::string fictionOrNon;
	std::string bookGenre;
	// initializing double variable called 'price'
	double price;
	// improving on the previous project by storing this in a variable instead
	double tax_rate = 0.07;

	char fiction = ' ';

	// initializing integer variable called 'quantity'
	int quantity;
	// Boolean for whether it is fiction or not
	bool isFiction;
	// genre selection variable
	char genre = ' ';
	// fees variable
	double extraFee = 0.0;
	//customerID
	std::string customerID;

	double subTotal, taxTotal, total;

	double totalSales = 0.0, avgBookSale;
	int totalOrders = 0;

	// OPENS FILE SECTION:
	//=================================
	std::ifstream inputFile;
	std::ofstream outPutFile;

	inputFile.open("DataFile.txt");
	outPutFile.open("invoice.txt");

	while (inputFile >> customerID >> bookTitle >> author >> ISBN >> price >> quantity >> fiction >> genre) {
		// Tests the ISBN input to see if it contains 9 or 13 characters
		/*if ((ISBN.length() != 9) && (ISBN.length() != 13)) {
			std::cout << ISBN.length();
			std::cout << "Invalid input! Exiting Program....";
			system("pause");
			exit(0);
		}*/

		// Tests to make sure price is below $400
		if ((price >= 400) && (price < 0)) {
			std::cout << "Invalid input! Exiting Program....";
			system("pause");
			exit(0);
		}
		// Tests the logic of the quantity input (validation test)
		if ((quantity >= 100) && (quantity < 1)) {
			std::cout << "Invalid input! Exiting Program....\n";
			system("pause");
			exit(0);
		}

		// calls the isBookFiction function
		isFiction = isBookFiction(fiction);

		// calls the getFree function
		extraFee = getFee(quantity, genre, isFiction);

		double sale = calcBookSalesAndTax(price, quantity, taxTotal);

		subTotal = quantity * price;
		total = sale + extraFee + taxTotal;
		// calls the printoutput function
		printoutput(outPutFile, customerID, bookTitle, bookGenre, isFiction, quantity, price, subTotal, taxTotal, extraFee, total);

		totalOrders++;
		totalSales += subTotal;
	}
	// CLOSES THE FILE(S):
	displayTotals(outPutFile, totalSales, totalOrders);
	inputFile.close();
	outPutFile.close();
	//=================================
	system("pause");
	return 0;
}
bool isBookFiction(char fiction) {
	bool isFiction;
	switch (fiction) {
	case 'F':
	case 'f':
		//std::cout << "You have selected Fiction." << std::endl;
		isFiction = true;
		break;
	case 'N':
	case 'n':
		//std::cout << "You have selected Non-Fiction." << std::endl;
		isFiction = false;
		break;
	default:
		//std::cout << "You have to enter 'F' or 'N'!" << std::endl;
		std::cout << "Invalid input! Exiting Program....\n";
		system("pause");
		exit(0);
	}
	return isFiction;
}
double getFee(int quantity, char genre, bool isFiction) {
	// For quantities apply fees following these rules:
		//========================================
	double fees;
	if (quantity > 20) {
		fees = 50.00;
	}
	else if ((quantity >= 15) && (quantity <= 19)) {
		fees = 40.00;
	}
	else if ((quantity >= 10) && (quantity <= 14)) {
		fees = 30.00;
	}
	else if ((quantity >= 5) && (quantity <= 10)) {
		fees = 20.00;
	}
	else if (quantity < 5) {
		fees = 10.00;
	}

	if ((genre == 'R') && (isFiction == false)) {
		fees = 0.00;
	}
	//========================================
	return fees;
}
double calcBookSalesAndTax(double price, int quantity, double &taxTotal) {
	taxTotal = (price * quantity) * 0.07;
	double sale = (price*quantity);
	return sale;
}
std::string setGenre(char genre) {
	std::string bookGenre;
	// Validation block for the genre input
		//=============================================================
	if ((genre == 'R') || (genre == 'r')) {
		bookGenre = "Romance";
	}
	else if ((genre == 'D') || (genre == 'd')) {
		bookGenre = "Drama";
	}
	else if ((genre == 'M') || (genre == 'm')) {
		bookGenre = "Mystery";
	}
	else {
		std::cout << "Invalid input! Exiting Program....\n";
		system("pause");
		exit(0);
	}
	//========================================================
	return bookGenre;
}
// printoutput function body
// -------------------------------------------------------------------------------------------------------------------------
void printoutput(std::ofstream &outPutFile, std::string customerID, std::string bookTitle, std::string bookGenre,
	bool isFiction, int quantity, double price, double subTotal, double taxTotal, double extraFee, double total) {

	outPutFile << "\n---------------------------------------------------------------------------------" << std::endl;
	outPutFile << "Invoice" << std::endl;
	outPutFile << "Customer ID: " << customerID << ":" << std::endl;
	outPutFile << bookTitle << "\t\t";
	if (isFiction == true) {
		outPutFile << "Fiction";
	}
	else {
		outPutFile << "Non-Fiction";
	}
	outPutFile << "\t\t" << bookGenre << "\t\t" << quantity << "@" << price << "\t\tsubtotal: " << subTotal << std::endl;
	outPutFile << std::fixed << std::showpoint << std::setprecision(2);
	outPutFile << "\nTotal Book Sales: " << std::setw(17) << subTotal << std::endl;
	outPutFile << "Tax:   " << std::setw(28) << taxTotal << std::endl;
	outPutFile << "Fees:  " << std::setw(28) << extraFee << std::endl;
	outPutFile << "Total: " << std::setw(28) << total << std::endl;
	outPutFile << "---------------------------------------------------------------------------------" << std::endl;
}
//-----------------------------------------------------------------------------------------------------------------------------

// displayTotals function body
void displayTotals(std::ofstream &outPutFile, double totalSales, int totalOrders) {
	outPutFile << "\n=================================================================================" << std::endl;
	outPutFile << "REPORT TOTALS:\n" << std::endl;
	outPutFile << std::fixed << std::showpoint << std::setprecision(2);
	outPutFile << "Total Book Sales: " << std::setw(19) << totalSales << std::endl;
	outPutFile << "Average Book Order: " << std::setw(17) << (totalSales / totalOrders) << std::endl;
	outPutFile << "\n=================================================================================";
}