import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 25.03.2016 г..
 */
public class Problem6CountSpecifiedWord {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        String str = scan.nextLine();
        String specifiedWord = scan.nextLine();

        String[] words = str.split("\\W+");

        int count = 0;
        for (int i = 0; i < words.length; i++) {
            if (words[i].toLowerCase().equals(specifiedWord)) {
                count++;
            }
        }
        System.out.println(count);
    }
}
