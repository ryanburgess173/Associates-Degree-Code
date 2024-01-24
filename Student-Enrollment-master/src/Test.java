
import java.util.Scanner;
/*
    Johnathan R. Burgess, CSC-151 JAVA Programming
    Final Project
    May 3rd, 2019

    Test.java is just for testing stuff out.
 */
public class Test {
    public static void main(String[] args) throws TooManyCoursesException, DuplicateCourseException{

        // scanner object for input
        Scanner input = new Scanner(System.in);

        // local variables for storing input
        String firstName, lastName, id, street, city, state, zip;

        // gets user input
        System.out.print("Enter student first name: ");
        firstName = input.nextLine();
        System.out.print("Enter student last name: ");
        lastName = input.nextLine();
        System.out.print("Enter student ID: ");
        id = input.nextLine();
        System.out.print("Enter street: ");
        street = input.nextLine();
        System.out.print("Enter city: ");
        city = input.nextLine();
        System.out.print("Enter state: ");
        state = input.nextLine();
        System.out.print("Enter zip: ");
        zip = input.nextLine();

        // instantiated student object
        Student student1 = new Student(id, firstName, lastName, new Address(street, city, state, zip));

        DataStore ds = new DataStore();
        ds.getInstance();

        // holds list of all possible sections the student can enroll in.
        CourseSection[] sections = ds.getSections();

        // holds our user input for the menu system
        int choice=0;
        do{
            // displays choices
            System.out.println("===================================================================================");
            for(int i=0; i<sections.length; i++){

                // just some fancy printf stuff to make it look nice
                System.out.printf("%-3d %-4s %-4s %-23s %-6s %-5s %-5s %-5s %-5s\n", (i+1), sections[i].getSubject(), sections[i].getNumber(), sections[i].getName(),
                        sections[i].getId(), sections[i].getDays(), sections[i].getStartTime(), sections[i].getBuilding(), sections[i].getRoom());
            }
            System.out.println("0   To Quit.\n");
            System.out.println("===================================================================================");

            // gets the user input
            System.out.print("Enter your choice: ");
            choice = input.nextInt();

            /* Instead of using a switch statement I decided and if statement would require less code and would
            allow for any number of choices to be displayed, rather than having a case statement for each possible
            choice.*/
            if((choice > 0)&&(choice <= sections.length)){
                try{
                    // the choices are 1-15 in this particular instance, but the index will always be -1
                    student1.enroll(sections[choice-1]);
                }catch(TooManyCoursesException e){
                    throw new TooManyCoursesException();
                }catch(DuplicateCourseException e){
                    throw new DuplicateCourseException("You have already enrolled in this course: ", sections[choice-1]);
                }

                // This else if statement executes if the user selects a zero.
            }else if(choice == 0){
                System.out.printf("Name...: %s, %s\n", student1.getLastName(), student1.getFirstName());
                System.out.printf("ID.....: %s\n", student1.getId());

                // stores out student address for output
                Address ad1 = student1.getAddress();

                System.out.printf("Address: %s, %s, %s %s\n", ad1.getStreet(), ad1.getCity(), ad1.getState(), ad1.getZip());
                System.out.println("-------------------------------------Schedule-----------------------------------------");

                /* Student.getSections() was an invention of my own in order to streamline the process of finding
                a list of enrolled sections. */
                CourseSection[] enrolledSections = student1.getSections();

                // loops through each enrolledSection by the student.
                for(int i=0; i<enrolledSections.length; i++){

                    // this if statement keeps null class spots from printing to the console.
                    if(enrolledSections[i].getSubject()!=null){

                        // just some fancy printf stuff to make it look nice

                        System.out.printf("%-3d %-4s %-4s %-23s %-6s %-5s %-5s %-5s %-5s\n", (i+1), enrolledSections[i].getSubject(), enrolledSections[i].getNumber(), enrolledSections[i].getName(),
                                enrolledSections[i].getId(), enrolledSections[i].getDays(), enrolledSections[i].getStartTime(), enrolledSections[i].getBuilding(), enrolledSections[i].getRoom());

                    }

                }
                System.out.println("===================================================================================");
            }
            // invalid choice error message
            else{
                System.out.println("Invalid choice!");
            }
        }while(choice!=0);

    }
}
