import java.util.Locale;
import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;

/**
 * Created by Alec on 25.03.2016 г..
 */
public class Problem8ExtractAllUniqueWords {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);

        String[] str = scan.nextLine().split("\\W+");

        Set<String> alpha = new TreeSet<String>();

        for (String s : str) {
            String word = s.toLowerCase();
            alpha.add(word);
        }

        for (String s : alpha) {
            System.out.print(s + " ");
        }
    }
}
