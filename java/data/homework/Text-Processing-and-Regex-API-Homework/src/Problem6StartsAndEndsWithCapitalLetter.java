import java.util.Locale;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Alec on 31.03.2016 г..
 */
public class Problem6StartsAndEndsWithCapitalLetter {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        String[] input = scan.nextLine().split(" ");
        Pattern pattern = Pattern.compile("(^[A-Z][a-zA-Z]*[A-Z]$+)+");
        Matcher matcher;
        for (String s : input) {
            matcher = pattern.matcher(s);
            if (matcher.find()){
                System.out.print(matcher.group() + " ");
            }
        }
    }
}
