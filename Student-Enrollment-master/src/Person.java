/*
    Johnathan R. Burgess, CSC-151 JAVA Programming
    Final Project
    May 3rd, 2019
 */
import java.util.Date;
public class Person {
    //=============================================================
    // Attributes for this class
    //=============================================================
    private String firstName;
    private String lastName;
    private Address address;
    //=============================================================

    //=============================================================
    // Class constructors
    //=============================================================
    public Person(){

    }
    public Person(String fN, String lN){
        this(fN, lN, new Address());
    }
    public Person(String fN, String lN, Address a){
        this.firstName = fN;
        this.lastName = lN;
        this.address = a;
    }
    //=============================================================

    //=============================================================
    // Getters and Setters for all of our private member variables
    // for this class:
    //=============================================================
    public String getFirstName() {
        return firstName;
    }
    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }
    public String getLastName() {
        return lastName;
    }
    public void setLastName(String lastName) {
        this.lastName = lastName;
    }
    public Address getAddress() {
        return address;
    }
    public void setAddress(Address address) {
        this.address = address;
    }
    //=============================================================

    //=============================================================
    // Overriding our built in toString() method from our Object.java
    // built in class.
    //=============================================================
    @Override
    public String toString(){
        return "Person{" +
                "firstName='" + firstName + '\'' +
                ", lastName='" + lastName + '\'' +
                ", address='" + address + '\'' +
                '}';
    }
    //=============================================================
}
