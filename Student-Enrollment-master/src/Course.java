/*
    Johnathan R. Burgess, CSC-151 JAVA Programming
    Final Project Phase I
    Address.java is an Address class for our program
 */
public class Course {

    private String subject;
    private String number;
    private String name;

    public Course(){

    }
    public Course(String subject, String number, String name){
        this.subject = subject;
        this.number = number;
        this.name = name;
    }

    //=============================================================
    // Getters and Setters for all of our private member variables
    // for this class:
    //=============================================================
    public String getSubject() {
        return subject;
    }

    public void setSubject(String subject) {
        this.subject = subject;
    }

    public String getNumber() {
        return number;
    }

    public void setNumber(String number) {
        this.number = number;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    //=============================================================

    //=============================================================
    // Overriding our built in toString() method from our Object.java
    // built in class.
    //=============================================================
    @Override
    public String toString(){
        return "Course{" +
                "subject='" + subject + '\'' +
                ", number='" + number + '\'' +
                ", name='" + name + '\'' +
                '}';
    }
    //=============================================================
}
