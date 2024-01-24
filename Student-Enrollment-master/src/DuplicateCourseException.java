/*
    Johnathan R. Burgess, CSC-151 JAVA Programming
    Final Project
    May 3rd, 2019
 */
public class DuplicateCourseException extends Exception{

    public DuplicateCourseException(String message, CourseSection c){
        super(message+ " " + c.getSubject() + " " + c.getNumber());
    }

}
