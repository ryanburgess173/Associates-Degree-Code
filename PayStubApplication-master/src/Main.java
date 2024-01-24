import java.io.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/*
Johnathan R. Burgess, CSC-151 JAVA Programming
3/14/2019, 1:14pm this file was created, along with the project.
 */
public class Main {
    public static void main(String[] args) throws IOException {
        // this will store our PayStubs in an ArrayList
        List<PayStub> paystubs = GetData();
        WriteData(paystubs);
    }

    // this function gets our data
    private static List<PayStub> GetData(){
        // temporary holder for our paystubs within this function
        List<PayStub> stubs = new ArrayList<PayStub>();

        // file I/O code:
        try {
            File file = new File("input.txt");
            Scanner fileInput = new Scanner(file);
            while(fileInput.hasNext()){
                String name = fileInput.next();
                double hours = fileInput.nextDouble();
                double hourlyRate = fileInput.nextDouble();
                double gross;
                if (hourlyRate==-1){
                    gross = getGross(hours);
                }else{
                    gross = getGross(hours, hourlyRate);
                }
                double taxes = getTaxes(gross);
                double net = getNet(gross, taxes);
                stubs.add(new PayStub(name, hours, hourlyRate, gross, taxes, net));
            }
            fileInput.close();
        }catch(IOException e){
            System.out.println(e);
        }
        return stubs;
    }
    private static double getGross(double workHours){
        return workHours * 7.25;
    }
    private static double getGross(double workHours, double payRate){
        double gross = workHours * payRate;
        // handles the overtime condition
        if(workHours>40){
            gross *= 1.5;
        }
        return gross;
    }
    private static double getTaxes(double grossPay){
        return 0.25*grossPay;
    }
    private static double getNet(double grossPay, double taxes){
        return grossPay - taxes;
    }
    private static void WriteData(List<PayStub> paystubs) throws IOException {
        File file = new File("paystubs.txt");
        file.createNewFile();
        // this function will write our pay stubs to a file.
        BufferedWriter writer = new BufferedWriter(new FileWriter("paystubs.txt"));
        for(int i=0; i<paystubs.size(); i++){
            writer.append("***************************************************\n");
            String name = paystubs.get(i).getName();
            double gross = paystubs.get(i).getGrossPay();
            String strGross = String.format("%35.2f", gross);
            double taxes = paystubs.get(i).getTaxes();
            String strTaxes = String.format("%35.2f", taxes);
            double net = paystubs.get(i).getNetPay();
            String strNet = String.format("%35.2f", net);
            writer.append(name+"\n");
            writer.append("Gross:\t"+strGross+"\n");
            writer.append("Taxes:\t"+strTaxes+"\n");
            writer.append("Net:\t"+strNet+"\n");
            writer.append("***************************************************\n\n");
        }
        writer.close();
        System.out.println("Data wrote.");
    }
}