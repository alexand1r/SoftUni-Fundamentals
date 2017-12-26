import java.util.Locale;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Alec on 31.03.2016 г..
 */
public class Problem5ExtractWords {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        Pattern pattern = Pattern.compile("[a-zA-Z]+");
        String input = scan.nextLine();
        Matcher matcher = pattern.matcher(input);
        while (matcher.find()) {
            System.out.print(matcher.group() + " ");
        }
    }
}
