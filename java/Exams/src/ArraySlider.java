import com.sun.org.apache.xpath.internal.SourceTree;

import java.math.BigInteger;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Locale;
import java.util.Scanner;
import java.util.stream.Collectors;

/**
 * Created by Alec on 21.04.2016 г..
 */
public class ArraySlider {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);

        String[] input = scan.nextLine().split("\\s+");
        long[] nums = new long[input.length];
        for (int i = 0; i < input.length; i++) {
            nums[i] = Long.parseLong(input[i]);
        }
        int currentIndex = 0;
        String command = scan.nextLine();
        while (!command.equals("stop")) {
            String[] tokens = command.split("\\s+");
            int offset = Integer.parseInt(tokens[0]) % nums.length;
            String operation = tokens[1];
            int value = Integer.parseInt(tokens[2]);

            if (offset < 0) {
                offset += nums.length;
            }
            currentIndex = (currentIndex + offset) % nums.length;

            switch (operation) {
                case "+":
                    nums[currentIndex] += value;
                    break;
                case "-":
                    nums[currentIndex] -= value;
                    break;
                case "*":
                    nums[currentIndex] *= value;
                    break;
                case "/":
                    nums[currentIndex] /= value;
                    break;
                case "|":
                    nums[currentIndex] |= value;
                    break;
                case "&":
                    nums[currentIndex] &= value;
                    break;
                default: break;
            }


            if (nums[currentIndex] < 0) {
                nums[currentIndex] = 0;
            }

            command = scan.nextLine();
        }

        System.out.println(Arrays.toString(nums));
    }
}
