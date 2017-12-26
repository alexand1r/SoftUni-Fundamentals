import com.sun.org.apache.xerces.internal.impl.xpath.regex.Match;
import com.sun.org.apache.xpath.internal.SourceTree;

import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Alec on 17.04.2016 г..
 */
public class ShmoogleCounter {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);

        ArrayList<String> doubles = new ArrayList<>();
        ArrayList<String> ints = new ArrayList<>();

        StringBuilder sb = new StringBuilder();

        Pattern pattern = Pattern.compile("(int|double) (\\b[a-z]([a-zA-Z0-9]+)*)");

        String command = scan.nextLine();
        while (!command.equals("//END_OF_CODE")) {
            sb.append(command);
            command = scan.nextLine();
        }

        Matcher matcher = pattern.matcher(sb.toString());
        while (matcher.find()) {
            String doubleInt = matcher.group(1);
            String name = matcher.group(2);
            if (doubleInt.equals("double")) {
                doubles.add(name);
            } else if (doubleInt.equals("int")) {
                ints.add(name);
            }
        }

        if (doubles.isEmpty()) {
            System.out.print("Doubles: None");
        } else {
            System.out.print("Doubles: ");
            Collections.sort(doubles);
            String result = "";
            for (String aDouble : doubles) {
                result += aDouble + ", ";
            }
            result = result.substring(0, result.length() - 2);
            System.out.print(result);
        }

        if (ints.isEmpty()) {
            System.out.print("\nInts: None");
        } else {
            System.out.print("\nInts: ");
            Collections.sort(ints);
            String result = "";
            for (String anInt : ints) {
                result += anInt + ", ";
            }
            result = result.substring(0, result.length() - 2);
            System.out.print(result);
        }
    }
}
