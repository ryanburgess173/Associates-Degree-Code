// Johnathan R. Burgess
// Student ID: 1763590
// CSC-234 Advanced C++ Programming
// Final Project I: Sequence Sum
// April 27th, 2019

#include "AbstractSeq.h"
#include <iostream>
// class constructor
AbstractSeq::AbstractSeq()
{
}

// printing a sequence of numbers is abstract and can be
// applied to all sorts of sequences, not just odd ones
void AbstractSeq::printSeq(int k, int m) {
	std::cout << "{ ";
	while (k <= m) {
		std::cout << fun(k) << ", ";
		k++;
	}
}
// sums up all the elements in our sequence
int AbstractSeq::sumSeq(int k, int m) {
	int sum = 0;
	while (k <= m) {
		// increment sum by the value of the next item in our sequence
		sum += fun(k);
		k++;
	}
	return sum;
}
// class deconstructor
AbstractSeq::~AbstractSeq()
{
}