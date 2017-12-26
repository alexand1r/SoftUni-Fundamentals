import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 14.04.2016 г..
 */
public class Monopoly {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);

        int money = 50;
        int numOfHotels = 0;
        int steps = 0;
        String[] dimensions = scan.nextLine().split("\\s+");
        int rows = Integer.parseInt(dimensions[0]);
        int cols = Integer.parseInt((dimensions[1]));
        String[] matrix = new String[rows];

        for (int i = 0; i < rows; i++) {
            matrix[i] = scan.nextLine();
        }

        for (int i = 0; i < rows; i++) {
            if (i % 2 == 0) {
                for (int j = 0; j < cols; j++) {
                    char current = matrix[i].charAt(j);
                    if (current == 'H') {
                        numOfHotels++;
                        System.out.printf("Bought a hotel for %d. Total hotels: %d.%n"
                                , money, numOfHotels);
                        money = 0;
                    } else if (current == 'J') {
                        System.out.printf("Gone to jail at turn %d.%n", steps);
                        steps += 2;
                        money += (10 * numOfHotels) * 2;
                    } else if (current == 'S') {
                        int product = (i + 1) * (j + 1);
                        product = product > money ? money : product;
                        money -= product;

                        System.out.printf("Spent %d money at the shop.%n", product);
                    }

                    money += 10 * numOfHotels;
                    ++steps;
                }
            } else {
                for (int j = cols - 1; j >= 0; j--) {
                    char current = matrix[i].charAt(j);
                    if (current == 'H') {
                        numOfHotels++;
                        System.out.printf("Bought a hotel for %d. Total hotels: %d.%n"
                                , money, numOfHotels);
                        money = 0;
                    } else if (current == 'J') {
                        System.out.printf("Gone to jail at turn %d.%n", steps);
                        steps += 2;
                        money += (10 * numOfHotels) * 2;
                    } else if (current == 'S') {
                        int product = (i + 1) * (j + 1);
                        product = product > money ? money : product;
                        money -= product;

                        System.out.printf("Spent %d money at the shop.%n", product);
                    }

                    money += 10 * numOfHotels;
                    ++steps;
                }
            }
        }

        System.out.printf("Turns %d%n", steps);
        System.out.printf("Money %d%n", money);
    }
}
