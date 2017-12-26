import java.util.*;

/**
 * Created by Alec on 02.04.2016 г..
 */
public class Nuts {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        TreeMap<String, TreeMap<String, Integer>> companies = new TreeMap<>();
        int n = scan.nextInt(); scan.nextLine();
        for (int i = 0; i < n; i++) {
            String[] input = scan.nextLine().split(" ");
            String company = input[0];
            String nuts = input[1];
            int kg = Integer.parseInt(input[2].substring(0, input[2].length() - 2));
            if (!companies.containsKey(company)) {
                companies.put(company, new TreeMap<String, Integer>());
            }
            TreeMap<String, Integer> amount = companies.get(company);
            int oldAmount = 0;
            if (amount.containsKey(nuts)) {
                oldAmount = amount.get(nuts);
            }
            amount.put(nuts, oldAmount + kg);
        }

        for (String company : companies.keySet()) {
            System.out.print(company + ": ");
            TreeMap<String, Integer> amount = companies.get(company);
            boolean first = true;
            for (Map.Entry<String, Integer> pair: amount.entrySet()) {
                if (!first) {
                    System.out.print(", ");
                }
                first = false;
                String nuts = pair.getKey();
                int kg = pair.getValue();
                System.out.print(nuts + "-" + kg + "kg");
            }
            System.out.println();
        }

    }
}
