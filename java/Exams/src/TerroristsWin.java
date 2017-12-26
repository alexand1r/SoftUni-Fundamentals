import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 06.04.2016 г..
 */
public class TerroristsWin {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        StringBuilder text = new StringBuilder(scan.nextLine());

        int currentIndex = 0,
                bombStartIndex = 0,
                bombEndIndex;

        while ((bombStartIndex = text.indexOf("|", currentIndex)) != -1) {
            bombEndIndex = text.indexOf("|", bombStartIndex + 1);
            String bombContent = text.substring(bombStartIndex + 1, bombEndIndex);

            int bombPower = getBombPower(bombContent),
                    startIndex = Math.max(0, bombStartIndex - bombPower),
                    endIndex = Math.min(text.length() - 1, bombEndIndex + bombPower);

            while (startIndex <= endIndex) {
                text.setCharAt(startIndex, '.');
                startIndex++;
            }

            currentIndex = bombEndIndex + 1;
        }

        System.out.println(text);
    }

    private static int getBombPower(String bombContent) {
        int bombPower = 0;
        for (char ch : bombContent.toCharArray()) {
            bombPower += ch;
        }

        return bombPower % 10;
    }
}
