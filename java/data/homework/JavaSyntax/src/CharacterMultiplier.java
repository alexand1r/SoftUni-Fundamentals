import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 17.03.2016 г..
 */
public class CharacterMultiplier {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        String str1 = scan.nextLine();
        String str2 = scan.nextLine();

        System.out.println(multiplier(str1,str2));
    }

    public static int multiplier(String str1, String str2){
        String leftOvers = "";
        int result = 0 ;
        if (str1.length() > str2.length()){
            leftOvers = str1.substring(str2.length());
            for (int i = 0; i < str2.length(); i++) {
                result += str1.charAt(i) * str2.charAt(i);
            }
            for (int i = 0; i < leftOvers.length(); i++) {
                result += leftOvers.charAt(i);
            }
        } else if (str1.length() < str2.length()){
            leftOvers = str2.substring(str1.length());
            for (int i = 0; i < str1.length(); i++) {
                result += str1.charAt(i) * str2.charAt(i);
            }
            for (int i = 0; i < leftOvers.length(); i++) {
                result += leftOvers.charAt(i);
            }
        } else {
            for (int i = 0; i < str2.length(); i++) {
                result += str1.charAt(i) * str2.charAt(i);
            }
        }
        return result;
    }
}
