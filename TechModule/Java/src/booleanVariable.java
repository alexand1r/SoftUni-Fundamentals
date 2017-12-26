import java.util.Scanner;

import static java.lang.Boolean.parseBoolean;

/**
 * Created by Alec on 28-Jul-16.
 */
public class booleanVariable {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String bool = scan.next();
        boolean parsed = parseBoolean(bool);
        if (parsed) {
            System.out.println("Yes");
        } else {
            System.out.println("No");
        }
    }
}
