import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 17.03.2016 г..
 */
public class CalculateExpression {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        double a = scan.nextDouble();
        double b = scan.nextDouble();
        double c = scan.nextDouble();

        double f1 = Math.pow((Math.pow(a,2) + Math.pow(b,2)) / (Math.pow(a,2) - Math.pow(b,2)), ((a + b + c) / Math.sqrt(c)));
        double f2 = Math.pow((Math.pow(a,2) + Math.pow(b,2) - Math.pow(c,3)),(a - b));
        double avg1 = (a + b + c) / 3;
        double avg2 = (f1 + f2) / 2;
        double diff = Math.abs(avg1 - avg2);

        System.out.printf("F1 result: %.2f; F2 result: %.2f; Diff: %.2f", f1, f2, diff);
    }
}
