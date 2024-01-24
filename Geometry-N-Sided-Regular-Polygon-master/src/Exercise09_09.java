// Johnathan R. Burgess, 4/3/2019

import static java.lang.Math.PI;
import static java.lang.Math.tan;

public class Exercise09_09{
    public static void main(String[] args){
        RegularPolygon rp1 = new RegularPolygon();
        RegularPolygon rp2 = new RegularPolygon(6, 4);
        RegularPolygon rp3 = new RegularPolygon(10,4,5.6,7.8);

        System.out.println("Polygon 1 perimeter: "+rp1.getPerimeter());
        System.out.println("Polygon 1 area: "+rp1.getArea());
        System.out.println("Polygon 2 perimeter: "+rp2.getPerimeter());
        System.out.println("Polygon 2 area: "+rp2.getArea());
        System.out.println("Polygon 3 perimeter: "+rp3.getPerimeter());
        System.out.println("Polygon 3 area: "+rp3.getArea());
    }
}


class RegularPolygon {

    // private properties
    private int n;
    private double side;
    private double x;
    private double y;

    // default constructor
    RegularPolygon(){
        n = 3;
        side = 1;
        x = 0;
        y = 0;
    }

    // secondary constructor for semi-specified data
    RegularPolygon(int sides, double length){
        n = sides;
        side = length;
        x = 0;
        y = 0;
    }

    //third constructor for specified data
    RegularPolygon(int sides, double length, double X, double Y){
        n = sides;
        side = length;
        x = X;
        y = Y;
    }

    // setters
    public void setNumberOfSides(int sides){
        n = sides;
    }
    public void setSideLength(double length){
        side = length;
    }
    public void setXCoordinate(double X){
        x = X;
    }
    public void setYCoordinate(double Y){
        y = Y;
    }

    // getters
    public int getNumberOfSides(){
        return n;
    }
    public double getSideLength(){
        return side;
    }
    public double getXCoordinate(){
        return x;
    }
    public double getYCoordinate(){
        return y;
    }

    // returns the perimeter
    public double getPerimeter(){
        return (n*side);
    }

    // returns the area
    public double getArea(){
        double area = (n * (side*side) ) / (4 * tan(PI/n));
        return area;
    }
}