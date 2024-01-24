package main.exercises.Ch11;

import java.util.ArrayList;

public class NextToLastElement {
    public ArrayList<String> arr;
    public String item;
    public NextToLastElement(){
        this.arr = new ArrayList<String>();

        this.arr.add("100");
        this.arr.add("600");
        this.arr.add("700");
        this.arr.add("1400");

        this.item = this.arr.get(this.arr.size()-2);
    }

}
