// Johnathan R. Burgess
// Student ID: 1763590
// CSC-234 Advanced C++ Programming
// Final Project I: Sequence Sum
// April 27th, 2019
#pragma once
#include "AbstractSeq.h"

class OddSeq : public AbstractSeq
{
public:
	OddSeq();
	~OddSeq();
	int fun(int k);
	int odd(int k);
};

