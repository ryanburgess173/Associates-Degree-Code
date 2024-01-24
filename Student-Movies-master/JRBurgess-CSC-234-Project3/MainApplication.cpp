/*
	Johnathan R. Burgess
	Movie Statistics Program
	(Problem details can be found in problem #7 of page 702 from the book.)
*/

// PREPROCESSOR DIRECTIVE:
#include <iostream>
#include <vector>
#include <iomanip>
#include <fstream>
#include <string>

typedef std::vector<int> NumberList;
typedef std::vector<std::string> NameList;

void GetData(NumberList *movies_seen_per_month, NameList *students);
double Average(NumberList *movies_seen_per_month);
int Median(NumberList *movies_seen_sorted);
int Mode(NumberList *movies_seen_sorted);
NumberList BubbleSort(NumberList list);
std::string MostMoviesSeen(NameList *students, NumberList *movies_seen_per_month, int *mostMoviesSeen);
std::string LeastMoviesSeen(NameList *students, NumberList *movies_seen_per_month, int *mostMoviesSeen);
void Output(double average, int median, int mode, std::string studentMost, std::string studentLeast);

int main() {

	//#####################################################################
	// Two parallel vectors (they're of types NumberList and NameList because
	// of my typedefs above ^
	//#####################################################################

	// an integer vector which will store number of movies seen per month
	NumberList movies_seen_per_month;

	// a string vector which will store names of students
	NameList students;

	//#####################################################################

	// gets our data from our data file and adds content to our NumberList and NameList
	GetData(&movies_seen_per_month, &students);

	// Gets the average
	double average = Average(&movies_seen_per_month);

	NumberList movies_seen_sorted = BubbleSort(movies_seen_per_month);

	int median = Median(&movies_seen_sorted);

	int mode = Mode(&movies_seen_sorted);

	int mostMoviesSeen = 0;

	std::string studentMostMoviesSeen = MostMoviesSeen(&students, &movies_seen_per_month, &mostMoviesSeen);
	std::string studentLeastMoviesSeen = LeastMoviesSeen(&students, &movies_seen_per_month, &mostMoviesSeen);

	Output(average, median, mode, studentMostMoviesSeen, studentLeastMoviesSeen);

	system("pause");
	return 0;
}
void GetData(NumberList *movies_seen_per_month, NameList *students) {
	std::ifstream namesFile;
	//open the .txt files
	namesFile.open("StudentMovies.txt");
	// if there isn't a namesFile
	if (!namesFile) {
		// do this
		std::cout << "Error opening data file\n";
	}
	// otherwise,
	else {
		// while you don't encounter an end of file error from namesFile
		int count = 0;
		std::string a, b;
		int c;
		while (!namesFile.eof()) {
			namesFile >> a >> b >> c;
			// concatenates the student's first and last names into one string
			std::string concat = a + ' ' + b;
			// adds the student's full name to the students NameList
			students->push_back(concat);
			// adds the number of movies seen per month to the movies_seen_per_month NumberList
			movies_seen_per_month->push_back(c);
		}
		namesFile.close();
	}
}
double Average(NumberList *movies_seen_per_month) {
	int total = 0, number = 0;
	for (int count = 0; count < movies_seen_per_month->size(); count++) {
		total += movies_seen_per_month->at(count);
		number++;
	}
	return (total / number);
}
int Median(NumberList *movies_seen_sorted) {
	int median1 = movies_seen_sorted->at(movies_seen_sorted->size() / 2);
	int median2 = movies_seen_sorted->at((movies_seen_sorted->size() / 2) + 1);
	int trueMedian = ((median1 + median2) / 2);
	return trueMedian;
}
int Mode(NumberList *movies_seen_sorted) {
	int count, maxCount = 0, finalValue;
	for (int i = 0; i < movies_seen_sorted->size(); i++) {
		count = 0;
		for (int j = 0; j < i; j++) {
			if (movies_seen_sorted->at(i) == movies_seen_sorted->at(j)) {
				count++;
			}
		}
		if (count > maxCount) {
			maxCount = count;
			finalValue = movies_seen_sorted->at(i);
		}
	}
	return finalValue;
}
// This function will sort a vector with the bubble-sort algorithm.
NumberList BubbleSort(NumberList list) {
	int temp;
	bool madeASwap;
	do {
		madeASwap = false;
		for (int count = 0; count < (list.size() - 1); count++) {
			if (list.at(count) > list.at(count + 1)) {
				temp = list.at(count);
				list.at(count) = list.at(count + 1);
				list.at(count + 1) = temp;
				madeASwap = true;
				// accesses the pointed variable
			}
		}
	} while (madeASwap == true);
	return list;
}
std::string MostMoviesSeen(NameList *students, NumberList *movies_seen_per_month, int *mostMoviesSeen) {
	int key = 0;
	for (int i = 0; i < students->size(); i++) {
		if (movies_seen_per_month->at(i) > *mostMoviesSeen) {
			*mostMoviesSeen = movies_seen_per_month->at(i);
			key = i;
		}
	}
	return students->at(key);
}
std::string LeastMoviesSeen(NameList *students, NumberList *movies_seen_per_month, int *mostMoviesSeen) {
	int key = 0;
	for (int i = 0; i < students->size(); i++) {
		if (movies_seen_per_month->at(i) < *mostMoviesSeen) {
			*mostMoviesSeen = movies_seen_per_month->at(i);
			key = i;
		}
	}
	return students->at(key);
}
void Output(double average, int median, int mode, std::string studentMost, std::string studentLeast) {
	std::cout << "Average Number of Movies Seen by Students......: " << average << std::endl;
	std::cout << "Median Number of Movies Seen by Students.......: " << median << std::endl;
	std::cout << "Most Common Number of Movies Seen by Students..: " << mode << std::endl;
	std::cout << "Student Who Has Seen the Most Movies...........: " << studentMost << std::endl;
	std::cout << "Student Who Has Seen the Least Movies..........: " << studentLeast << std::endl;
}
