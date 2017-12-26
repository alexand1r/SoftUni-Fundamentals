import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 19.03.2016 г..
 */
public class AddingAngles {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        int n = Integer.parseInt(scan.nextLine());
        int count = 0;
        int result = 0;
        String[] angles = scan.nextLine().split(" ");
        for (int i = 0; i < angles.length; i++) {
            for (int j = i + 1; j < angles.length; j++) {
                for (int k = j + 1; k < angles.length; k++) {
                    result = Integer.parseInt(angles[i]) + Integer.parseInt(angles[j]) + Integer.parseInt(angles[k]);
                    if (result % 360 == 0){
                        System.out.printf("%s + %s + %s = %d degrees\n", angles[i], angles[j], angles[k], result);
                        count++;
                    }
                }
            }
        }
        if (count == 0){
            System.out.println("No");
        }
    }
}
