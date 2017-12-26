import java.util.HashSet;
import java.util.Locale;
import java.util.Scanner;


/**
 * Created by Alec on 29.03.2016 г..
 */
public class PythagoreanNumbers {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();
        int[] nums = new int[n];
        for (int i = 0; i < nums.length; i++) {
            nums[i] = scan.nextInt();
        }
        HashSet<Integer> squares = new HashSet<>();
        for (int num : nums) {
            squares.add(num * num);
        }
        int count = 0;
        for (int a : nums) {
            for (int b : nums) {
                int cSquare = a*a + b*b;
                if (a <= b && squares.contains(cSquare)) {
                    int c = (int)Math.sqrt(cSquare);
                    System.out.printf(
                            "%d*%d + %d*%d = %d*%d\n",
                            a, a, b, b, c, c);
                    count++;
                }
            }
        }
        if (count == 0) {
            System.out.println("No");
        }
    }
}
