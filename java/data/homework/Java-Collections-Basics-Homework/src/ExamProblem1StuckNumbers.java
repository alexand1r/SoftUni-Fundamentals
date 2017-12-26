import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 25.03.2016 г..
 */
public class ExamProblem1StuckNumbers {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();
        int[] nums = new int[n];
        for (int i = 0; i < nums.length; i++) {
            nums[i] = scan.nextInt();
        }

        // Find and print all stuck numbers {a, b, c, d}
        int count = 0;
        for (int i = 0; i < nums.length; i++) {
            for (int j = 0; j < nums.length; j++) {
                for (int k = 0; k < nums.length; k++) {
                    for (int f = 0; f < nums.length; f++) {
                        int a = nums[i];
                        int b = nums[j];
                        int c = nums[k];
                        int d = nums[f];
                        if (a != b && a != c & a != d &&
                                b != c && b != d && c != d) {
                            String first = "" + a + b;
                            String second = "" + c + d;
                            if (first.equals(second)) {
                                System.out.printf("%d|%d==%d|%d\n",
                                        a, b, c, d);
                                count++;
                            }
                        }
                    }
                }
            }
        }

        if (count == 0) {
            System.out.println("No");
        }
    }
}
