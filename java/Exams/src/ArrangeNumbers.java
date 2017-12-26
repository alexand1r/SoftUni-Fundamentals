
import java.util.*;

/**
 * Created by Alec on 19.03.2016 г..
 */
public class ArrangeNumbers {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        TreeMap<String, String> map = new TreeMap<String,String>();
        String[] input = scan.nextLine().split(", ");
        for (int i = 0; i < input.length; i++) {
            String digit = "";
            for (int j = 0; j < input[i].length(); j++) {
                switch(input[i].charAt(j)){
                    case '0': digit += "zero-"; break;
                    case '1': digit += "one-"; break;
                    case '2': digit += "two-"; break;
                    case '3': digit += "three-"; break;
                    case '4': digit += "four-"; break;
                    case '5': digit += "five-"; break;
                    case '6': digit += "six-"; break;
                    case '7': digit += "seven-"; break;
                    case '8': digit += "eight-"; break;
                    case '9': digit += "nine-"; break;
                    //default: System.out.println("Error"); break;
                }
            }
            digit = digit.substring(0, digit.length() - 1);
            if (!map.containsKey(digit)){
                map.put(digit, input[i]);
            } else {
                String newValue = map.get(digit) + ", " + input[i];
                map.replace(digit, newValue);
            }

        }
        String outputLine = String.join(", ", map.values());

        System.out.println(outputLine);
    }
}
