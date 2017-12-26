import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 17.03.2016 г..
 */
public class RectangleArea {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        int a = scan.nextInt();
        int b = scan.nextInt();
        int area = a * b;
        System.out.println(area);
    }
}
