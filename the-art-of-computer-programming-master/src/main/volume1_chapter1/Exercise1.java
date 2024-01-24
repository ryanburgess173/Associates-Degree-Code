/*
The text showed how to interchange the values of variables m and n, using the
replacement notation, by setting t <-- m, m <-- n, n <-- t. Show how the values of
four variables (a, b, c, d) can be rearranged to (b, c, d, a) by a sequence of
replacements. In other words, the new value of a is to be the original value of b,
etc. Try to use the minimum number of replacements.
 */

package main.volume1_chapter1;

import java.util.ArrayList;

public class Exercise1 {

    private ArrayList<Integer> lst;
    private int x;

    public Exercise1(){ }

    public Exercise1(int a, int b, int c, int d){
        this.lst = new ArrayList<>();
        this.lst.add(a);
        this.lst.add(b);
        this.lst.add(c);
        this.lst.add(d);
    }

    public ArrayList<Integer> rearrange(){
        this.x = this.lst.indexOf(0);           // a
        this.lst.set(0, this.lst.indexOf(1));   // a to b
        this.lst.set(1, this.lst.indexOf(2));   // b to c
        this.lst.set(2, this.lst.indexOf(3));   // c to d
        this.lst.set(3, this.x);                // d to a
        return this.lst;
    }

    public ArrayList<Integer> getLst() {
        return this.lst;
    }

    public void setLst(ArrayList<Integer> lst) {
        this.lst = lst;
    }
    public int getX() {
        return this.x;
    }

    public void setX(int x) {
        this.x = x;
    }
}
