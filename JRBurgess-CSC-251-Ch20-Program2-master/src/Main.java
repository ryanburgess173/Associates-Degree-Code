/*
Johnathan R. Burgess
12/12/2019
CSC-251 Chapter 20 Program 2
 */
import javafx.application.Application;
import javafx.geometry.Insets;
import javafx.scene.Scene;
import javafx.scene.control.*;
import javafx.scene.layout.*;
import javafx.stage.Stage;
import java.util.Collections;
import java.util.LinkedList;

public class Main extends Application {

    Stage window;
    Scene scene;
    TextArea textArea = new TextArea();
    LinkedList<Integer> numbers = new LinkedList<>();

    public static void main(String[] args) {
        launch(args);
    }

    public void start(Stage primaryStage) throws Exception {
        window = primaryStage;
        window.setTitle("JRBurgess - Program 2");
        FlowPane pane = new FlowPane();

        textArea.setWrapText(true);

        VBox vBox = new VBox();
        BorderPane borderPane = new BorderPane();
        HBox hBox = new HBox();

        Label lbl1 = new Label("Enter a number:   ");
        borderPane.setLeft(lbl1);
        TextField numberInput = new TextField();
        numberInput.setOnAction(actionEvent -> {
            try {
                Integer number = Integer.parseInt(numberInput.getText());
                boolean duplicate = checkLinkedList(number);
                if(!duplicate){
                    numbers.add(number);
                }else{
                    alert(Alert.AlertType.WARNING, "Duplicate already exists!");
                }
            }catch(Exception exception){
                alert(Alert.AlertType.ERROR, "Please enter an integer!");
            }
            numberInput.setText("");
            setTextArea();
        });
        borderPane.setCenter(numberInput);
        borderPane.setPadding(new Insets(0,0,10,0));

        Button btnSort = new Button("Sort");
        btnSort.setOnAction(actionEvent -> {
            Collections.sort(numbers);
            setTextArea();
        });
        Button btnShuffle = new Button("Shuffle");
        btnShuffle.setOnAction(actionEvent -> {
            Collections.shuffle(numbers);
            setTextArea();
        });
        Button btnReverse = new Button("Reverse");
        btnReverse.setOnAction(actionEvent -> {
            Collections.reverse(numbers);
            setTextArea();
        });
        hBox.getChildren().addAll(btnSort, btnShuffle, btnReverse);
        hBox.setPadding(new Insets(10,0,0,0));

        vBox.getChildren().addAll(borderPane, textArea, hBox);
        vBox.setPadding(new Insets(20,20,20,20));

        pane.getChildren().add(vBox);

        scene = new Scene(pane);
        window.setScene(scene);
        window.show();
    }
    private void setTextArea(){
        String output = "";
        for(int i=0; i<numbers.size(); i++){
            if(i!=0){
                output+=" ";
            }
            output+=numbers.get(i);
        }
        this.textArea.setText(output);
    }
    private void alert(Alert.AlertType alertType, String alertText) {
        Alert errorAlert = new Alert(alertType);
        errorAlert.setContentText(alertText);
        errorAlert.showAndWait();
    }
    private boolean checkLinkedList(Integer number){
        for(Integer num : numbers){
            if(num.equals(number)){
                return true;
            }
        }
        return false;
    }
}