/*
    Johnathan R. Burgess, CSC-151 JAVA Programming
    Final Project
    May 3rd, 2019
 */

import java.io.File;
import java.io.FileNotFoundException;
import java.nio.file.Paths;
import java.util.Scanner;

public class DataStore {
    private static DataStore singleton = null;

    public DataStore(){

    }

    private static CourseSection[] sections = new CourseSection[15];
    private static File sectionFile = Paths.get(".", "resources", "Sections.txt").normalize().toFile();

    public static DataStore getInstance(){
        if(singleton == null){
            singleton = new DataStore();
            try{
                Scanner fs = new Scanner(sectionFile);

                for(int i=0; i<sections.length; i++){
                    sections[i] = new CourseSection(fs.next(), fs.next(), fs.next(), fs.next(), fs.next(), fs.next(), fs.next(), fs.next());
                }

            }catch (FileNotFoundException e){
                System.out.print(e.getMessage());
            }

        }
        return singleton;
    }

    public static CourseSection[] getSections() {
        return sections;
    }
}
