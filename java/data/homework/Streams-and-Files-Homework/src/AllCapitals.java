import java.io.*;
import java.util.Locale;

/**
 * Created by Alec on 21.03.2016 г..
 */
public class AllCapitals {

    public static void main(String[] args) {

        Locale.setDefault(Locale.ROOT);
        File file = new File("resources/input1.txt");
        File outputFile = new File("resources/output1.txt");

        try(
                BufferedReader reader = new BufferedReader (new FileReader(file));
        ) {
            while (true) {
                FileWriter fw = new FileWriter(outputFile, true);
                PrintWriter writer = new PrintWriter(fw, true);
                String line = reader.readLine();
                while (line != null){
                    String output = line.toUpperCase();
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
