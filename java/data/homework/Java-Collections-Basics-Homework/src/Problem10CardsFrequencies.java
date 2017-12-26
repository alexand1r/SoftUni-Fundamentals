import java.util.LinkedHashMap;
import java.util.Locale;
import java.util.Map;
import java.util.Scanner;

/**
 * Created by Alec on 25.03.2016 г..
 */
public class Problem10CardsFrequencies {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);

        String[] input = scan.nextLine().split("\\W+");

        Map<String, Integer> wordCounterMap = new LinkedHashMap<String, Integer>();

        Integer oldValue = 0;
        for (String wordCount : input) {
            oldValue = wordCounterMap.get(wordCount);
            if (oldValue == null)
                oldValue = 0;// first time is always null

            wordCounterMap.put(wordCount, oldValue + 1);

        }

        for (Map.Entry<String, Integer> entry : wordCounterMap.entrySet()) {
            System.out.printf("%s - > %.2f%%", (String) entry.getKey(),
                    (((double) entry.getValue() / input.length) * 100));
            System.out.println();
        }
    }
}
