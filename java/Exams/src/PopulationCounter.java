import java.util.Locale;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import java.util.stream.Collectors;

/**
 * Created by Alec on 21.04.2016 г..
 */
public class PopulationCounter {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        TreeMap<String, Long> count = new TreeMap<>();
        TreeMap<String, TreeMap<String, Long>> countries = new TreeMap<>();
        Pattern pattern = Pattern.compile("([a-zA-Z ]+)\\|([a-zA-Z ]+)\\|([0-9]+)");
        String command = scan.nextLine();
        while (!command.equals("report")) {
            Matcher matcher = pattern.matcher(command);
            while (matcher.find()) {
                String country = matcher.group(2);
                String city = matcher.group(1);
                long population = Integer.parseInt(matcher.group(3));

                if (!countries.containsKey(country)) {
                    countries.put(country, new TreeMap<String, Long>());
                    count.put(country, 0L);
                }
                long oldCount = count.get(country);
                countries.get(country).put(city, population);
                count.put(country, oldCount + population );
            }

            command = scan.nextLine();
        }

        count.entrySet().stream()
                .sorted((s1, s2) -> s2.getValue().compareTo(s1.getValue()))
                .forEach(e -> {
                    System.out.printf("%s (total population: %d)%n", e.getKey(), e.getValue());

                    for (Map.Entry<String,TreeMap<String,Long>> countriesSet : countries.entrySet()) {
                        if (e.getKey().equals(countriesSet.getKey())) {
                            countriesSet.getValue().entrySet().stream()
                                    .sorted((s1, s2) -> s2.getValue().compareTo(s1.getValue()))
                                    .forEach((entry) -> {
                                        System.out.printf("=>%s: %d%n", entry.getKey(), entry.getValue());
                                    });
                        }
                    }
                });
    }
}
