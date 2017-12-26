import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 08.04.2016 г..
 */
public class Enigma {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        int n = Integer.parseInt(scan.nextLine());

        for (int i = 0; i < n; i++) {
            String line = scan.nextLine();
            StringBuilder sb = new StringBuilder();
            int lenght = line.replace(" ", "").length() / 2;
            for (int j = 0; j < line.length(); j++) {
                char currentChar = line.charAt(j);
                if ((currentChar >= '0' && currentChar <= '9') || currentChar == ' '){
                    sb.append(currentChar);
                } else {
                    sb.append((char) (currentChar + lenght));
                }
            }
            System.out.println(sb.toString());
        }
    }
}
