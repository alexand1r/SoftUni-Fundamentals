import java.math.BigInteger;
import java.util.HashMap;
import java.util.Locale;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Alec on 13.04.2016 г..
 */
public class SoftUniNumerals {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
//        HashMap<String, String> dict = new HashMap<>();
//        dict.put("aa", "0");
//        dict.put("aba", "1");
//        dict.put("bcc", "2");
//        dict.put("cc", "3");
//        dict.put("cdc", "4");
//        Pattern pattern = Pattern.compile("(aa|aba|bcc|cc|cdc)");
//        String numeral = scan.nextLine();
//        Matcher matcher = pattern.matcher(numeral);
//        StringBuilder sb = new StringBuilder();
//        while(matcher.find()) {
//            sb.append(dict.get(matcher.group()));
//        }
//        BigInteger number = new BigInteger(sb.toString(), 5);
//        System.out.println(number);
        System.out.println(
                new BigInteger(new BigInteger(scan.nextLine()
                        .replace("aba", "1")
                        .replace("bcc", "2")
                        .replace("aa", "0")
                        .replace("cdc", "4")
                        .replace("cc", "3"), 5)
                        .toString(10)));
    }
}
