import java.util.HashMap;
import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 31.03.2016 г..
 */
public class Problem7MagicExchangeableWords {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        String[] line = scan.nextLine().split(" ");
        String first = line[0];
        String second = line[1];
        System.out.println(areEqual(first, second));
    }

    private static boolean areEqual(String a, String b) {
        boolean areEqual = true;
        HashMap<Character, Character> map = new HashMap<>();
        if (a.length() == b.length()) {
            for (int i = 0; i < a.length(); i++) {
                char firstChar = a.charAt(i);
                char secondChar = b.charAt(i);
                if (!map.containsKey(firstChar)) {
                    map.put(firstChar, secondChar);
                }else{
                    if(!map.containsValue(secondChar)){
                        areEqual= false;
                    }
                }
            }
        } else {
            areEqual = false;
        }

        return areEqual;
    }
}
