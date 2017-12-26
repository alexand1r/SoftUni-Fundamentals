import java.util.Locale;
import java.util.Scanner;
/**
 * Created by Alec on 20.04.2016 г..
 */
public class BunkerBuster {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        String[] dimensions = scan.nextLine().split(" ");
        int rows = Integer.parseInt(dimensions[0]);
        int cols = Integer.parseInt(dimensions[1]);
        int[][] matrix = new int[rows][cols];
        for (int r = 0; r < rows; r++) {
            String[] line = scan.nextLine().split("\\s+");
            for (int c = 0; c < cols; c++) {
                matrix[r][c] = Integer.parseInt(line[c]);
            }
        }

        String command = scan.nextLine();
        while (!command.equals("cease fire!")) {
            String[] bomb = command.split("\\s+");
            int bombRow = Integer.parseInt(bomb[0]);
            int bombCol = Integer.parseInt(bomb[1]);
            int bombPower = (int)bomb[2].charAt(0);
            matrix[bombRow][bombCol] -= bombPower;
            int rangeDamage = (int) Math.round((bombPower/2) + .5);

            substractIfInBounds(matrix, bombRow - 1, bombCol, rangeDamage);
            substractIfInBounds(matrix, bombRow - 1, bombCol - 1, rangeDamage);
            substractIfInBounds(matrix, bombRow - 1, bombCol + 1, rangeDamage);
            substractIfInBounds(matrix, bombRow, bombCol - 1, rangeDamage);
            substractIfInBounds(matrix, bombRow, bombCol + 1, rangeDamage);
            substractIfInBounds(matrix, bombRow + 1, bombCol, rangeDamage);
            substractIfInBounds(matrix, bombRow + 1, bombCol - 1, rangeDamage);
            substractIfInBounds(matrix, bombRow + 1, bombCol + 1, rangeDamage);


            command = scan.nextLine();
        }

//        for (int i = 0; i < rows; i++) {
//            for (int j = 0; j < cols; j++) {
//               System.out.print(matrix[i][j] + " ");
//            }
//            System.out.println();
//        }
        int destroyedCells = 0;
        for (int r = 0; r < rows; r++) {
            for (int c = 0; c < cols; c++) {
                if (matrix[r][c] <= 0) {
                    destroyedCells++;
                }
            }
        }
        System.out.printf("Destroyed bunkers: %d%n", destroyedCells);
        double damageProcentage = ((double)destroyedCells / (rows * cols)) * 100;
        //System.out.println(damageProcentage);
        System.out.printf("Damage done: %.1f", damageProcentage);
        System.out.print(" %");
    }

    private static void substractIfInBounds(int[][] matrix, int row, int col, int damage) {
        boolean isIn =  row >= 0 && row < matrix.length
                && col >= 0 && col < matrix[row].length;

        if (isIn) {
            matrix[row][col] -= damage;
        }
    }
}
