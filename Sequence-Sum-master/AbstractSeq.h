// Johnathan R. Burgess
// Student ID: 1763590
// CSC-234 Advanced C++ Programming
// Final Project I: Sequence Sum
// April 27th, 2019

#pragma once
// This is our abstract class
class AbstractSeq
{
public:
	AbstractSeq();
	virtual int fun(int k) = 0;

	void printSeq(int k, int m);
	int sumSeq(int k, int m);
	~AbstractSeq();
};