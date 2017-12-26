import com.sun.org.apache.xpath.internal.SourceTree;

import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Alec on 21.04.2016 г..
 */
public class OlympicsAreComing {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        LinkedHashMap<String, Integer> wins = new LinkedHashMap<>();
        LinkedHashMap<String, LinkedHashMap<String, Integer>> countries = new LinkedHashMap<>();
        String command = scan.nextLine();
        Pattern pattern = Pattern.compile("([a-zA-Z]+)\\s*\\|\\s*([a-zA-Z]+)");
        while (!command.equals("report")) {
            Matcher matcher = pattern.matcher(command);
            while (matcher.find()) {
                String country = matcher.group(2);
                String player = matcher.group(1);

                if (!countries.containsKey(country)) {
                    countries.put(country, new LinkedHashMap<String, Integer>());
                    wins.put(country, 0);
                }
                if (!countries.get(country).containsKey(player)) {
                    countries.get(country).put(player, 0);
                }
                int oldValue = countries.get(country).get(player);
                int winsCounter = wins.get(country);
                countries.get(country).put(player, oldValue + 1);
                wins.put(country, winsCounter + 1);
            }

            command = scan.nextLine();
        }

        wins.entrySet().stream()
                .sorted((s1, s2) -> s2.getValue().compareTo(s1.getValue()))
                .forEach(e -> {
                    System.out.print(e.getKey() + " ");
                    for (Map.Entry<String, LinkedHashMap<String, Integer>> entry : countries.entrySet()) {
                        if (e.getKey().equals(entry.getKey())) {
                            ArrayList<Integer> list = new ArrayList<Integer>();
                            LinkedHashMap<String, Integer> players = countries.get(entry.getKey());
                            int sum = 0;
                            for (String player : players.keySet()) {
                                sum += players.get(player);
                            }
                            System.out.printf("(%d participants): %d wins%n", sum, e.getValue());
                        }
                    }
        });
    }
}
