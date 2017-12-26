import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Alec on 21.04.2016 г..
 */
public class RageQuit {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);

        Pattern pairMatcher = Pattern.compile("(\\D+)(\\d+)");

        String input = scan.nextLine();

        Matcher pair = pairMatcher.matcher(input);
        StringBuilder result = new StringBuilder();

        TreeSet<Character> symbols = new TreeSet<>();
        while (pair.find()) {
            String str = pair.group(1).toUpperCase();
            int count = Integer.parseInt(pair.group(2));

            for (int i = 0; i < count; i++)
            {
                result.append(str);
            }

            for (int j = 0; j < str.length(); j++) {
                symbols.add(str.charAt(j));

            }
        }

        System.out.printf("Unique symbols used: %d%n", symbols.size());
        System.out.println(result);
    }
}
