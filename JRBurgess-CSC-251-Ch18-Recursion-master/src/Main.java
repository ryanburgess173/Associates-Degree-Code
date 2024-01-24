import javafx.application.Application;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.ListView;
import javafx.scene.control.TextField;
import javafx.scene.layout.Border;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.HBox;
import javafx.stage.Stage;
import org.w3c.dom.html.HTMLObjectElement;

public class Main extends Application{

    Stage window;
    Scene scene;
    ListView<String> listOfPossibleConversions;

    public static void main(String[] args){
        launch(args);
    }

    public void start(Stage primaryStage) throws Exception{
        window = primaryStage;
        window.setTitle("Recursion - JRBurgess");

        BorderPane pane = new BorderPane();

        listOfPossibleConversions = new ListView<>();
        listOfPossibleConversions.getItems().addAll("Decimal to Binary", "Decimal to Hexadecimal",
                "Binary to Decimal", "Hexadecimal to Decimal");

        HBox subPane = new HBox();
        TextField userEntry = new TextField();
        TextField output = new TextField();
        output.setEditable(false);
        Button btn = new Button("Convert");
        btn.setOnAction(new EventHandler<ActionEvent>() {
            @Override
            public void handle(ActionEvent actionEvent) {
                if(listOfPossibleConversions.getSelectionModel().selectedItemProperty().toString() == "Decimal to Binary"){
                    output.setText(dec2Bin(Integer.parseInt(userEntry.getText())));
                }
            }
        });
        btn.setPrefSize(140,80);
        subPane.getChildren().addAll(btn, userEntry, output);

        pane.setTop(listOfPossibleConversions);
        pane.setBottom(subPane);
        scene = new Scene(pane, 500, 500);
        window.setScene(scene);
        window.show();
    }

    public static String dec2Bin(int value){
        if(value > 0){
            // originally I had value%2 in front of my recursive call,
            // which made my binary string return in reverse
            return dec2Bin(value / 2) + value % 2;
        }else{
            return "";
        }
    }

    public static String dec2Hex(int value){
        if(value > 0){
            int remainder = value % 16;
            String trueRemainder;
            switch(remainder){
                case 15:
                    trueRemainder = "F";
                    break;
                case 14:
                    trueRemainder = "E";
                    break;
                case 13:
                    trueRemainder = "D";
                    break;
                case 12:
                    trueRemainder = "C";
                    break;
                case 11:
                    trueRemainder = "B";
                    break;
                case 10:
                    trueRemainder = "A";
                    break;
                default:
                    trueRemainder = String.valueOf(remainder);
            }
            return dec2Hex(value / 16) + trueRemainder;
        }else{
            return "";
        }
    }

    /*
    public static int bin2Dec(String binaryString){

    }*/

}
