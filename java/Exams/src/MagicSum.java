import java.util.ArrayList;
import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 02.04.2016 г..
 */
public class MagicSum {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        ArrayList<Integer> inputNumbers = new ArrayList<>();
        int divider = Integer.parseInt(scan.nextLine());

        while (true) {
            String inputLine = scan.nextLine();
            if (inputLine.equals("End")) {
                break;
            }
            inputNumbers.add(Integer.parseInt(inputLine));
        }

        long maxSum = Integer.MIN_VALUE;
        String result = "";
        int resultCounter = 0;
        for (int i = 0; i < inputNumbers.size(); i++) {
            for (int i1 = i+1; i1 < inputNumbers.size(); i1++) {
                for (int i2 =i1 +1; i2 < inputNumbers.size(); i2++) {
                    long sum = inputNumbers.get(i) + inputNumbers.get(i1) + inputNumbers.get(i2);

                    if (sum % divider == 0 && sum > maxSum) {
                        maxSum = sum;
                        result = String.format("(%d + %d + %d) %% %d = 0",
                                inputNumbers.get(i), inputNumbers.get(i1), inputNumbers.get(i2), divider);
                        resultCounter++;
                    }
                }
            }
        }

        if (resultCounter == 0) {
            System.out.println("No");
        } else {
            System.out.println(result);
        }
    }
}
