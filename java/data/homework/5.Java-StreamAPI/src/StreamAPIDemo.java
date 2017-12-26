import java.util.Arrays;
import java.util.List;
import java.util.Locale;
import java.util.Scanner;
import java.util.stream.Collectors;

/**
 * Created by Alec on 29.03.2016 г..
 */
public class StreamAPIDemo {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        String[] input = scan.nextLine().split(" ");

        List<Integer> list = Arrays.stream(input)
                .filter(StreamAPIDemo::isNumber)
                .map(Integer::parseInt)
                .collect(Collectors.toList());

        int sum = list.stream().reduce((x, y) -> x + y).get();
        int sumOther = list.stream().mapToInt(Integer::intValue).sum();
        int sumOther2 = list.stream().collect(Collectors.summingInt(Integer::intValue));
        System.out.println(sum);
        System.out.println(sumOther);
        System.out.println(sumOther2);
    }

    private static boolean isNumber(String str) {
        for (char ch : str.toCharArray()) {
            if (!Character.isDigit(ch)) {
                return false;
            }
        }

        return true;
    }
}
