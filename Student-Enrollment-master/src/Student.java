/*
    Johnathan R. Burgess, CSC-151 JAVA Programming
    Final Project
    May 3rd, 2019
 */
import java.util.Arrays;
import java.util.Date;
public class Student extends Person {
    String id;
    CourseSection [] sections = new CourseSection[5];

    private int numberEnrolled = 0;

    //=============================================================
    // Class constructors
    //=============================================================
    public Student(){
        this("0000");
    }
    public Student(String id){
        this.id = id;
        for(int i=0; i<sections.length; i++){
            sections[i] = new CourseSection();
        }
    }
    public Student (String id, String firstName, String lastName, Address address){
        super(firstName, lastName, address);
        this.id = id;
        for (int i=0; i<sections.length; i++){
            sections[i] = new CourseSection();
        }
    }
    //=============================================================


    //=============================================================
    // Getters and Setters for all of our private member variables
    // for this class:
    //=============================================================
    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }
    //=============================================================

    //un-checked exception
    public void enroll(CourseSection course) throws TooManyCoursesException, DuplicateCourseException{
        try {
            // loop to check and see if course is already in sections array
            for(int i=0; i<numberEnrolled; i++){
                if(sections[i].getSubject().equals(course.getSubject()) &&
                        sections[i].getNumber().equals(course.getNumber())){
                    throw new DuplicateCourseException("Duplicate Course Enrollment: ", course);
                }
            }

            sections[numberEnrolled] = course;
            System.out.println("Enrolled successfully in this course!");
            numberEnrolled++;
        }catch(ArrayIndexOutOfBoundsException e){
            throw new TooManyCoursesException();
        }
    }

    public CourseSection[] getSections() {
        return sections;
    }

    @Override
    public String toString(){
        String courseList="";
        for (CourseSection c: sections){
            courseList += "\n" + c.toString();
        }
        return "Student{" +
                super.toString() +
                "numberEnrolled=" + numberEnrolled +
                "id='" + id + '\'' +
                ", courses=" + courseList +
                '}';
    }
}
