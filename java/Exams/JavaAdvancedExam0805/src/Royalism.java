import java.util.ArrayList;
import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 08.05.2016 г..
 */
public class Royalism {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        ArrayList<String> royalists = new ArrayList<>();
        ArrayList<String> nonRoyalists = new ArrayList<>();

        String[] names = scan.nextLine().split(" ");
        for (int i = 0; i < names.length; i++) {
            String currentName = names[i];
            int sum = 0;

            for (int ch = 0; ch < currentName.length(); ch++) {
                char currentChar = currentName.charAt(ch);
                sum += (int)currentChar;
                while (sum > 26) {
                    sum -= 26;
                }
            }

            if (sum == 18) {
                royalists.add(currentName);
            } else {
                nonRoyalists.add(currentName);
            }
        }

        if (royalists.size() >= nonRoyalists.size()) {
            System.out.printf("Royalists - %d%n", royalists.size());
            for (String royalist : royalists) {
                System.out.println(royalist);
            }
            System.out.println("All hail Royal!");

        } else {
            for (String nonRoyalist : nonRoyalists) {
                System.out.println(nonRoyalist);
            }
            System.out.println("Royalism, Declined!");
        }
    }
}
