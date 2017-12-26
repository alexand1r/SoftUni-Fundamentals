import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 25.03.2016 г..
 */
public class Problem5CountAllWords {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        String[] str = scan.nextLine().split("\\W+");//split("[, .()!?-]+");
        System.out.println(str.length);
    }
}
