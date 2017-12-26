import java.util.Arrays;
import java.util.List;
import java.util.Locale;
import java.util.Scanner;
import java.util.stream.Collectors;

/**
 * Created by Alec on 06.04.2016 г..
 */
public class ValidUsernames {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        String[] input = scan.nextLine().split("[^a-zA-Z0-9_]+");
        List<String> usernames;
        usernames = Arrays.stream(input)
                .filter(p -> p.length() > 3 && p.length() < 25)
                .collect(Collectors.toList());
        int maxLenght = Integer.MIN_VALUE;
        int index = 0;
        for (int i = 1; i < usernames.size(); i++) {
            String username1 = usernames.get(i - 1);
            String username2 = usernames.get(i);
            int lenght = username1.length() + username2.length();
            if (maxLenght < lenght) {
                maxLenght = lenght;
                index = i;
            }
        }
        System.out.println(usernames.get(index - 1));
        System.out.println(usernames.get(index));
    }
}
