import java.util.*;

/**
 * Created by Alec on 25.03.2016 г..
 */
public class Problem9MostFrequentWord {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        int max = 0;

        String[] input = scan.nextLine().toLowerCase().split("\\W+");

        Map<String, Integer> wordsCount = new TreeMap<String, Integer>();

        for (String word : input) {
            Integer count = wordsCount.get(word);
            if (count == null) {
                count = 0;
            }
            if (count + 1 > max) {
                max = count + 1;
            }
            wordsCount.put(word, count+1);
        }

        for (Map.Entry<String, Integer> entry : wordsCount.entrySet()) {
            if (entry.getValue() == max) {
                System.out.println(entry.getKey() + " - > " + entry.getValue()
                        + " times");
            }
        }
    }
}
