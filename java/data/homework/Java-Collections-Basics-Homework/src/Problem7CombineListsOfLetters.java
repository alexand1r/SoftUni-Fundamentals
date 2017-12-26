import java.util.ArrayList;
import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 25.03.2016 г..
 */
public class Problem7CombineListsOfLetters {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        ArrayList<Character> arrLineOne = new ArrayList<>();
        ArrayList<Character> arrLineTwo = new ArrayList<>();

        for (Character c : scan.nextLine().toCharArray()) {
            arrLineOne.add(c);
        }
        for (Character c : scan.nextLine().toCharArray()) {
            arrLineTwo.add(c);
        }

        ArrayList<Character> outputList = new ArrayList<>();

        outputList.addAll(arrLineOne);

        for (int i = 0; i < arrLineTwo.size(); i++) {
            if (!arrLineOne.contains(arrLineTwo.get(i))) {
                outputList.add(' ');
                outputList.add(arrLineTwo.get(i));
            }
        }

        for (Character character : outputList) {
            System.out.print(character);
        }

    }
}
