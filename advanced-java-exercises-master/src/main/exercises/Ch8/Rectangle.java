package main.exercises.Ch8;

public class Rectangle {

    private double width, height;

    public Rectangle(){
        this.width = 1;
        this.height = 1;
    }

    public Rectangle(double w, double h){
        this.width = w;
        this.height = h;
    }

    public double getArea(){
        return this.width * this.height;
    }

    public double getPerimeter(){
        return (this.width*2) + (this.height*2);
    }

    public double getWidth() {
        return width;
    }

    public void setWidth(double width) {
        this.width = width;
    }

    public double getHeight() {
        return height;
    }

    public void setHeight(double height) {
        this.height = height;
    }
}
