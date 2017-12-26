import java.util.Arrays;
import java.util.List;
import java.util.Locale;
import java.util.Scanner;
import java.util.stream.Collectors;

/**
 * Created by Alec on 06.04.2016 г..
 */
public class PossibleTriangles {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        String command = scan.nextLine();
        boolean found = false;

        while (!command.equals("End")){
            String[] input = command.split(" ");
            List<Double> sides = Arrays
                    .stream(input)
                    .sorted()
                    .map(Double::parseDouble)
                    .collect(Collectors.toList());
            double a = sides.get(0);
            double b = sides.get(1);
            double c = sides.get(2);
            if ((a + b) > c) {
                System.out.printf("%.2f+%.2f>%.2f%n", a, b, c);
                found = true;
            }

            command = scan.nextLine();
        }

        if (!found) {
            System.out.println("No");
        }
    }
}
