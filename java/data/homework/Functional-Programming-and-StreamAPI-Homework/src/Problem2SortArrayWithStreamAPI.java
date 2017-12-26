import java.util.*;
import java.util.stream.Collectors;

/**
 * Created by Alec on 29.03.2016 г..
 */
public class Problem2SortArrayWithStreamAPI {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);

        String[] input = scan.nextLine().split(" ");
        String line = scan.nextLine();

        if (line.equals("Ascending")) {
            List<Integer> list = Arrays.stream(input)
                    .sorted()
                    .map(Integer::parseInt)
                    .collect(Collectors.toList());

            for (Integer integer : list) {
                System.out.print(integer + " ");
            }
        } else {
            List<Integer> list = Arrays.stream(input)
                    .sorted((x, y) -> y.compareTo(x))
                    .map(Integer::parseInt)
                    .collect(Collectors.toList());

            for (Integer integer : list) {
                System.out.print(integer + " ");
            }
        }
    }
}
