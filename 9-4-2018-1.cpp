// Johnathan R. Burgess, 9/4/2018, C++ Programming, CSC-134
// Focus on your goals! You will become a great computer scientist

// PREPROCESSOR DIRECTIVE
#include <iostream>
#include <string>

// int type main function of program
int main(){
	
	// Holds the username
	string usr_name;
	// holds if it's the admin account
	bool isAdmin = false;
	// holds if it's the standard user account
	bool isStandard = false;
	
	std::cout << "Login: ";
	std::cin >> usr_name;
	if(usr_name == "hello"){
		std::cout << "welcome";
	}

	// returns a value of 0 to satisfy the int type function main
	return 0;
}
