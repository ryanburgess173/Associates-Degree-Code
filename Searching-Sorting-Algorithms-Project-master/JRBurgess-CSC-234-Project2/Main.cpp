/*
	Johnathan R. Burgess
	CSC-234, Advanced C++ Programming
	Project 2 – Chapter 9, Searching and Sorting Algorithms.
	Initial Creation: February 2nd, 2019

	updated:
		8:01pm, February 2nd, 2019
		1:10am, February 3rd, 2019
		4:27pm, February 3rd, 2019

	Note: This program is scalable due to using vectors instead of arrays :)
*/

// preprocessor directive
#include <iostream>
#include <iomanip>
#include <vector>
#include <fstream>

using namespace std;

// type definition called List which represents an integer vector
typedef vector<int> List;

// function definitions
int linearSearch(List, int, int &numberOfComparisons);
List bubbleSort(List, int &bubbleNumberOfSwaps, int &bubbleNumberOfComparisons);
List selectionSort(List, int &selectionNumberOfSwaps, int &selectionNumberOfComparisons);
int binarySearch(List, int, int &binarySearchComparisons);
List getData();
void outputData(int numberToFind, List list, List selectionList, int bubbleNumberOfSwaps, int bubbleNumberOfComparisons, int linearSearchComparisons,
	int linearSearchResult, int selectionNumberOfSwaps, int selectionNumberOfComparisons,
	int binarySearchComparisons, int binarySearchResult);

// main function
int main() {
	int numberToFind = 976;

	// Part 1
	List list = getData(); // original list

	// Part 2
	int bubbleNumberOfSwaps = 0;
	int bubbleNumberOfComparisons = 0;
	int linearSearchComparisons = 0;
	List bubbleList = bubbleSort(list, bubbleNumberOfSwaps, bubbleNumberOfComparisons); // bubbleSorted list
	int linearSearchResult = linearSearch(bubbleList, numberToFind, linearSearchComparisons);

	// Part 3
	int selectionNumberOfSwaps = 0;
	int selectionNumberOfComparisons = 0;
	int binarySearchComparisons = 0;
	List selectionList = selectionSort(list, selectionNumberOfSwaps, selectionNumberOfComparisons);
	int binarySearchResult = binarySearch(selectionList, numberToFind, binarySearchComparisons);

	// Part 4
	outputData(numberToFind, list, selectionList, bubbleNumberOfSwaps, bubbleNumberOfComparisons, linearSearchComparisons,
		linearSearchResult, selectionNumberOfSwaps, selectionNumberOfComparisons,
		binarySearchComparisons, binarySearchResult);

	system("pause");

	return 0;
}

// Read Data from File Function
List getData() {
	List l;
	ifstream namesFile;
	//open the .txt files
	namesFile.open("chapter9hw.txt");
	// if there isn't a namesFile
	if (!namesFile) {
		// do this
		cout << "Error opening data file\n";
	}
	// otherwise,
	else {
		// while you don't encounter an end of file error from namesFile
		int count = 0;
		int a;
		while (!namesFile.eof()) {
			namesFile >> a;
			l.push_back(a);
		}
		namesFile.close();
	}
	return l;
}

// This function performs linear searches of an array and returns the index
// of the found item.
int linearSearch(List bubbleList, int item, int &linearSearchComparisons) {
	bool found = false;
	int position = -1;
	int index = 0;
	while ((index < bubbleList.size()) && (found == false)) {
		linearSearchComparisons++;
		if (bubbleList.at(index) == item) {
			found = true;
			position = index;
		}
		index++;
	}
	return position;
}
// This function will sort an array with the bubble-sort algorithm.
List bubbleSort(List list, int &bubbleNumberOfSwaps, int &bubbleNumberOfComparisons) {
	int temp;
	bool madeASwap;
	do {
		madeASwap = false;
		for (int count = 0; count < (list.size()-1); count++) {
			bubbleNumberOfComparisons++;
			if (list.at(count) > list.at(count + 1)) {
				temp = list.at(count);
				list.at(count) = list.at(count + 1);
				list.at(count + 1) = temp;
				madeASwap = true;

				// accesses the pointed variable
				bubbleNumberOfSwaps++;
			}
		}
	} while (madeASwap == true);
	return list;
}

List selectionSort(List list, int &selectionNumberOfSwaps, int &selectionNumberOfComparisons) {
	int index, minIndex, minValue;
	for (int startScan = 0; startScan < (list.size() - 1); startScan++) {
		index = startScan;
		minIndex = startScan;
		minValue = list.at(startScan);
		for (index = (startScan + 1); index < list.size(); index++) {
			selectionNumberOfComparisons++;
			if (list.at(index) < minValue) {
				minValue = list.at(index);
				minIndex = index;
				selectionNumberOfSwaps++;
			}
		}
		list.at(minIndex) = list.at(startScan);
		list.at(startScan) = minValue;
	}
	return list;
}
// this function performs a binary search
int binarySearch(List list, int item, int &binarySearchComparisons) {
	int first = 0;
	int last = list.size();
	bool found = false;
	int position = -1;
	int middle;
	while ((found != true) && (first <= last)) {
		middle = ((last-first)/2)+first;
		binarySearchComparisons++;
		if (list.at(middle) == item) {
			found = true;
			position = middle;
		}
		else if (list.at(middle) > item) {
			last = middle - 1;
		}
		else {
			first = middle + 1;
		}
	}
	return position;
}

void outputData(int numberToFind, List list, List selectionList, int bubbleNumberOfSwaps, int bubbleNumberOfComparisons, int linearSearchComparisons,
	int linearSearchResult, int selectionNumberOfSwaps, int selectionNumberOfComparisons,
	int binarySearchComparisons, int binarySearchResult) {

	cout << "Unsorted Array: ";
	for (int i = 0; i < list.size(); i++) {
		cout << list.at(i) << ' ';
	}
	cout << endl << endl << "Sorted Array: ";
	for (int i = 0; i < list.size(); i++) {
		cout << selectionList.at(i) << ' ';
	}
	cout << endl << endl << "Searching:\tKey=" << numberToFind << endl << endl;
	cout << left << setw(10);
	cout << "\t\tIndex\t# of Comparisons" << endl;
	cout << "Linear\t\t" << linearSearchResult << "\t" << linearSearchComparisons << endl;
	cout << "Binary\t\t" << binarySearchResult << "\t" << binarySearchComparisons << endl << endl << endl;
	cout << "Sorting:" << endl;
	cout << "\t\tSwaps\tComparisons" << endl;
	cout << "Bubble\t\t" << bubbleNumberOfSwaps << "\t" << bubbleNumberOfComparisons << endl;
	cout << "Selection\t" << selectionNumberOfSwaps << "\t" << selectionNumberOfComparisons << endl << endl;
}