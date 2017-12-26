import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Alec on 08.05.2016 г..
 */
public class RoyalAccounting {
    static LinkedHashMap<String, Double> monthlyPayment = new LinkedHashMap<>();
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);

        LinkedHashMap<String, LinkedHashMap<String, Integer>> teams= new LinkedHashMap<>();

        LinkedHashMap<String, Double> dailyIncome = new LinkedHashMap<>();

        Pattern pattern = Pattern.compile("^([a-zA-Z]+);(-*[0-9]+);(-*[0-9]+(\\.*[0-9]+)*);([a-zA-Z]+)$");
        String command = scan.nextLine();
        while (!command.equals("Pishi kuf i da si hodim")) {
            Matcher matcher = pattern.matcher(command);
            while (matcher.find()) {
                String employee = matcher.group(1);
                int workHoursPerDay = Integer.parseInt(matcher.group(2));
                double dailyPayment = Double.parseDouble(matcher.group(3));
                String team = matcher.group(5);

                if (!teams.containsKey(team)) {
                    teams.put(team, new LinkedHashMap<String, Integer>());
                }
                if (!teams.get(team).containsKey(employee)) {
                    teams.get(team).put(employee, workHoursPerDay);
                    double monthly = ((dailyPayment * workHoursPerDay) / (double)24) * (double)30;
                    monthlyPayment.put(employee, monthly);
                    double daily = (dailyPayment * workHoursPerDay) / (double)24;
                    dailyIncome.put(employee, daily);
                }
            }

            command = scan.nextLine();
        }

        teams.entrySet().stream()
                .sorted((r1, r2) -> Double.compare(monthlyPayment.get(r2.getKey())
                        , monthlyPayment.get(r1.getKey()))).forEach(entrys -> {
            System.out.println("Team - " + entrys.getKey());
            entrys.getValue().entrySet().stream()
                    .sorted((m1, m2) -> Double.compare(dailyIncome.get(m2.getKey())
                    , dailyIncome.get(m1.getKey())))
                    .sorted((m1, m2) -> Integer.compare(m2.getValue()
                            , m1.getValue()))
                    .forEach(k -> {

                        System.out.printf("$$$%s - %d - %.6f%n"
                                , k.getKey(), k.getValue(), dailyIncome.get(k.getKey()));

                    });
        });
    }
}

