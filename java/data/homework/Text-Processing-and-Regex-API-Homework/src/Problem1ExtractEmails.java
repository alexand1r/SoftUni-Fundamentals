import java.util.Locale;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Alec on 31.03.2016 г..
 */
public class Problem1ExtractEmails {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        String str = scan.nextLine();
        Pattern pattern = Pattern.compile("([a-zA-Z\\.-_]+@([\\.]*[a-zA-z])+)+");
        Matcher matcher = pattern.matcher(str);
        while (matcher.find()) {
            System.out.println(matcher.group());
        }
    }
}
