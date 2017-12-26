import java.math.BigDecimal;
import java.util.Arrays;
import java.util.List;
import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 30.03.2016 г..
 */
public class ThreeLargestNumbers {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();
        scan.nextLine();
        BigDecimal[] nums = new BigDecimal[n];
        for (int i = 0; i < nums.length; i++) {
            String num = scan.nextLine();
            nums[i] = new BigDecimal(num);
        }
//        Arrays.sort(nums);
//        int count = 3;
//        for (int i = nums.length-1; i >= 0 && count > 0; i--, count--) {
//            System.out.println(nums[i].toPlainString());
//        }
        Arrays.stream(nums)
                .sorted((x, y) -> y.compareTo(x))
                .limit(3)
                .forEach(System.out::println);
    }
}
