import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 25.03.2016 г..
 */
public class Problem4LongestIncreasingSequence {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        String[] str = scan.nextLine().split(" ");
        int[] numbers = new int[str.length];

        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = Integer.parseInt(str[i]);
        }

        int largestSequence = 1, index = 0, tempLargest = 1;

        System.out.print(numbers[0]);

        for (int i = 1; i < str.length; i++) {
            if (numbers[i] == (numbers[i - 1] + 1)) {
                tempLargest++;
                System.out.print(" " + numbers[i]);

            } else {
                tempLargest = 1;

                System.out.println();
                System.out.print(numbers[i]);
            }

            if (tempLargest > largestSequence) {
                largestSequence = tempLargest;
                index = i;
            }

        }

        System.out.println();

        System.out.print("Longest: ");

        for (int i = 0; i < largestSequence; i++) {

            System.out.print(str[index - largestSequence + 1 + i] + " ");
        }
    }
}
