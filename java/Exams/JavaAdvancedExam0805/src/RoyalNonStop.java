import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.DoubleSummaryStatistics;
import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 08.05.2016 г..
 */
public class RoyalNonStop {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        double totalAmount = 0;
        int customers = 0;

        String[] dimensions = scan.nextLine().split(" ");
        int rows = Integer.parseInt(dimensions[0]);
        int cols = Integer.parseInt(dimensions[1]);

        ArrayList<ArrayList<String>> store = new ArrayList<>();
        for (int row = 0; row < rows; row++) {
            ArrayList<String> colsList = new ArrayList<>();
            for (int col = 0; col < cols; col++) {
                if (row % 2 == 0) {
                    colsList.add("L");
                } else {
                    colsList.add("R");
                }
            }
            store.add(colsList);
        }
        store.get(0).set(0, "D");

        String[] prices = scan.nextLine().split(" ");
        double lukanka = Double.parseDouble(prices[0]);
        double rakija = Double.parseDouble(prices[1]);

        String command = scan.nextLine();
        while (!command.equals("Royal Close")) {
            String[] coords = command.split(" ");
            int row = Integer.parseInt(coords[0]);
            int col = Integer.parseInt(coords[1]);
            double totalPrice = 0;

            if (row < col) {
                for (int i = row; i >= 0 ; i--) {
                    if (store.get(i).get(col).equals("L")) {
                        totalPrice += ((i + 1) * (col + 1)) * lukanka;
                    } else if (store.get(i).get(col).equals("R")){
                        totalPrice += ((i + 1) * (col + 1)) * rakija;
                    }
                }
                for (int i = col - 1; i >= 0 ; i--) {
                    if (store.get(0).get(i).equals("L")) {
                        totalPrice += (i + 1) * lukanka;
                    } else if (store.get(0).get(i).equals("R")){
                        totalPrice += (i + 1) * rakija;
                    }
                }
            } else {
                for (int i = col; i >= 0 ; i--) {
                    if (store.get(row).get(i).equals("L")) {
                        totalPrice += ((row + 1) * (i + 1)) * lukanka;
                    } else if (store.get(row).get(i).equals("R")){
                        totalPrice += ((row + 1) * (i + 1)) * rakija;
                    }
                }
                for (int i = row - 1; i >= 0 ; i--) {
                    if (store.get(i).get(0).equals("L")) {
                        totalPrice += (i + 1) * lukanka;
                    } else if (store.get(i).get(0).equals("R")){
                        totalPrice += (i + 1) * rakija;
                    }
                }
            }
            totalAmount += totalPrice;
            customers++;

            command = scan.nextLine();
        }

        System.out.printf("%.6f%n", totalAmount);
        System.out.println(customers);



//        for (int i = 0; i < store.size(); i++) {
//            for (int j = 0; j < store.get(i).size(); j++) {
//                System.out.print(store.get(i).get(j) + " ");
//            }
//            System.out.println();
//        }
    }
}
