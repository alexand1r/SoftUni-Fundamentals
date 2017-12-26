import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 19.03.2016 г..
 */
public class DozensOfEggs {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        int count = 0;
        for (int i = 0; i < 7; i++) {
            String[] input = scan.nextLine().split(" ");
            int n = Integer.parseInt(input[0]);
            String type = input[1];
            if (type.equals("dozens")){
                count += n * 12;
            } else if (type.equals("eggs")) {
                count += n;
            }
        }
        //System.out.println(count/12 + " dozens + " + count%12 + " eggs");
        System.out.printf("%d dozens + %d eggs", count / 12, count % 12);
    }
}
