import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 06.04.2016 г..
 */
public class MirrorNumbers {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        boolean found = false;
        int n = scan.nextInt(); scan.nextLine();
        String[] numbers = scan.nextLine().split(" ");
        for (int i = 0; i < numbers.length; i++) {
            for (int j = i + 1; j < numbers.length; j++) {
                String number1 = numbers[i];
                String number2 = reverseString(numbers[j]);

                if (number1.equals(number2)){
                    System.out.printf("%s<!>%s%n", number1, numbers[j]);
                    found = true;
                }
            }
        }
        if(!found){
            System.out.println("No");
        }
    }

    public static String reverseString(String str) {
        String result = "";
        for (int i = str.length() - 1; i >= 0 ; i--) {
            result += str.charAt(i);
        }
        return result;
    }
}
