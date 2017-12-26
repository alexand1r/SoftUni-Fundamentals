import java.util.Locale;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Alec on 12.04.2016 г..
 */
public class SoftUniDefenseSystem {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        Pattern pattern = Pattern.compile("([A-Z][a-z]+).*?([A-Z][a-z]*[A-Z]).*?(\\d+)L");
        String command = scan.nextLine();
        double totalAmountAlcohol = 0;

        while (!command.equals("OK KoftiShans")) {
            Matcher matcher = pattern.matcher(command);
            String name = ""; String drink = ""; int amount = 0;
            while (matcher.find()) {
                name = matcher.group(1);
                drink = matcher.group(2).toLowerCase();
                amount = Integer.parseInt(matcher.group(3));
                totalAmountAlcohol += amount;
                System.out.printf("%s brought %d liters of %s!%n", name, amount, drink);
            }

            command = scan.nextLine();
        }

        totalAmountAlcohol *= 0.001;
        System.out.printf("%.3f softuni liters", totalAmountAlcohol);
    }
}
