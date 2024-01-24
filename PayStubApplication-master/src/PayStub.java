/*
Johnathan R. Burgess, CSC-151 JAVA Programming
Class created at 12:17pm, 3/16/2019
 */

public class PayStub {
    // Variables set to private. We will create getters and setters to access
    // this data stored in these variables.
    private String name;
    private double hours, payRate, grossPay, taxes, netPay;

    // class constructor
    PayStub(String name, double hours, double payRate, double grossPay, double taxes, double net){
        this.name = name;
        this.hours = hours;
        this.payRate = payRate;
        this.grossPay = grossPay;
        this.taxes = taxes;
        this.netPay = net;
    }

    // name getter and setter
    public String getName(){
        return this.name;
    }
    public void setName(String name){
        this.name = name;
    }

    // hours getter and setter
    public double getHours(){
        return this.hours;
    }
    public void setHours(double hours){
        this.hours = hours;
    }

    // payRate getter and setter
    public double getPayRate(){
        return this.payRate;
    }
    public void setPayRate(double payRate){
        this.payRate = payRate;
    }

    // grossPay getter and setter
    public double getGrossPay(){
        return this.grossPay;
    }
    public void setGrossPay(double grossPay){
        this.grossPay = grossPay;
    }

    // taxes getter and setter
    public double getTaxes(){
        return this.taxes;
    }
    public void setTaxes(double taxes){
        this.taxes = taxes;
    }

    // netPay getter and setter
    public double getNetPay(){
        return this.netPay;
    }
    public void setNetPay(double netPay){
        this.netPay = netPay;
    }
}