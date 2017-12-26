import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 17.03.2016 г..
 */
public class HitTheTarget {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();

        for (int i = 1; i <= 20; i++) {
            for (int j = 1; j <= 20; j++) {
                if (i + j == n){
                    System.out.printf("%d + %d = %d\n", i, j, n);
                } else if (i - j == n){
                    System.out.printf("%d - %d = %d\n", i, j, n);
                }
            }
        }
    }
}
