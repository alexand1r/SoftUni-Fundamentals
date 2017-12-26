import java.util.Locale;
import java.util.Scanner;
import java.util.TreeMap;

/**
 * Created by Alec on 08.04.2016 г..
 */
public class Weightlifting {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        int n = Integer.parseInt(scan.nextLine());
        TreeMap<String, TreeMap<String, Long>> players = new TreeMap<>();

        for (int i = 0; i < n; i++) {
            String[] line = scan.nextLine().split(" ");
            String player = line[0];
            String exercise = line[1];
            long kg = Long.parseLong(line[2]);
            if (!players.containsKey(player)) {
                players.put(player, new TreeMap<String, Long>());
                players.get(player).put(exercise, kg);
            } else {
                if (!players.get(player).containsKey(exercise)) {
                    players.get(player).put(exercise, kg);
                } else {
                    long oldKg = players.get(player).get(exercise);
                    players.get(player).put(exercise, (oldKg + kg));
                }
            }
        }

        for (String player : players.keySet()) {
            String result = "";
            System.out.print(player + " : ");
            TreeMap<String, Long> exercises = players.get(player);
            for (String exercise : exercises.keySet()) {
                result += exercise + " - " + exercises.get(exercise) + " kg, ";
            }
            result = result.substring(0, result.length() - 2);
            System.out.print(result);
            System.out.println();
        }
    }
}
