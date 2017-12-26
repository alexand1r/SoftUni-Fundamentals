import java.util.*;
import java.util.function.Predicate;
import java.util.stream.Collectors;

/**
 * Created by Alec on 29.03.2016 г..
 */
public class Problem1FilterArray {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);

        String[] input = scan.nextLine().split(" ");

    //--- first way ---
        List<String> list;
        list = Arrays.stream(input)
                .filter(p -> p.length() > 3)
                .collect(Collectors.toList());

        for (String s : list) {
            System.out.print(s + " ");
        }

        System.out.println();
    //--- second way ---
        String line = Arrays.stream(input)
                .filter(p -> p.length() > 3)
                .collect(Collectors.joining(" "));

        System.out.println(line);

        System.out.println();
    //--- third way ---
        Arrays.stream(input).map(p -> {
            if (p.length() > 3) {
                return p + " ";
            }
            return "";
        }).forEach(System.out::print);

        System.out.println();
    //--- forth way---
        for (String s : input) {
            if (isLenghtBiggerThan3().test(s)) {
                System.out.print(s + " ");
            }
        }

        if (Arrays.stream(input)
                .filter(p -> p.length() > 3)
                .findAny()
                .equals(Optional.empty())) {
            System.out.println("(empty)");
        }
    }

    public static Predicate<String> isLenghtBiggerThan3() {
        return p -> p.length() > 3;
    }
}
