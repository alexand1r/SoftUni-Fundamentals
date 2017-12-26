import java.util.LinkedHashMap;
import java.util.Locale;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Alec on 06.04.2016 г..
 */
public class UserLogs {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        String command = scan.nextLine();
        TreeMap<String, LinkedHashMap<String, Integer>> usernames = new TreeMap<>();

        while (!command.equals("end")) {
            Pattern ipPat = Pattern.compile("IP=(\\d+\\.\\d+\\.\\d+\\.\\d+)|IP=(\\w+:\\w+:\\w+:\\w+:\\w+:\\w+:\\w+:\\w+)");
            Matcher match = ipPat.matcher(command);

            Pattern usernamePat = Pattern.compile("user=(\\w+)");
            Matcher usernameMatch = usernamePat.matcher(command);

            while (match.find() && usernameMatch.find()) {
                String ip = match.group(1) != null ? match.group(1) : match.group(2);
                String username = usernameMatch.group(1);

                if (!usernames.containsKey(username)) {
                    usernames.put(username, new LinkedHashMap<>());
                    usernames.get(username).put(ip, 1);
                } else {
                    if (!usernames.get(username).containsKey(ip)) {
                        usernames.get(username).put(ip, 1);
                    } else {
                        int ipCount = usernames.get(username).get(ip);
                        usernames.get(username).put(ip, ++ipCount);
                    }
                }
            }
            command = scan.nextLine();
        }

        for (String user : usernames.keySet()) {
            System.out.println(user + ":");
            String ipOutput = "";
            for (String ip : usernames.get(user).keySet()) {
                ipOutput += String.format("%s => %d, ", ip, usernames.get(user).get(ip));
            }
            ipOutput = ipOutput.substring(0, ipOutput.length()-2)+'.';
            System.out.println(ipOutput);
        }
    }
}
