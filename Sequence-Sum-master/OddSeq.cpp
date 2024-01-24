// Johnathan R. Burgess
// Student ID: 1763590
// CSC-234 Advanced C++ Programming
// Final Project I: Sequence Sum
// April 27th, 2019

#include "OddSeq.h"
#include "AbstractSeq.h"
#include <iostream>

// class constructor
OddSeq::OddSeq()
{
}

// gets an odd number corresponding to the passed index
int OddSeq::odd(int k) {
	return 2 * k + 1;
}

// This is a pure virtual function which in this case
// is being used to call and odd method.
// This may be different depending on the subclass used.
// For instance fun(k) as part of an EvenSeq class could
// say "return even(k);"
int OddSeq::fun(int k) {
	return odd(k); 
}

// class deconstructor
OddSeq::~OddSeq()
{
}