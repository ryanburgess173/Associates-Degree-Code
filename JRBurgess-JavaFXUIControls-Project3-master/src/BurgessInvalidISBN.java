public class BurgessInvalidISBN extends Exception{

    private String message;

    // I made it package-private as IntelliJ suggested. Seems to make sense in this scenario.
    BurgessInvalidISBN(String publisher, String bookName){
        this.message = "\n" + bookName + " from " + publisher + " has a problem:\n" + "ISBN is invalid. Book cannot be added.\n";
    }

    public void setMessage(String message) {
        this.message = message;
    }

    @Override
    public String getMessage(){
        return message;
    }
}