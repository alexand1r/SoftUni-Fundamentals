import java.io.*;
import java.util.Locale;

/**
 * Created by Alec on 21.03.2016 г..
 */
public class CreateReadAndWriteInFiles {
    private static final String FILE_PATH = "E://softuni/Fundamentals/java/Java-Stream-Exercises/src/users.txt";
    private static final String SAVE_PATH = "E://softuni/Fundamentals/java/Java-Stream-Exercises/src/save.txt";

    public static void main(String[] args) {

        Locale.setDefault(Locale.ROOT);
        File file = new File(FILE_PATH);
        File outputFile = new File(SAVE_PATH);

        try(
                BufferedReader reader = new BufferedReader (new FileReader(file));
        ) {
            while (true) {
                FileWriter fw = new FileWriter(outputFile, true);
                PrintWriter writer = new PrintWriter(fw, true);
                String line = reader.readLine();
                while (line != null){
                    String[] lineArgs = line.split(" ");
                    String username = lineArgs[0];
                    int totalMinutes = 0;
                    for (int i = 1; i < lineArgs.length; i++) {
                        String[] loggedTime = lineArgs[i].split(":");
                        int hours = Integer.parseInt(loggedTime[0]);
                        int minutes = Integer.parseInt(loggedTime[1]);
                        totalMinutes += hours * 60 + minutes;
                    }
                    String output = username + " " + totalMinutes;
                    int days = totalMinutes / 1440;
                    int rest = totalMinutes % 1440;
                    int hour = rest / 60;
                    int min = rest % 60;
                    output += " (" + days + " days, " + hour + " hours, " + min + " minutes)";
                    writer.println(output);
                    line = reader.readLine();
                }
            }
        } catch (IOException ioex) {
                System.err.println("Cannot read the file .");
        }
    }
}
