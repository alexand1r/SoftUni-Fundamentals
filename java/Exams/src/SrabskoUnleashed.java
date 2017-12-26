import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import java.util.stream.Collectors;

/**
 * Created by Alec on 17.04.2016 г..
 */
public class SrabskoUnleashed {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        LinkedHashMap<String, LinkedHashMap<String,Long>> venues = new LinkedHashMap<>();

        Pattern pattern = Pattern.compile("(.*?)\\s@(.*?)\\s(\\d+)\\s(\\d+)");

        String command = scan.nextLine();
        while (!command.equals("End")) {
            Matcher matcher = pattern.matcher(command);
            while (matcher.find()) {
                String singer = matcher.group(1);
                String venue = matcher.group(2);
                long ticketsPrice = Integer.parseInt(matcher.group(3));
                long ticketsCount = Integer.parseInt(matcher.group(4));

                if (!venues.containsKey(venue)) {
                    venues.put(venue, new LinkedHashMap<>());
                }

                if (!venues.get(venue).containsKey(singer)) {
                    venues.get(venue).put(singer, 0L);
                }

                long oldAmount = venues.get(venue).get(singer);
                venues.get(venue).put(singer, oldAmount + (ticketsCount * ticketsPrice));

            }

            command = scan.nextLine();
        }

//        for (String venue : venues.keySet()) {
//            System.out.println(venue);
//
//            LinkedHashMap<String, Long> singers = venues.get(venue);
//
//            for (String singer : singers.keySet()) {
//                long totalMoney = singers.get(singer);
//                System.out.printf("#  %s -> %d%n", singer, totalMoney);
//            }
//        }

        for (Map.Entry<String,LinkedHashMap<String,Long>> v : venues.entrySet()) {
            System.out.println(v.getKey());

            v.getValue().entrySet().stream()
                    .sorted((s1, s2) -> s2.getValue().compareTo(s1.getValue()))
                    .forEach((entry) -> {
                        System.out.printf("#  %s -> %d%n", entry.getKey(), entry.getValue());
                    });
        }
    }
}
