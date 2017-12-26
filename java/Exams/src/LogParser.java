import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Alec on 13.04.2016 г..
 */
public class LogParser {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        Pattern pattern = Pattern
                .compile("\\[\"(.*?)\"\\].*\\[\"(.*?)\"\\].*\\[\"(.*?)\"\\]");
        TreeMap<String, Integer> projects = new TreeMap<>();
        HashMap<String, ArrayList<String>> warnings = new HashMap<>();
        HashMap<String, ArrayList<String>> criticals = new HashMap<>();


        while (true) {
            String command = scan.nextLine();
            if (command.equals("END")) {
                break;
            }

            Matcher matcher = pattern.matcher(command);
            if (!matcher.find()) {
                continue;
            }
            String project = matcher.group(1);
            String type = matcher.group(2);
            String message = matcher.group(3);

            if (!projects.containsKey(project)) {
                projects.put(project, 0);
                criticals.put(project, new ArrayList<>());
                warnings.put(project, new ArrayList<>());
            }

            int incrementor = projects.get(project) + 1;
            projects.put(project, incrementor);

            if (type.equals("Warning")) {
                warnings.get(project).add(message);
            } else {
                criticals.get(project).add(message);
            }
        }

        projects.entrySet().stream().sorted((pair1, pair2) ->
                        Integer.compare(pair2.getValue(), pair1.getValue()))
                .forEach(entry -> {
                    String name = entry.getKey();
                    System.out.printf("%s:%n", name);
                    System.out.printf("Total Errors: %d%n", entry.getValue());

                    System.out.printf("Critical: %d%n", criticals.get(name).size());
                    System.out.printf("Warnings: %d%n", warnings.get(name).size());

                    System.out.println("Critical Messages:");
                    ArrayList<String> criticalsList = criticals.get(name);
                    criticalsList.sort(Comparator.<String>naturalOrder());
                    criticalsList.sort((s1, s2) -> Integer.compare(s1.length(), s2.length()));
                    for (String msg : criticalsList) {
                        System.out.printf("--->%s%n", msg);
                    }
                    if (criticalsList.size() == 0) {
                        System.out.println("--->None");
                    }

                    System.out.println("Warning Messages:");
                    ArrayList<String> warningsList = warnings.get(name);
                    warningsList.sort(Comparator.<String>naturalOrder());
                    warningsList.sort((s1, s2) -> Integer.compare(s1.length(), s2.length()));
                    for (String msg : warningsList) {
                        System.out.printf("--->%s%n", msg);
                    }
                    if (warningsList.size() == 0) {
                        System.out.println("--->None");
                    }

                    System.out.println();
        });
    }
}
