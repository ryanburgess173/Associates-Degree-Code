#include <iostream>
#include <fstream>
#include <string>
#include <iomanip>
// PREPROCESSOR DIRECTIVE
using namespace std;

// constant which tells us the program many students to process
const int NUM_STUDENTS = 4;
const int NUM_GRADES = 4;

// a new type called a gradeBook which allows for up to NUM_GRADES columns
typedef int gradeBook[NUM_STUDENTS][NUM_GRADES];
// classroom which is a set of NUM_STUDENTS students
typedef string classRoster[NUM_STUDENTS];
// final class grades
typedef string letterGrades[NUM_STUDENTS][2];

// function definitions
void Average(gradeBook, int);
void FetchNames(classRoster);
void FetchGrades(gradeBook);
void PopulateAvg(gradeBook);
void GradeTotal(gradeBook, classRoster, letterGrades);
void writeData(letterGrades);

int main() {
	/* our main data structure is a multidimensional array
	that is going to by NUM_STUDENTSXNUM_GRADES. I'm trying to make the rows
	scalable but we will see. */
	gradeBook studentGrades;

	// student names array
	classRoster students;

	// class grades
	letterGrades finalClassGrades;

	FetchNames(students);
	FetchGrades(studentGrades);
	PopulateAvg(studentGrades);
	GradeTotal(studentGrades, students, finalClassGrades);
	writeData(finalClassGrades);

	/*for (int i = 0; i < NUM_STUDENTS; i++) {
		cout << finalClassGrades[i][0] << '\t' << finalClassGrades[i][1] << endl;
	}*/

	system("pause");
	return 0;
}
void Average(gradeBook studentGrades, int studentNumber) {
	double avg = 0.0, total = 0.0;
	for (int i = 0; i < 3; i++) {
		total += studentGrades[studentNumber][i];
	}
	avg = total / 3;
	studentGrades[studentNumber][3] = avg;
}
void FetchNames(classRoster students) {
	ifstream namesFile;
	//open the .txt files
	namesFile.open("StudentNames.txt");
	// if there isn't a namesFile
	if (!namesFile) {
		// do this
		cout << "Error opening data file\n";
	}
	// otherwise,
	else {
		// while you don't encounter an end of file error from namesFile
		int count = 0;
		string a;
		while (!namesFile.eof()) {
			namesFile >> students[count];
			count++;
		}
		namesFile.close();
	}
}
void FetchGrades(gradeBook studentGrades) {
	// ifstreams that will allow us to read from our two .txt files.
	ifstream gradesFile;
	//open the .txt files
	gradesFile.open("Grades.txt");
	int currentStudent = 0;
	int a, b, c, d;
	// fetching data from the Grades.txt file and importing it into the array
	if (!gradesFile) {
		cout << "Error opening data file\n";
	}
	else {
		while (!gradesFile.eof()) {
			//         test1 test2 test3
			gradesFile >> a >> b >> c;
			d = NULL; // Because average is unknown at this point.
			studentGrades[currentStudent][0] = a;
			studentGrades[currentStudent][1] = b;
			studentGrades[currentStudent][2] = c;
			studentGrades[currentStudent][3] = d;
			currentStudent++;
		}
	}
}
void PopulateAvg(gradeBook studentGrades) {
	for (int studentNumber = 0; studentNumber < NUM_STUDENTS; studentNumber++)
		Average(studentGrades, studentNumber);
}
void GradeTotal(gradeBook studentGrades, classRoster students, letterGrades finalClassGrades) {
	/* I realize here I could just used A, B, C, and D variables,
	however it's easier to see exactly what these represent by
	packaging them in an enum named LetterGrades */
	enum LetterGrades { 
		A = 90, 
		B = 80, 
		C = 70,
		D = 60 
	};
	for (int student = 0; student < NUM_STUDENTS; student++) {
		finalClassGrades[student][0] = students[student];
		if (studentGrades[student][3] >= A) {
			finalClassGrades[student][1] = "A";
		}
		else if (studentGrades[student][3] >= B) {
			finalClassGrades[student][1] = "B";
		}
		else if (studentGrades[student][3] >= C) {
			finalClassGrades[student][1] = "C";
		}
		else if (studentGrades[student][3] >= D) {
			finalClassGrades[student][1] = "D";
		}
		else {
			finalClassGrades[student][1] = "F";
		}
	}
}
void writeData(letterGrades finalClassGrades) {
	ofstream outputFile;
	outputFile.open("FinalGrades.txt");
	for (int i = 0; i < NUM_STUDENTS; i++) {
		outputFile << left << setw(10);
		outputFile << finalClassGrades[i][0] << '\t' << finalClassGrades[i][1];
		if (i < NUM_STUDENTS-1) {
			outputFile << endl;
		}
		cout << left << setw(10);
		cout << finalClassGrades[i][0] << '\t' << finalClassGrades[i][1] << endl;
	}
}