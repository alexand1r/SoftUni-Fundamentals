import java.util.Locale;
import java.util.Scanner;
/**
 * Created by Alec on 18.03.2016 г..
 */
public class GetFirstOddOrEvenElements {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);

        String[] input = scan.nextLine().split(" ");
        String[] getn = scan.nextLine().split(" ");
        result(input, getn);

    }
    public static void result(String[] input, String[] getn){
        int count = Integer.parseInt(getn[1]);
        String type = getn[2];

        for (int i = 0; i < input.length; i++) {
            if (count > 0){
                if (type.equals("odd")) {
                    if (Integer.parseInt(input[i]) % 2 != 0){
                        System.out.print(input[i] + " ");
                        count--;
                    }
                } else if (type.equals("even")) {
                    if (Integer.parseInt(input[i]) % 2 == 0) {
                        System.out.print(input[i] + " ");
                        count--;
                    }
                }
            }
        }
    }
}
