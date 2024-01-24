/*
Johnathan R. Burgess
Project 3 for JavaFX Books Content
11/7/2019
This is my own original work.
 */

import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.control.ListView;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.scene.layout.BorderPane;
import javafx.stage.Stage;
import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Scanner;

public class BurgessMain extends Application {

    Stage window;
    Scene scene;
    ListView<String> bookListView;

    public static void main(String[] args){
        launch(args);
    }

    public void start(Stage primaryStage) throws Exception{

        window = primaryStage;
        window.setTitle("JavaFX Books Project 3 - Johnathan R. Burgess");

        BorderPane pane = new BorderPane();

        ImageView imgPic = new ImageView();
        imgPic.setFitHeight(530);
        imgPic.setFitWidth(500);

        bookListView = new ListView<>();

        ArrayList<BurgessBook> books = getData();

        bookListView.getSelectionModel().selectedItemProperty().addListener(e -> {
            int index = bookListView.getSelectionModel().getSelectedIndex();
            imgPic.setImage(new Image(books.get(index).getImageName()));
        });

        pane.setLeft(bookListView);
        pane.setRight(imgPic);
        scene = new Scene(pane, 800, 530);
        window.setScene(scene);
        window.show();
    }

    private ArrayList<BurgessBook> getData(){

        ArrayList<BurgessBook> books = new ArrayList<>();

        try{
            File inputFile = new File("src/BurgessBookData");
            Scanner scan = new Scanner(inputFile);
            while(scan.hasNextLine()){
                String publisher = scan.next();
                String title = scan.next();
                String ISBN = scan.next();
                String associatedImage = scan.next();
                double cost = scan.nextDouble();
                books.add(new BurgessBook(publisher, title, ISBN, associatedImage, cost));
                bookListView.getItems().add(title);
            }

        }catch(FileNotFoundException e){
            System.out.println("File not found. Error: "+e.getMessage());
        }catch(Exception e){
            System.out.println("Error: "+e.getMessage());
        }
        return books;
    }

}
