/*
Johnathan R. Burgess, CSC-251
 */
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Random;

public class Main {
    public static void main(String[] args) {

        Integer[] ints = {1, 2, 3, 4, 5, 6, 18, 30};
        Integer valueToSearchFor = 18;
        int indexFoundAt = binarySearch(ints, valueToSearchFor);
        outputArray(ints, valueToSearchFor, indexFoundAt);

        Character[] chars = {'a', 'd', 'm'};
        Character valueToSearchFor2 = 'd';
        int indexFoundAt2 = binarySearch(chars, valueToSearchFor2);
        outputArray(chars, valueToSearchFor2, indexFoundAt2);

        Double[] doubles = {3.14159, 7.87, 78.9, 56.78901};
        Double valueToSearchFor3 = 78.9;
        int indexFoundAt3 = binarySearch(doubles, valueToSearchFor3);
        outputArray(doubles, valueToSearchFor3, indexFoundAt3);

        ArrayList<Character> chars2 = new ArrayList<>(Arrays.asList('a','y','w','b','d','c'));
        outputArrayList(chars2.toString(), shuffle(chars2).toString(), sort(chars2).toString());

        ArrayList<Integer> ints2 = new ArrayList<>(Arrays.asList(45, 77, 3, 7, 43, 765, 25, 3));
        outputArrayList(ints2.toString(), shuffle(ints2).toString(), sort(ints2).toString());

        ArrayList<String> strings = new ArrayList<>(Arrays.asList("Patrick", "Ryan", "Vincent", "Kyle"));
        outputArrayList(strings.toString(), shuffle(strings).toString(), sort(strings).toString());
    }

    // key is the value you're searching for
    public static <E extends Comparable<E>> int binarySearch(E[] list, E key) {
        int first = 0;
        int last = list.length;
        boolean found = false;
        int position = -1;
        int middle;
        while ((!found) && (first <= last)) {
            middle = ((last - first) / 2) + first;
            if (list[middle].compareTo(key) == 0) { //(list[middle].compareTo(key) == 0)
                found = true;
                position = middle;
            }
            // tests to see if list[middle] is greater than key
            // Documentation for the compareTo() method
            //https://docs.oracle.com/javase/8/docs/api/java/lang/Comparable.html#compareTo-T-
            else if (list[middle].compareTo(key) > 0) {
                last = middle - 1;
            } else {
                first = middle + 1;
            }
        }
        return position;
    }

    // this I changed void to ArrayList<E> in order to return my list so I can output it
    // The reason I do not have output in my sort or shuffle functions is because I was
    // taught it is bad practice, and that ideally you return the result and then call a
    // seperate output function.
    public static <E> ArrayList<E> shuffle(ArrayList<E> list) {
        /* I found some information on an algorithm called the Fisher and Yates shuffle
        https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle

       According to what I found:

        -- To shuffle an array a of n elements (indices 0..n-1):
        for i from n−1 downto 1 do
            j ← random integer such that 0 ≤ j ≤ i
            exchange a[j] and a[i]

        * */
        Random random = new Random();
        int j;
        for (int i = list.size() - 1; i > 0; i--) {
            j = random.nextInt((i) + 1);
            E holder = list.get(i);
            list.set(i, list.get(j));
            list.set(j, holder);
        }
        return list;
    }

    // this I changed void to ArrayList<E> in order to return my list so I can output it
    // The reason I do not have output in my sort or shuffle functions is because I was
    // taught it is bad practice, and that ideally you return the result and then call a
    // seperate output function.
    public static <E extends Comparable<E>> ArrayList<E> sort(ArrayList<E> list) {
        //using a simple bubble sort
        E temp;
        boolean madeASwap;
        do {
            madeASwap = false;
            for (int count = 0; count < (list.size() - 1); count++) {
                // tests to see if list.get(count) is greater than list.get(count+1)
                // the compareTo method should work with letters as with doubles and integers
                if (list.get(count).compareTo(list.get(count + 1)) > 0) {
                    temp = list.get(count);
                    list.set(count, list.get(count + 1));
                    list.set(count + 1, temp);
                    madeASwap = true;
                }
            }

        } while (madeASwap);
        return list;
    }

    // This function is for doing output for our binary searches for any of our arrays of any
    // generic data type we may use.
    public static <E> void outputArray(E[] array, E searchedFor, int indexFound){
        System.out.println("====================NEW TEST==============================");
        System.out.print("Original array: [");
        for(int i=0; i < array.length; i++){
            System.out.print(array[i]);
            if(i!=array.length-1){
                System.out.print(",");
            }
        }
        System.out.print("]");
        System.out.println("\nBinary Search for "+searchedFor+" returns " +
                "position "+indexFound);
        System.out.println("==========================================================\n");
    }

    // This function is for doing output for our standard ArrayList, our shuffled one, and sorted one
    // for any generic data type we may decide to use.
    public static void outputArrayList(String list, String shuffledList, String sortedList){
        System.out.println("====================NEW TEST==============================");
        System.out.println("Original ArrayList...: " + list);
        System.out.println("Shuffled ArrayList...: " + shuffledList);
        System.out.println("Sorted ArrayList.....: " + sortedList);
        System.out.println("==========================================================\n");
    }
}
