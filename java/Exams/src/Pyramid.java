import java.util.Arrays;
import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 06.04.2016 г..
 */
public class Pyramid {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();
        scan.nextLine();
        String firstLine = scan.nextLine();

        int currentNumber = Integer.parseInt(firstLine.trim());
        String output = "" + currentNumber;

        for (int i = 1; i < n; i++) {
            String nextLine = scan.nextLine();
            String[] numbersAsString = nextLine.trim().split("[ ]+");
            int[] numbers = new int[numbersAsString.length];
            for (int j = 0; j < numbersAsString.length; j++) {
                numbers[j] = Integer.parseInt(numbersAsString[j]);
            }

            Arrays.sort(numbers);
            boolean isBreak = false;
            for (int j = 0; j < numbersAsString.length; j++) {
                if (numbers[j] > currentNumber) {
                    currentNumber = numbers[j];
                    output += ", " + currentNumber;
                    isBreak = true;
                    break;
                }
            }

            if (!isBreak) {
                currentNumber++;
            }
        }

        System.out.print(output);
    }
}
