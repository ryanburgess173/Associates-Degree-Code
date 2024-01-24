import java.util.Scanner;

public class Exercise06_23 {
    public static void main(String[] args){
        Scanner input = new Scanner(System.in);
        System.out.print("Enter a string: ");
        String stringy = input.nextLine();
        System.out.print("Enter a character: ");
        char c = input.next().charAt(0);
        int occurrences = count(stringy, c);
        System.out.printf("The number of occurrences of %c in %s is %d", c, stringy, occurrences);
    }
    public static int count(String str, char a){
        int occurrences = 0;
        for(int i=0; i<str.length(); i++){
            if(str.charAt(i)==a){
                occurrences++;
            }
        }
        return occurrences;
    }
}
