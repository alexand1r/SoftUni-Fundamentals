import java.util.Arrays;
import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 12.04.2016 г..
 */
public class RubiksMatrix {
    static int[][] matrix;
    static int rows;
    static int cols;

    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);

        int[] dimensions = Arrays.stream(scan.nextLine().split(" "))
                .mapToInt(Integer::parseInt).toArray();
        rows = dimensions[0];
        cols = dimensions[1];

        matrix = new int[rows][cols];
        int filler = 1;
        for (int r = 0; r < rows; r++) {
            for (int c = 0; c < cols; c++) {
                matrix[r][c] += filler;
                filler++;
            }
        }

        int n = scan.nextInt(); scan.nextLine();

        for (int i = 0; i < n; i++) {
            String[] command = scan.nextLine().split("\\s+");

            int whatToShift = Integer.parseInt(command[0]);
            String direction = command[1];
            int moves = Integer.parseInt(command[2]);

            switch (direction) {
                case "up":
                    shiftUp(whatToShift, moves);
                    break;
                case "down":
                    shiftDown(whatToShift, moves);
                    break;
                case "right":
                    shiftRight(whatToShift, moves);
                    break;
                case "left":
                    shiftLeft(whatToShift, moves);
                    break;
                default:
                    break;
            }
        }
        //PrintMatrix();
        reArrangeMatrix();
    }

    private static void reArrangeMatrix() {
        int checker = 1;
        for (int r1 = 0; r1 < rows; r1++) {
            for (int c1 = 0; c1 < cols; c1++) {
                int currItem = matrix[r1][c1];
                if (checker == currItem) {
                    System.out.println("No swap required");
                } else {
                    boolean found = false;
                    for (int r2 = 0; r2 < rows; r2++) {
                        for (int c2 = 0; c2 < cols; c2++) {
                            if (checker == matrix[r2][c2]) {
                                System.out.printf("Swap (%d, %d) with (%d, %d)%n",
                                        r1, c1, r2, c2);
                                matrix[r1][c1] = matrix[r2][c2];
                                matrix[r2][c2] = currItem;
                                found = true;
                                break;
                            }
                        }
                        if (found) break;
                    }
                }
                checker++;
            }
        }
    }

    private static void PrintMatrix() {
        for (int r = 0; r < rows; r++) {
            System.out.println(Arrays.toString(matrix[r]));
        }
    }

    private static void shiftLeft(int whatToShift, int moves) {
        moves %= cols;
        for (int i = 0; i < moves; i++) {
            int temp = matrix[whatToShift][0];
            for (int c = 1; c < cols; c++) {
                matrix[whatToShift][c - 1] = matrix[whatToShift][c];
            }

            matrix[whatToShift][cols - 1] = temp;
        }
    }

    private static void shiftRight(int whatToShift, int moves) {
        moves %= cols;
        for (int i = 0; i < moves; i++) {
            int temp = matrix[whatToShift][cols - 1];
            for (int c = cols - 2; c >= 0; c--) {
                matrix[whatToShift][c + 1] = matrix[whatToShift][c];
            }

            matrix[whatToShift][0] = temp;
        }
    }

    private static void shiftDown(int whatToShift, int moves) {
        moves %= rows;
        for (int i = 0; i < moves; i++) {
            int temp = matrix[rows - 1][whatToShift];
            for (int r = rows - 2; r >= 0; r--) {
                matrix[r + 1][whatToShift] = matrix[r][whatToShift];
            }

            matrix[0][whatToShift] = temp;
        }

    }

    private static void shiftUp(int whatToShift, int moves) {
        moves %= cols;
        for (int i = 0; i < moves; i++) {
            int temp = matrix[0][whatToShift];
            for (int r = 1; r < rows; r++) {
                matrix[r - 1][whatToShift] = matrix[r][whatToShift];
            }

            matrix[rows - 1][whatToShift] = temp;
        }
    }
}
