import java.io.*;
import java.util.Arrays;
import java.util.Locale;

/**
 * Created by Alec on 21.03.2016 г..
 */
public class CountCharacterTypes {

    public static void main(String[] args) {

        Locale.setDefault(Locale.ROOT);
        File file = new File("resources/input2.txt");
        File outputFile = new File("resources/output2.txt");

        try(
                BufferedReader reader = new BufferedReader (new FileReader(file));
        ) {
            while (true) {
                FileWriter fw = new FileWriter(outputFile, true);
                PrintWriter writer = new PrintWriter(fw, true);
                String line = reader.readLine();
                while (line != null){
                    int vowelsCount = 0;
                    int consonantsCount = 0;
                    int punctuationCount = 0;
                    line = line.replace(" ","");
                    //char[] vowels = {'a', 'e', 'o', 'u', 'i'};
                    //char[] punctuation = {'!', '?' , ',', '.'};
                    for (int i = 0; i < line.length(); i++) {
                        char ch = line.charAt(i);
                        if (ch == 'a' || ch == 'o' || ch == 'i' || ch == 'e' || ch == 'u'){
                            vowelsCount++;
                        } else if (ch == '!' || ch == '?' || ch == '.' || ch == ','){
                            punctuationCount++;
                        } else {
                            consonantsCount++;
                        }
                    }
                    String output = "Vowels: " + vowelsCount;
                    String output1 = "Consonants: " + consonantsCount;
                    String output2 = "Punctuation: " + punctuationCount;
                    writer.println(output);
                    writer.println(output1);
                    writer.println(output2);
                    line = reader.readLine();
                }
                writer.close();
                reader.close();
            }
        } catch (FileNotFoundException e) {
            System.out.println("No file .");
        } catch (IOException ioex) {
            System.err.println("Cannot read the file .");
        }
    }
}
