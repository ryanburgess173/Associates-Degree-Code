/*
    Johnathan R. Burgess, CSC-151 JAVA Programming
    Final Project
    May 3rd, 2019
 */
public class TooManyCoursesException extends Exception {
    public TooManyCoursesException(){
        this("You're trying to enroll in too many sections");

    }
    public TooManyCoursesException(String message){
        super(message);
    }
}
