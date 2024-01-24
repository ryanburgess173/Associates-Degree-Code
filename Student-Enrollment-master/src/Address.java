/*
    Johnathan R. Burgess, CSC-151 JAVA Programming
    Final Project
    May 3rd, 2019
 */
public class Address{

    //=============================================================
    // Private Member Variables for our class
    //=============================================================
    private String street;
    private String city;
    private String state;
    private String zip;
    //=============================================================


    //=============================================================
    // Class Constructors:
    //=============================================================
    public Address(){
        this (" ", " ", "", "");
    }
    public Address(String state, String zip){
        this.state = state;
        this.zip = zip;
    }
    public Address(String city, String state, String zip){
        this(" ", city, state, zip);
    }
    public Address(String street, String city, String state, String zip){
        this.street = street;
        this.city = city;
        this.state = state;
        this.zip = zip;
    }
    //=============================================================


    //=============================================================
    // Getters and Setters for all of our private member variables
    // for this class:
    //=============================================================
    public String getStreet(){
        return street;
    }
    public void SetStreet(String str){
        street = str;
    }
    public String getCity() {
        return city;
    }
    public void setCity(String c) {
        this.city = c;
    }
    public String getState() {
        return state;
    }
    public void setState(String st) {
        this.state = st;
    }
    public String getZip() {
        return zip;
    }
    public void setZip(String z) {
        this.zip = z;
    }
    //=============================================================

    //=============================================================
    // Overriding our built in toString() method from our Object.java
    // built in class.
    //=============================================================
    @Override
    public String toString(){
        return "Address{" +
                "street='" + street + '\'' +
                ", city='" + city + '\'' +
                ", state='" + state + '\'' +
                ", zip='" + zip + '\'' +
                '}';
    }
    //=============================================================
}
