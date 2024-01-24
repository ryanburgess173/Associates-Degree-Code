package main.Listings.Ch12;

import java.io.PrintWriter;

public class WriteData {

    private PrintWriter output;

    public WriteData() throws java.io.IOException{
        java.io.File file = new java.io.File("scores.txt");
        if(file.exists()){
            System.out.println("File already exists");
            System.exit(1);
        }
        this.output = new PrintWriter(file);
    }
    public void displayOutput(){
        this.output.print("John T Smith ");
        this.output.println(90);
        this.output.print("Eric K Jones ");
        this.output.println(85);
    }
    public void closeOutput(){
        this.output.close();
    }
}
