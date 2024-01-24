/*
Euclid's Algorithm:
Given two positive integers m and n, find their greatest common divisor,
that is, the largest positive integer that evenly divides both m and n.
 */

package main.volume1_chapter1;

public class EuclidsAlgorithm {

    private double m, n;

    public EuclidsAlgorithm(double m, double n){
        this.m = m;
        this.n = n;
    }

    public double solveAlgorithm(){
        while(true){
            double r = this.m % this.n;
            if(r == 0){
                return this.n;
            }else{
                this.m = this.n;
                this.n = r;
            }
        }
    }

    public double getM() {
        return m;
    }

    public void setM(double m) {
        this.m = m;
    }

    public double getN() {
        return n;
    }

    public void setN(double n) {
        this.n = n;
    }

}
