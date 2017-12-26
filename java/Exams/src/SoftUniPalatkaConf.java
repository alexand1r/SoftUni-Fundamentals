import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 12.04.2016 г..
 */
public class SoftUniPalatkaConf {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        int people = scan.nextInt(); scan.nextLine();
        int n = scan.nextInt(); scan.nextLine();
        int beds = 0;
        int meals = 0;

        for (int i = 0; i < n; i++) {
            String[] input = scan.nextLine().split("\\s+");
            String tentsFoodRooms = input[0];
            int quantity = Integer.parseInt(input[1]);
            String type = input[2];

            if (tentsFoodRooms.equals("tents")) {
                beds += type.equals("normal") ? (2 * quantity) : (3 * quantity);
            } else if (tentsFoodRooms.equals("rooms")) {
                beds += type.equals("single") ?
                        (1 * quantity) : type.equals("double") ?
                        (2 * quantity) : (3 * quantity);
            } else {
                if (type.equals("musaka")) {
                    meals += 2 * quantity;
                }
            }
        }

        if (beds >= people) {
            System.out.printf("Everyone is happy and sleeping well. Beds left: %d%n", beds - people);
        } else {
            System.out.printf("Some people are freezing cold. Beds needed: %d%n", people - beds);
        }
        if (meals >= people) {
            System.out.printf("Nobody left hungry. Meals left: %d", meals - people);
        } else {
            System.out.printf("People are starving. Meals needed: %d", people - meals);
        }

    }
}
