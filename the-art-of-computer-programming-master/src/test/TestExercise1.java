package test;

import main.volume1_chapter1.Exercise1;

public class TestExercise1 {
    public TestExercise1(){}
    public void run(){
        Exercise1 e1 = new Exercise1(5, 4, 6, 8);
        System.out.println("Original: ("+e1.getLst()+")");
        e1.rearrange();
        System.out.println("New:      ("+e1.getLst()+")");
    }
}
