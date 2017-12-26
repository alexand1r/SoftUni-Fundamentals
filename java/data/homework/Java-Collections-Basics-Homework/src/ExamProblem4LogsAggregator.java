import java.util.*;

/**
 * Created by Alec on 25.03.2016 г..
 */
public class ExamProblem4LogsAggregator {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();
        scan.nextLine();

        // Parse the input log files and aggregate them
        TreeMap<String, Integer> durations = new TreeMap<>();
        HashMap<String, TreeSet<String>> ipAddresses = new HashMap<>();
        for (int i = 0; i < n; i++) {
            String logLine = scan.nextLine();
            String[] logTokens = logLine.split(" ");
            String ip = logTokens[0];
            String user = logTokens[1];
            int duration = Integer.parseInt(logTokens[2]);

            // Aggregate the user's sessions durations
            Integer oldDuration = durations.get(user);
            if (oldDuration == null) {
                oldDuration = 0;
            }
            durations.put(user, oldDuration + duration);

            // Collect the IP addresses for the user
            TreeSet<String> ipSet = ipAddresses.get(user);
            if (ipSet == null) {
                ipSet = new TreeSet<>();
            }
            ipSet.add(ip);
            ipAddresses.put(user, ipSet);
        }

        // Print the output in format <user>: <duration> [<IP1>, <IP2>, �]
        for (Map.Entry<String, Integer> userAndDuration : durations.entrySet()) {
            String user = userAndDuration.getKey();
            int duration = userAndDuration.getValue();
            TreeSet<String> ipSet = ipAddresses.get(user);
            System.out.println(user + ": " + duration + " " + ipSet);
        }
    }
}
