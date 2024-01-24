/*
Johnathan R. Burgess
CSC-151, Java Programming
2/13/2019, Project #1
 */

import java.util.Scanner;

public class Application {

    public static void main(String[] args){
        int quantity = GetNumberOfApples();
        String day = GetDay();
        int numberOfStudents= GetNumberOfStudents();
        String teacherLastName = GetTeacherLastName();
        String teacherSalutation = GetSalutation();
        int applesPerStudent = GetApplesPerStudent(quantity, numberOfStudents);
        int applesForTeacher = GetApplesForTeacher(applesPerStudent, numberOfStudents, quantity);
        double totalPriceOfApples = GetPriceForApples(quantity);

        DisplayOutput1(applesPerStudent, applesForTeacher, teacherLastName, teacherSalutation);

        double bill = Menu(day, teacherLastName, teacherSalutation) + totalPriceOfApples;
        double finalBill = GetAfterTaxBill(bill);
        System.out.printf("\nYour total today (collection plus each item):  $%f", finalBill);
    }

    private static double GetAfterTaxBill(double bill){
        return (bill * 1.07);
    }

    private static double Menu(String day, String teacherName, String teacherSal){
        Scanner input = new Scanner(System.in);
        String choice = "";
        double bill = 0.0;

        System.out.printf("\nWhat would you like to eat %s %s?\n", teacherSal, teacherName);

        while(!choice.equalsIgnoreCase("none")){
            System.out.println("\nApple Pie              $10.00");
            System.out.println("Apple Cobbler          $15.00");
            System.out.println("Gallon of Apple Cider   $8.00");
            System.out.println("None\n");
            System.out.print("Enter a selection: ");
            choice = input.nextLine();
            if(choice.equalsIgnoreCase("Apple Pie")){
                if((day.equalsIgnoreCase("Thursday")) || (day.equalsIgnoreCase("Friday"))){
                    bill+=8.00;
                    System.out.printf("Great Choice, %s %s - Apple Pie is on sale today, %s, for $8.00!",
                            teacherSal, teacherName, day);
                }
                else if((day.equalsIgnoreCase("Saturday")) || (day.equalsIgnoreCase("Sunday"))){
                    bill+=7.00;
                    System.out.printf("Great Choice, %s %s - Apple Pie is on sale today, %s, for $7.00!",
                            teacherSal, teacherName, day);
                }else {
                    bill += 10.00;
                    System.out.printf("Great Choice, %s %s!", teacherSal, teacherName);
                }
            }else if(choice.equalsIgnoreCase("Apple Cobbler")){
                if((day.equalsIgnoreCase("Thursday")) || (day.equalsIgnoreCase("Friday"))){
                    bill+=13.00;
                    System.out.printf("Great Choice, %s %s - Apple Cobbler is on sale today, %s, for $13.00!",
                            teacherSal, teacherName, day);
                }
                else if((day.equalsIgnoreCase("Saturday")) || (day.equalsIgnoreCase("Sunday"))){
                    bill+=12.00;
                    System.out.printf("Great Choice, %s %s - Apple Cobbler is on sale today, %s, for $12.00!",
                            teacherSal, teacherName, day);
                }else {
                    bill += 15.00;
                    System.out.printf("Great Choice, %s %s!", teacherSal, teacherName);
                }
            }else if(choice.equalsIgnoreCase("gallon of apple cider")){
                if((day.equalsIgnoreCase("Thursday")) || (day.equalsIgnoreCase("Friday"))){
                    bill+=6.00;
                    System.out.printf("Great Choice, %s %s - a Gallon of Apple Cider is on sale today, %s, for $6.00!",
                            teacherSal, teacherName, day);
                }
                else if((day.equalsIgnoreCase("Saturday")) || (day.equalsIgnoreCase("Sunday"))){
                    bill+=5.00;
                    System.out.printf("Great Choice, %s %s - a Gallon of Apple Cider is on sale today, %s, for $5.00!",
                            teacherSal, teacherName, day);
                }else {
                    bill += 8.00;
                    System.out.printf("Great Choice, %s %s!", teacherSal, teacherName);
                }
            }else if(choice.equalsIgnoreCase("none")){
                System.out.printf("Thank you so much %s %s", teacherSal, teacherName);
            }
            else{
                System.out.println("That's not on the menu. Sorry!");
            }
        }
        return bill;
    }

    private static void DisplayOutput1(int applesPerStudent, int applesForTeacher, String teacherLast, String teacherSal){
        System.out.printf("\n%s %s, you have %d apples per student with %d left over for you.", teacherSal,
                teacherLast, applesPerStudent, applesForTeacher);
    }

    private static double GetPriceForApples(int quantity){
        double totalPriceForApples = 0;
        if((quantity >= 10) && (quantity <= 50)){
            totalPriceForApples = 10.00;
        }else if((quantity > 50) && (quantity <= 100)){
            totalPriceForApples = 15.00;
        }else if((quantity > 100) && (quantity <= 150)){
            totalPriceForApples = 20.00;
        }else if((quantity > 150) && (quantity <= 200)){
            totalPriceForApples = 30.00;
        }
        return totalPriceForApples;
    }

    private static int GetApplesForTeacher(int applesPerStudent, int numberOfStudents, int quantity){
        return (quantity - (applesPerStudent*numberOfStudents));
    }

    private static int GetApplesPerStudent(int quantity, int numberOfStudents){
        return (quantity / numberOfStudents);
    }

    private static String GetSalutation(){
        Scanner input = new Scanner(System.in);
        System.out.print("Teacher Salutation (Ms, Mrs., Mr, etc) : ");
        return input.nextLine();
    }

    private static String GetTeacherLastName(){
        Scanner input = new Scanner(System.in);
        System.out.print("Teacher Last Name: ");
        return input.nextLine();
    }

    private static int GetNumberOfApples(){
        Scanner input = new Scanner(System.in);
        int quantity = 0;
        while(quantity==0) {
            System.out.print("How many apples were collected? ");
            try{
                quantity = input.nextInt();
            }catch(Exception e){
                System.out.println("Try again. Make sure you enter a whole number!");
            }
        }
        return quantity;
    }

    private static int GetNumberOfStudents(){
        Scanner input = new Scanner(System.in);
        int numberOfStudents=0;
        while(numberOfStudents==0){
            System.out.print("\nTotal Number of Students: ");
            try{
                numberOfStudents = input.nextInt();
            }catch(Exception e){
                System.out.println("Yikes. That's not a whole number! Try again.");
            }
        }
        return numberOfStudents;
    }

    // Get the day of the week
    private static String GetDay(){
        Scanner input = new Scanner(System.in);
        String day = "";
        boolean keepTrying = true;
        do{
            try{
                System.out.println("\n1.  Monday");
                System.out.println("2.  Tuesday");
                System.out.println("3.  Wednesday");
                System.out.println("4.  Thursday");
                System.out.println("5.  Friday");
                System.out.println("6.  Saturday");
                System.out.println("7.  Sunday");
                System.out.print("What day of the week is it?");
                int dayOfWeek = input.nextInt();
                // I could have just gotten rid of the switch statement at this point however I figured
                // I need to demonstrate that I actually understand the concept of using one.
                // They're useful however because I'm using the array of days of the week
                // it causes a lot of repeated code.
                // Ideally I'd just do this:
                //
                /*
                String day;
                boolean keepTrying = true;
                String[] choices = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
                do{
                    try{
                        System.out.println("\n1.  Monday");
                        System.out.println("2.  Tuesday");
                        System.out.println("3.  Wednesday");
                        System.out.println("4.  Thursday");
                        System.out.println("5.  Friday");
                        System.out.println("6.  Saturday");
                        System.out.println("7.  Sunday");
                        System.out.println("What day of the week is it?");
                        int dayOfWeek = input.nextInt();
                        if((dayOfWeek >= 1) && (dayOfWeek <= 7)){
                            day = choices[dayOfWeek-1];
                            keepTrying=false;
                        }else{
                            System.out.println("Invalid input. Try again!");
                        }
                    }catch(Exception e){
                        System.out.println("Invalid data. Enter a whole number!");
                        keepTrying = true;
                    }
                }while(keepTrying);

                 */
                switch(dayOfWeek){
                    case 1:
                        day = "Monday";
                        keepTrying = false;
                        break;
                    case 2:
                        day = "Tuesday";
                        keepTrying = false;
                        break;
                    case 3:
                        day = "Wednesday";
                        keepTrying = false;
                        break;
                    case 4:
                        day = "Thursday";
                        keepTrying = false;
                        break;
                    case 5:
                        day = "Friday";
                        keepTrying = false;
                        break;
                    case 6:
                        day = "Saturday";
                        keepTrying = false;
                        break;
                    case 7:
                        day = "Sunday";
                        keepTrying = false;
                        break;
                    default:
                        System.out.println("Invalid input. Try again!");
                        keepTrying = true;
                }
            }catch(Exception e){
                System.out.println("Invalid data. Enter a whole number next time!");
                // I would just make a recursive call right here so the user could re-input
                // without it going off into an endless runaway loop but for the sake of
                // getting this assignment submitted I decided to go simple.
                break;
            }

        }while(keepTrying);
        return day;
    }
}