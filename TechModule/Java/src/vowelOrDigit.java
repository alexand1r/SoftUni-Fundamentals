import java.util.Scanner;

/**
 * Created by Alec on 28-Jul-16.
 */
public class vowelOrDigit {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String character = scan.next();
        char ch = character.charAt(0);
        if (Character.isDigit(ch)) {
            System.out.println("digit");
        } else if (Character.isAlphabetic(ch)) {
            System.out.println("vowel");
        } else {
            System.out.println("other");
        }
    }
}
