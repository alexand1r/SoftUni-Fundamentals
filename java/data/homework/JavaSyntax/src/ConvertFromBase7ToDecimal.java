import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 17.03.2016 г..
 */
public class ConvertFromBase7ToDecimal {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        double a = scan.nextDouble();
        int n = 0;
        int exponent = 0;
        double result = 0;

        while (a > 0){
            n = (int)a % 10;
            a = (int)a / 10;
            result += n * Math.pow(7,exponent);
            exponent++;
        }

        System.out.println((int)result);
    }
}
