/*
Johnathan R. Burgess, CSC-151, JAVA Programming, Project #1 for Chapter 6 REVEL
 */
import java.util.Scanner;

public class App {
    // main method
    public static void main(String[] args){
        Scanner input1 = new Scanner(System.in);
        System.out.print("The amount invested: $");
        double investment = input1.nextDouble();
        System.out.print("Annual interest rate: ");
        double interest =(input1.nextDouble()/100);
        int years = 30;
        System.out.println("Your interest will automatically be set to monthly.");
        interest = interest / 12;
        futureInvestmentValue(investment, interest, years);
    }
    // required method
    public static double futureInvestmentValue( double investmentAmount, double monthlyInterestRate, int years){
        double total = investmentAmount;
        for(int i=0; i<years; i++){
            for(int m=0; m<12; m++){
                total*=(monthlyInterestRate+1);
            }
            System.out.printf("%d $%.2f\n", i+1, total);
        }
        return 0.0;
    }
}
