import java.util.Scanner;

/**
 * Created by Alec on 28-Jul-16.
 */
public class reverseCharacters {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String first = scan.next();
        String second = scan.next();
        String third = scan.next();

        StringBuilder sb = new StringBuilder();
        sb.append(third);
        sb.append(second);
        sb.append(first);

        System.out.println(sb.toString());
    }
}
