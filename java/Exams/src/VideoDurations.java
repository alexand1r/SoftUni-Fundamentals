import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 29.03.2016 г..
 */
public class VideoDurations {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);

        int total = 0;
        String cmd = scan.nextLine();

        while (!cmd.equals("End")) {

            String[] input = cmd.split(":");
            int hoursInMinutes = Integer.parseInt(input[0]) * 60;
            int minutes = Integer.parseInt(input[1]);

            total += hoursInMinutes + minutes;

            cmd = scan.nextLine();
        }

        int totalHours = total / 60;
        total = total % 60;
        System.out.printf("%d:%02d\n", totalHours, total);
    }
}
