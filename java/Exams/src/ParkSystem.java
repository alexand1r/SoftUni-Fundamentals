import java.util.Locale;
import java.util.Scanner;
import java.util.regex.Matcher;

/**
 * Created by Alec on 13.04.2016 г..
 */
// 80/ 100
public class ParkSystem {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        String[] dimensions = scan.nextLine().trim().split("\\s+");
        int rows = Integer.parseInt(dimensions[0]);
        int cols = Integer.parseInt(dimensions[1]);
        boolean[][] positions = new boolean[rows][cols];
        String command = scan.nextLine();
        while (!command.equals("stop")) {
            String[] nums = command.split("\\s+");
            int steps = 1;
            int entryRow = Integer.parseInt(nums[0]);
            int row = Integer.parseInt(nums[1]);
            if (isRowFull(positions, row)) {
                System.out.printf("Row %d full%n", row);
            } else {
                int col = Integer.parseInt(nums[2]);
                steps += Math.abs(row - entryRow);
                if (!positions[row][col]) {
                    steps += col;
                    positions[row][col] = true;
                    System.out.println(steps);
                } else {
                    int distance = Math.max(col - 1, cols - 1 - col);
                    for (int i = 1; i <= distance; i++) {
                        int leftIndex = Math.max(1, col - 1);
                        int rightIndex = Math.min(cols - 1, col + i);
                        if (!positions[row][leftIndex]) {
                            positions[row][leftIndex] = true;
                            steps += leftIndex;
                            break;
                        } else if (!positions[row][rightIndex]) {
                            positions[row][rightIndex] = true;
                            steps += rightIndex;
                            break;
                        }
                    }
                    System.out.println(steps);
                }
            }
            command = scan.nextLine();
        }

    }
    private static boolean isRowFull(boolean[][] matrix, int row) {
        for (int i = 1; i < matrix[row].length; i++) {
          if (!matrix[row][i]) {
              return false;
          }
        }
        return true;
    }
}
