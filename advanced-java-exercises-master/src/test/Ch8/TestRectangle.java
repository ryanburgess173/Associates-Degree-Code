package test.Ch8;

import main.exercises.Ch8.Rectangle;

public class TestRectangle {
    public TestRectangle(){
        Rectangle rect1 = new Rectangle(4,40);
        Rectangle rect2 = new Rectangle(3.5, 35.9);
        output(rect1);
        output(rect2);
    }

    private void output(Rectangle r){
        System.out.println("Width....: "+r.getWidth());
        System.out.println("Height...: "+r.getHeight());
        System.out.println("Area.....: "+r.getArea());
        System.out.println("Perimeter: "+r.getPerimeter());
    }

}
