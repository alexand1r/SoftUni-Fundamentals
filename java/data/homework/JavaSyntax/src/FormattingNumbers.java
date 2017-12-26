import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 17.03.2016 г..
 */
public class FormattingNumbers {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        int a = scan.nextInt();
        float b = scan.nextFloat();
        float c = scan.nextFloat();
        String bin = String.format("%10s", Integer.toBinaryString(a)).replace(" ","0");

        System.out.printf("|%-10X|%s|%10.2f|%-10.3f|", a, bin, b, c);
    }
}
