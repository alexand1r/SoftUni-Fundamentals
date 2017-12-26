import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Alec on 13.04.2016 г..
 */
public class Events {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        HashMap<String, TreeMap<String, ArrayList<String>>> cities = new HashMap<>();
        Pattern pattern = Pattern.compile("^#([A-Za-z]+):\\s*@([A-Za-z]+)\\s*(([0-1]?[0-9]|[2][0-3]):([0-5][0-9]))$");
        int n = scan.nextInt(); scan.nextLine();
        for (int i = 0; i < n; i++) {
            String line = scan.nextLine();
            Matcher matcher = pattern.matcher(line);
            String city = "";
            String person = "";
            String time = "";
            while (matcher.find()) {
                person = matcher.group(1);
                city = matcher.group(2);
                time = matcher.group(3);
                if (!cities.containsKey(city)) {
                    cities.put(city, new TreeMap<>());
                }
                if (!cities.get(city).containsKey(person)) {
                    cities.get(city).put(person, new ArrayList<>());
                }
                cities.get(city).get(person).add(time);
            }
        }

        String[] wantedCities = scan.nextLine().split(",");
        Arrays.sort(wantedCities);
        for (String wantedCity : wantedCities) {
            if (cities.containsKey(wantedCity)) {
                System.out.println(wantedCity + ":");
                String[] names = new String[cities.get(wantedCity).size()];
                cities.get(wantedCity).keySet().toArray(names);
                int counter = 1;
                for (String name : names) {
                    System.out.printf("%d. %s -> ", counter, name);
                    List<String> times = cities.get(wantedCity).get(name);
                    times.sort(String::compareTo);
                    String str = times.toString().replace('[','\0').replace(']','\0').trim();
                    System.out.print(str);
                    System.out.println();
                    counter++;
                }
            }
        }
    }
}
