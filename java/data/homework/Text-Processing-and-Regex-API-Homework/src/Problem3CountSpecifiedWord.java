import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 31.03.2016 г..
 */
public class Problem3CountSpecifiedWord {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        String[] input = scan.nextLine().toLowerCase().split("[ ,.')(!]");
        String word = scan.nextLine();
        int count = 0;
        for (int i = 0; i < input.length; i++) {
            if (input[i].equals(word)) {
                count++;
            }
        }

        System.out.println(count);
    }
}
