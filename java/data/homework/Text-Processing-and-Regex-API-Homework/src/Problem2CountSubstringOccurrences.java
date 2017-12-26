import java.util.Locale;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Alec on 31.03.2016 г..
 */
public class Problem2CountSubstringOccurrences {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        String input = scan.nextLine().toLowerCase();
        String word = scan.nextLine();
        int count = 0;
        for (int i = 0; i < input.length() - word.length() + 1; i++) {
            if (word.equals(input.substring(i, i + word.length()))) {
                count++;
            }
        }

        System.out.println(count);
    }
}
