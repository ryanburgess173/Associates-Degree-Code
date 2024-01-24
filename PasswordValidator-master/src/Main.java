import java.io.File;
import java.util.ArrayList;
import java.util.Scanner;
/*
 * Created by Johnathan R. Burgess on 4/12/2018 at 10:13AM ET
 */
public class Main {
	// pass ArrayList will hold the list of passwords
	static ArrayList<String> pass = new ArrayList<>();
	private static Scanner x;
	
	// This function opens a file
	void openFile(){
        try{
            x = new Scanner(new File("password.txt"));
        }catch(Exception e){
            System.out.println("Error: "+e);
        }
    }

	// this function reads from a file
    void readFile(){
    	int count = 0;
    	// continue while there is still a newline to start
        while(x.hasNext()){
        	String password = x.next();
        	pass.add(password);
        	count++;
        }
    }

    // this function closes a file
	void closeFile(){
        x.close();
    }
	
	// MAIN METHOD
	public static void main(String args[]) {
		
		Main m = new Main(); // creates a new instance of itself
		
		m.openFile(); // calls open file method
		
		m.readFile(); // calls read file method
		
		m.closeFile(); // calls close file method
		
		results(); // executes the results function to get our results
	}
	public static void results() {
		
		// iterates through each member of the pass ArrayList
		for(int i=0; i<pass.size(); i++) {
	
			// Prints out to the console the password that is being checked.
			System.out.printf("%s ",pass.get(i));
			
			//Variables that hold if conditions are held true or false
			boolean length = false;
			boolean numeric = false;
			boolean uppercase = false;
			boolean lowercase = false;
			boolean noSpaceOrSlash = true;
			boolean startingNoNumber = false;
			
			// iterates through each character of each of the Strings in ArrayList
			for(int a=0; a<pass.get(i).length(); a++) {
				
				// If it is the first character in the string, and if the character is not a number
				if((a==0) && (Character.isDigit(pass.get(i).charAt(a))==false)) {
					
					//then assign this variable the value of true
					startingNoNumber = true;
				}
				
				// tests to see if there are at least 8 iterations, which means at least 8 characters in the string
				if(a>=7) {
					length = true;
				}
				
				// tests to see if there is a character that is equal to a numeric value
				if(Character.isDigit(pass.get(i).charAt(a))==true) {
					numeric = true;
				}
				
				// checks to see if a character is possibly uppercase
				if(Character.isUpperCase(pass.get(i).charAt(a))==true) {
					uppercase = true;
				}
				
				//checks to see if a character is possibly lowercase
				if(Character.isLowerCase(pass.get(i).charAt(a))==true) {
					lowercase = true;
				}
				
				//checks to see if there is no space or dash
				if((pass.get(i).charAt(a)==' ') || (pass.get(i).charAt(a)=='/')) {
					noSpaceOrSlash = false;
				}
				
			}
			
			// tests to see if conditions are met
			if(length==true) {
				if(numeric==true) {
					if(uppercase==true) {
						if(lowercase==true) {
							if(noSpaceOrSlash==true) {
								if(startingNoNumber==true) {
									System.out.print("YES");
								}
								else {
									System.out.print("NO");
								}
							}
							else {
								System.out.print("NO");
							}
						}
						else {
							System.out.print("NO");
						}
					}
					else {
						System.out.print("NO");
					}
				}
				else {
					System.out.print("NO");
				}
			}
			else {
				System.out.print("NO");
			}
			// starts a newline
			System.out.println();
		}
	}
}