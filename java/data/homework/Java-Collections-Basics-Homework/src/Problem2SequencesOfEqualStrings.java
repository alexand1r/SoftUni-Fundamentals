import java.util.ArrayList;
import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 25.03.2016 г..
 */
public class Problem2SequencesOfEqualStrings {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        String[] str = scan.nextLine().split(" ");
        System.out.print(str[0]);
        for (int i = 1; i < str.length; i++) {
            if (str[i].equals(str[i-1])) {
                System.out.print(" " + str[i]);
            }
            else {
                System.out.println();
                System.out.print(str[i]);
            }
        }
    }
}
