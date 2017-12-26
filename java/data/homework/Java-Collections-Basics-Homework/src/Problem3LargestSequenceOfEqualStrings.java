import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 25.03.2016 г..
 */
public class Problem3LargestSequenceOfEqualStrings {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        String[] numbers = scan.nextLine().split(" ");
        int largestSequence = 1, index = 0, tempLargest = 1;

        for (int i = 1; i < numbers.length; i++) {
            if (numbers[i].equals(numbers[i - 1])) {
                tempLargest++;
            } else {
                tempLargest = 1;
            }

            if (tempLargest > largestSequence) {
                largestSequence = tempLargest;
                index = i-largestSequence+1;
            }

        }
        for (int i = 0; i < largestSequence; i++) {

            System.out.print(numbers[index] + " ");
        }
    }
}
