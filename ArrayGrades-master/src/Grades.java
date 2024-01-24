/**
 * Created by rwhalsey on 10/3/2016.
 * Edited by Johnathan R. Burgess on 3/27/2019.
 */
import java.io.File;
import java.io.IOException;
import java.nio.file.Paths;
import java.util.Scanner;

public class Grades {
    public static void main(String [] args) throws IOException {

        File namesFile = Paths.get(".", "resources", "Names.txt").normalize().toFile();
        File gradesFile = Paths.get(".", "resources", "Grades.txt").normalize().toFile();
       // File file = new File(fileName);             // create a File object

        if ( namesFile.exists() )                          // check that the file exists
        {                                             // before trying to create a
            // Scanner to read the file
            // Create a Scanner from the file.
            // This statement can cause a FileNotFoundException.
            Scanner namesInputFile = new Scanner( namesFile );
            Scanner gradesInputFile = new Scanner(gradesFile);

            // this is for determining the number of lines in a file
            Scanner counterScanner = new Scanner(namesFile);

            int lineCount = 0;
            while(counterScanner.hasNext()){
                counterScanner.nextLine();
                lineCount++;
            }

            // Use the results of calling the hasNext method to
            // determine if you are at the end of the file before
            // reading the next line of the file.

            // these are dynamically allocated arrays.
            String[] names = new String[lineCount];
            int[] grades = new int[lineCount];
            char[] letterGrades = new char[lineCount];

            // For each line in the file, read in the line and display it with the line number
            int lineNum = 0;
            while ( namesInputFile.hasNext() )
            {
                names[lineNum] = namesInputFile.nextLine();   // read the next line
                grades[lineNum] = gradesInputFile.nextInt();
                letterGrades[lineNum] = findLetterGrade(grades[lineNum]);

                // Output the line read to the screen for the user
                //System.out.println( lineNum + ": " + name );
                lineNum++;
            }

            // When we're done reading the file,
            // close the Scanner object attached to the file
            namesInputFile.close();
            gradesInputFile.close();

            Scanner input = new Scanner(System.in);

            System.out.println("The number of A's is..: " + findNumberOfAs(grades));
            System.out.println("The number of B's is..: " + findNumberOfBs(grades));
            System.out.println("The highest grade is..: " + findHighestGrade(grades));
            System.out.println("The lowest grade is...: " + findLowestGrade(grades));
            System.out.println("The average grade is..: " + average(grades));
            System.out.print("Enter a student name: ");
            String nameToSearchFor = input.nextLine();
            int grade = SearchForGrade(nameToSearchFor, names, grades);
            System.out.println("The student's grade is: " + grade);

        }
    }

    private static int SearchForGrade(String nameToSearchFor, String[] names, int[] grades) {
        int gradeToReturn = 0;
        for(int i=0; i<names.length; i++){
            if(names[i].equalsIgnoreCase(nameToSearchFor)){
                gradeToReturn = grades[i];
            }
        }
        if(gradeToReturn == 0){
            System.out.println("Name not found! This student does not exist.");
        }
        return gradeToReturn;
    }

    public static double average(int[] grades){
        int total = 0;
        int count = 0;
        for(int i=0; i<grades.length; i++){
            total+=grades[i];
            count++;
        }
        return (total/count);
    }
    public static int findHighestGrade(int[] grades) {
        int highest = 0;
        for(int i=0; i<grades.length; i++){
            if(grades[i] > highest){
                highest = grades[i];
            }
        }
        return highest;
    }
    public static int findLowestGrade(int[] grades) {
        int lowest = 100;
        for(int i=0; i<grades.length; i++){
            if(grades[i] < lowest){
                lowest = grades[i];
            }
        }
        return lowest;
    }

    public static int findNumberOfAs(int[] g) {
        int total = 0;
        for(int i=0; i<g.length; i++){
            if(findLetterGrade(g[i])=='A'){
                total++;
            }
        }
        return total;
    }
    public static int findNumberOfBs(int[] g) {
        int total = 0;
        for(int i=0; i<g.length; i++){
            if(findLetterGrade(g[i])=='B'){
                total++;
            }
        }
        return total;
    }

    public static char findLetterGrade(int score){
        if(score >= 90){
            return 'A';
        }else if(score >= 80) {
            return 'B';
        }else if(score >= 70){
            return 'C';
        }else if(score >= 60){
            return 'D';
        }else{
            return 'F';
        }
    }
}