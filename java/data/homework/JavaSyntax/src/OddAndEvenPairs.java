import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 17.03.2016 г..
 */
public class OddAndEvenPairs {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        String[] str = scan.nextLine().split(" ");
        if (str.length % 2 != 0) {
            System.out.println("Invalid lenght");
        } else {
            for (int i = 0; i < str.length; i += 2) {
                int a = Integer.parseInt(str[i]);
                int b = Integer.parseInt(str[i+1]);
                if (a % 2 == 0 && b % 2 == 0){
                    System.out.println("Both are even");
                } else if (a % 2 != 0 && b % 2 != 0){
                    System.out.println("Both are odd");
                } else {
                    System.out.println("different");
                }
            }
        }
    }
}
