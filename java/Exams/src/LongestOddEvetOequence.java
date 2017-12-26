import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 30.03.2016 г..
 */
public class LongestOddEvetOequence {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        String inputLine = scan.nextLine();
        String[] numbers = inputLine.split("[ ()]+");
        int[] nums = new int[numbers.length-1];
        for (int i = 0; i < nums.length; i++) {
            nums[i] = Integer.parseInt(numbers[i+1]);
        }

        // Find the longest alternating sequence
        int bestLen = 0;
        int len = 0;
        boolean shouldBeOdd = (nums[0] % 2 != 0);
        for (int num : nums) {
            boolean isOdd = num % 2 != 0;
            if (isOdd == shouldBeOdd || num == 0) {
                len++;
            } else {
                shouldBeOdd = isOdd;
                len = 1;
            }
            shouldBeOdd = !shouldBeOdd;
            if (len > bestLen) {
                bestLen = len;
            }
        }

        System.out.println(bestLen);
    }
}