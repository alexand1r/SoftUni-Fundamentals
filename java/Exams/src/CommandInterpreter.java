import java.util.Arrays;
import java.util.Collections;
import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 21.04.2016 г..
 */ //failure
public class CommandInterpreter {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);

        String[] input = scan.nextLine().split("\\s+");

        String command = scan.nextLine();
        while (!command.equals("end")) {
            String[] tokens = command.split("\\s+");
            int startIndex = 0;
            int count = 0;
            switch (tokens[0]) {
                case "reverse":
                    startIndex = Integer.parseInt(tokens[2]);
                    count = Integer.parseInt(tokens[4]);
                    if (startIndex < 0 || startIndex >= input.length || count < 0) {
                        System.out.println("Invalid input parameters.");
                        continue;
                    }

                    reverse(input, startIndex, count);
                    break;
                case "sort":
                    startIndex = Integer.parseInt(tokens[2]);
                    count = Integer.parseInt(tokens[4]);
                    if (startIndex < 0 || startIndex >= input.length || count < 0) {
                        System.out.println("Invalid input parameters.");
                        continue;
                    }

                    sort(input, startIndex, count);
                    break;
                case "rollLeft":
                    count = Integer.parseInt(tokens[1]);
                    if (count < 0) {
                        System.out.println("Invalid input parameters.");
                        continue;
                    }

                    rollLeft(input, count);
                    break;
                case "rollRight":
                    count = Integer.parseInt(tokens[1]);
                    if (count < 0) {
                        System.out.println("Invalid input parameters.");
                        continue;
                    }

                    rollRight(input, count);
                    break;
                default: break;
            }

            command = scan.nextLine();
        }

        System.out.println(Arrays.toString(input));
    }

    private static void rollLeft(String[] arr, int count) {
        for (int i = 0; i < count; i++) {
            Collections.rotate(Arrays.asList(arr), -1);
        }

    }

    private static void rollRight(String[] arr, int count) {
        for (int i = 0; i < count; i++) {
            Collections.rotate(Arrays.asList(arr), 1);
        }
    }

    private static void sort(String[] arr, int startIndex, int count) {
        int k = 0;
        for (int i = startIndex + count; i >= 0; i--) {
            for (int j = 0; j < startIndex + count - 1; j++) {
                k = j + 1;
                if (Integer.parseInt(arr[j]) > Integer.parseInt(arr[k])) {
                    swapNumbers(j, k, arr);
                }
            }
        }
    }

    private static void swapNumbers(int i, int j, String[] array) {
        String temp = "";
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    private static void reverse(String[] arr, int startIndex, int count) {
        for (int i = 0; i < (startIndex + count) / 2 - 1; i++) {
            String temp = arr[startIndex + i];
            arr[startIndex + i] = arr[startIndex + count - 1 - i];
            arr[startIndex + count - 1 - i] = temp;
        }
    }
}
