import java.util.ArrayList;
import java.util.Arrays;
import java.util.Locale;
import java.util.Scanner;
import java.util.stream.Collectors;

/**
 * Created by Alec on 15.04.2016 г..
 */
public class ArrayManipulator {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        String[] input = scan.nextLine().split(" ");
        int[] nums = new int[input.length];
        for (int i = 0; i < input.length; i++) {
            nums[i] = Integer.parseInt(input[i]);
        }
        String inputArgs = scan.nextLine();
        while (!inputArgs.equals("end")) {
            String[] tokens = inputArgs.split(" ");
            String command = tokens[0];
            switch (command){
                case "exchange":
                    int index = Integer.parseInt(tokens[1]);
                    if (index < 0 || index >= nums.length) {
                        System.out.println("Invalid index");
                        break;
                    }
                    nums = exchangeArr(nums, index);
                    break;
                case "max":
                    System.out.println(getMax(nums, tokens[1]));
                    break;
                case "min":
                    System.out.println(getMin(nums, tokens[1]));
                    break;
                case "first":
                    System.out.println(getFirst(nums, Integer.parseInt(tokens[1]), tokens[2]));
                    break;
                case "last":
                    System.out.println(getLast(nums, Integer.parseInt(tokens[1]), tokens[2]));
                    break;
            }

            inputArgs = scan.nextLine();
        }
        System.out.println(Arrays.toString(nums));

    }

    private static int[] exchangeArr(int[] arr, int steps) {
        int[] tempList = new int[arr.length];
        for (int i = 0; i < tempList.length; i++) {
            tempList[i] = arr[(steps + i + 1) % arr.length];
        }
        return tempList;
    }

    private static String getMin(int[] arr, String parity) {
        int remainder = parity.equals("odd") ? 1 : 0;
        int max = Integer.MAX_VALUE;
        int index = -1;
        for (int i = 0; i < arr.length; i++) {
            int current = arr[i];
            if (current % 2 == remainder && current <= max) {
                index = i;
                max = current;
            }
        }

        return index < 0 ? "No matches" : Integer.toString(index);
    }

    private static String getMax(int[] arr, String parity) {
        int remainder = parity.equals("odd") ? 1 : 0;
        int max = Integer.MIN_VALUE;
        int index = -1;
        for (int i = 0; i < arr.length; i++) {
            int current = arr[i];
            if (current % 2 == remainder && current >= max) {
                index = i;
                max = current;
            }
        }

        return index < 0 ? "No matches" : Integer.toString(index);
    }

    private static String getFirst(int arr[], int count, String parity) {
        ArrayList<Integer> tempList = new ArrayList<>();
        int remainder = parity.equals("odd") ? 1 : 0;

        if (count > arr.length) {
            System.out.println("Invalid count");
        }

        for (int i = 0; i < arr.length; i++) {
            int current = arr[i];
            if (current % 2 == remainder) {
                tempList.add(current);
            }
            if (tempList.size() >= count) {
                break;
            }
        }

        return "[" +
                String.join(", ", tempList.stream()
                .map(e -> Integer.toString(e))
                .collect(Collectors.toList())) + "]";
    }

    private static String getLast(int arr[], int count, String parity) {
        ArrayList<Integer> tempList = new ArrayList<>();
        int remainder = parity.equals("odd") ? 1 : 0;

        if (count > arr.length) {
            System.out.println("Invalid count");
        }

        for (int i = arr.length - 1; i >= 0; i--) {
            int current = arr[i];
            if (current % 2 == remainder) {
                tempList.add(0, current);
            }

            if (tempList.size() >= count){
                break;
            }
        }

        return "[" +
                String.join(", ", tempList.stream()
                        .map(e -> Integer.toString(e))
                        .collect(Collectors.toList())) + "]";
    }
}
