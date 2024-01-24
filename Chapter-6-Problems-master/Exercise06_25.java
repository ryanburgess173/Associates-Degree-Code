import java.util.Scanner;

public class Exercise06_25 {
    public static void main(String[] args){
        Scanner input = new Scanner(System.in);
        System.out.print("Enter time in milliseconds: ");
        int ms = input.nextInt();
        String time = convertMillis(ms);
        System.out.println(time);
    }
    public static String convertMillis(long millis){
        String time;
        long leftover, hours, minutes, seconds;
        final long millisecondsPerHour = 3600000, millisecondsPerMinute = 60000, millisecondsPerSecond = 1000;
        hours = millis/millisecondsPerHour;
        leftover = millis%millisecondsPerHour;
        minutes = leftover/millisecondsPerMinute;
        leftover = millis%millisecondsPerMinute;
        seconds = leftover/millisecondsPerSecond;
        time = Long.toString(hours) + ":" + Long.toString(minutes) + ":" + Long.toString(seconds);
        return time;
    }
}
