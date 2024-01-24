
/*
    Johnathan R. Burgess
    Everything in this file is pretty straight forward so I'm not going to
    comment much in this file specifically.
    This is my original work.
 */

import java.util.ArrayList;

public class BurgessBook {

    private String publisher;
    private String title;
    private String ISBN;
    private String imageName;
    private double price;

    // I made it package-private as IntelliJ suggested. Seems to make sense in this scenario.
    BurgessBook(String publisher, String title, String ISBN, String imageName, double price) {
        this.publisher = publisher;
        this.title = title;
        try {
            this.setISBN(ISBN);
        }catch(BurgessInvalidISBN e){
            System.out.println(e.getMessage());
        }
        this.imageName = imageName;
        this.price = price;
    }

    public String getPublisher() {
        return publisher;
    }

    public void setPublisher(String publisher) {
        this.publisher = publisher;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getISBN() {
        return ISBN;
    }

    public void setISBN(String ISBN) throws BurgessInvalidISBN{
        ArrayList<Character> isbn = new ArrayList<>();

        for (int i = 0; i < ISBN.length(); i++) {
            if (ISBN.charAt(i) != '-') {
                isbn.add(ISBN.charAt(i));
            }
        }
        // checks to see if the length of the ISBN is correct to begin with.
        if (isbn.size() == 13) {

            // total will store the total addition of all the multiples added together.
            int total = 0;

            // this will store the result of our total Modulus 10
            int totalAfterMod10;

            // this will be the final calculation for the check digit
            int calculatedCheckDigit;

            for (int i = 0; i < isbn.size(); i++) {
                // number stores the integer equivalent of the character at each iteration through the ISBN
                int number = Character.getNumericValue(isbn.get(i));
                // this will loop through every digit except the 13th one (check digit) in the ISBN
                if (i < (isbn.size() - 1)) {
                    // if it's at an even index add the digit to total
                    if ((i % 2) == 0) {
                        total += number;

                    } else {
                        // if it's at an odd index, multiply the digit by 3 then add it to total
                        total += (3 * number);
                    }
                }
            }
            totalAfterMod10 = total % 10;
            // if our number is equal to zero that will be our calculated check digit
            if (totalAfterMod10 == 0) {
                calculatedCheckDigit = 0;
            } else {
                // otherwise we will subtract our number from 10 and the result will be our calculated check digit
                calculatedCheckDigit = 10 - totalAfterMod10;
            }
            // return true or false whether our calculated check digit is equal to the actual 13th digit of the ISBN
            if (calculatedCheckDigit == Character.getNumericValue(isbn.get(12))) {
                this.ISBN = ISBN;
            }else{
                throw (new BurgessInvalidISBN(this.publisher, this.title));
            }
        }else{
            throw (new BurgessInvalidISBN(this.publisher, this.title));
        }
    }

    public String getImageName() {
        return imageName;
    }

    public void setImageName(String imageName) {
        this.imageName = imageName;
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    @Override
    public String toString() {
        return "Publisher............:  " + publisher + '\n' +
                "Title................:  " + title + '\n' +
                "ISBN.................:  " + ISBN + '\n' +
                "ImageName............:  " + imageName + '\n' +
                "Price................:  $" + price + '\n';
    }

}