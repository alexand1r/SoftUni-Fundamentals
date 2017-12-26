import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 17.03.2016 г..
 */
public class ConvertFromDecimalSystemToBase7 {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        double a = scan.nextDouble();
        double mul = 1;
        int remainder = 0;
        double result = 0;

        while (a > 1){
            remainder = (int)a % 7;
            a = (int)a / 7;
            result += remainder * mul;
            mul *= 10;
        }
        result += a * mul;

        System.out.println((int)result);
    }
}
