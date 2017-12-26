import java.util.Scanner;

/**
 * Created by Alec on 28-Jul-16.
 */
public class hex {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);
        String number = scan.next();
        int num = Integer.parseInt(number, 16);
        System.out.println(num);
    }
}
