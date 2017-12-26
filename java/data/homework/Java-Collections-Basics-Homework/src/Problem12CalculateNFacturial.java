import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 25.03.2016 г..
 */
public class Problem12CalculateNFacturial {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();
        System.out.println(factorial(n));
    }

    public static int factorial(int n){
        int result;
        if(n==0 || n==1){
            return 1;
        }
        result = n * factorial(n-1);
        return result;
    }
}
