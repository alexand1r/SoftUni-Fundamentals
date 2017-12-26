import java.util.Scanner;

/**
 * Created by Alec on 28-Jul-16.
 */
public class integerToHexAndBinary {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();
        String hex = Integer.toHexString(n);
        System.out.println(hex.toUpperCase());
        System.out.println(Integer.toString(n, 2));
    }
}
