import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args){
        List<String> names;
        names = readFile("words.txt");
        Collections.sort(names);
        for(String name : names){
            System.out.println(name);
        }
    }

    private static <E> List<E> readFile(String fileName){
        List<E> names = new ArrayList<>();
        try{
            Scanner inputScanner = new Scanner(new File(fileName));
            while(inputScanner.hasNext()){
                names.add((E)inputScanner.next());
            }
            inputScanner.close();
        }catch(FileNotFoundException exception){
            System.out.println("File not found.");
        }
        return names;
    }
}
