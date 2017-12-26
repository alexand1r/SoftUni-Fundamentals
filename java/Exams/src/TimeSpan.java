import java.sql.Time;
import java.text.ParseException;
import java.util.Date;
import java.util.Locale;
import java.util.Scanner;
import java.util.concurrent.TimeUnit;

/**
 * Created by Alec on 02.04.2016 г..
 */
public class TimeSpan {
    static Scanner scan;
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        scan = new Scanner(System.in);
        long beginSeconds = makeTimeToSeconds();
        long endSeconds = makeTimeToSeconds();
        long timeLeft = beginSeconds - endSeconds;
        int seconds = (int)(timeLeft % 60);
        int minutues = (int)(timeLeft % 3600 / 60);
        int hours = (int)(timeLeft / 3600);
        System.out.printf("%d:%02d:%02d",
                hours,
                minutues,
                seconds);
    }

    public static long makeTimeToSeconds() {
        String[] splitedString = scan.nextLine().split(":");
        return Long.parseLong(splitedString[2]) +
                (Long.parseLong(splitedString[1]) * 60) +
                (Long.parseLong(splitedString[0]) * 3600);
    }
}
