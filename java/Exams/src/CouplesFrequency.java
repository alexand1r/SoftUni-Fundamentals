import java.util.HashMap;
import java.util.HashSet;
import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 30.03.2016 г..
 */
public class CouplesFrequency {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);

        String sequence = scan.nextLine();
        String[] numsStr = sequence.split(" ");
        int[] nums = new int[numsStr.length];
        for (int i = 0; i < nums.length; i++) {
            nums[i] = Integer.parseInt(numsStr[i]);
        }

        // Calculate number of occurrences of each two consecutive numbers
        HashMap<String, Integer> counts = new HashMap<>();
        for (int i = 1; i < nums.length; i++) {
            int first = nums[i-1];
            int second = nums[i];
            String key = first + " " + second;
            Integer count = counts.get(key);
            if (count == null) {
                count = 0;
            }
            count++;
            counts.put(key, count);
        }

        // Calculate the frequencies and print them in percentages
        HashSet<String> printedCouples = new HashSet<>();
        for (int i = 1; i < nums.length; i++) {
            int first = nums[i-1];
            int second = nums[i];
            String key = first + " " + second;
            if (! printedCouples.contains(key)) {
                int count = counts.get(key);
                float frequency = (float)count / (nums.length - 1);
                System.out.printf("%s -> %.2f%%%n", key, frequency*100);
                printedCouples.add(key);
            }
        }
    }
}
