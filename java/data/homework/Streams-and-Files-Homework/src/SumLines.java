import java.io.*;
import java.util.Locale;

/**
 * Created by Alec on 21.03.2016 г..
 */
public class SumLines {
    private static final String FILE_PATH = "resources/input.txt";
    private static final String SAVE_PATH = "resources/output.txt";

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
                    int sum = 0;
                    for (int i = 0; i < line.length(); i++) {
                        sum += line.charAt(i);
                    }
                    String output = sum + " ";
                    writer.println(output);
                    line = reader.readLine();
                }
                writer.close();
                reader.close();
            }
        } catch (IOException ioex) {
            System.err.println("Cannot read the file .");
        }
    }
}
