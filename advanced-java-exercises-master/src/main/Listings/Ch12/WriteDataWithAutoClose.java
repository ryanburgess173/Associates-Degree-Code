package main.Listings.Ch12;

public class WriteDataWithAutoClose {
    public WriteDataWithAutoClose() throws Exception{
        java.io.File file = new java.io.File("scores2.txt");
        if(file.exists()){
            System.out.println("File already exits!");
            System.exit(0);
        }
        try(
                java.io.PrintWriter output = new java.io.PrintWriter(file);
        ){
            this.outputResults(output);
        }
    }
    private void outputResults(java.io.PrintWriter output){
        output.print("John T Smith ");
        output.println(90);
        output.print("Eric K Jones ");
        output.println(85);
    }
}
