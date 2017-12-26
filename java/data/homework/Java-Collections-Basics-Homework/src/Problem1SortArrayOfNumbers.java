import java.util.Arrays;
import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 25.03.2016 г..
 */
public class Problem1SortArrayOfNumbers {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();
        scan.nextLine();
        String[] nums = scan.nextLine().split(" ");
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++){
            numbers[i] = Integer.parseInt(nums[i]);
        }
        Arrays.sort(numbers);
        for (int number : numbers) {
            System.out.print(number + " ");
        }
    }
}
