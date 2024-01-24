package test;

import main.volume1_chapter1.EuclidsAlgorithm;

public class TestEuclidsAlgorithm {
    public TestEuclidsAlgorithm(){

    }
    public void run(){
        for (int i = 0; i < 50; i++){
            for(int j=50; j>0; j--){
                EuclidsAlgorithm ea = new EuclidsAlgorithm(i,j);
                double r = ea.solveAlgorithm();
                System.out.println(i+" and "+j+" results in: "+r);
            }
        }
    }
}
