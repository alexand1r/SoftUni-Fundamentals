import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 13.04.2016 г..
 */
public class CollectResources {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        String[] resources = scan.nextLine().split(" ");
        boolean[] itemsFlags = new boolean[resources.length];
        long currentQuantity = 0;
        long maxQuantity = 0;
        int currentPosition;
        int n = scan.nextInt(); scan.nextLine();
        for (int i = 0; i < n; i++) {
            String[] line = scan.nextLine().trim().split("\\s+");
            currentQuantity = 0;
            itemsFlags = new boolean[resources.length];
            int start = Integer.parseInt(line[0]);
            int step = Integer.parseInt(line[1]);
            step %= resources.length;
            currentPosition = start;
            while (!itemsFlags[currentPosition]) {
                String[] resourceData = resources[currentPosition].split("_");
                String resourceType = resourceData[0];
                int quantity;
                if (resourceData.length == 1){
                    quantity = 1;
                } else {
                    quantity = Integer.parseInt(resourceData[1]);
                }
                switch (resourceType) {
                    case "stone":
                    case "gold":
                    case "wood":
                    case "food":
                        currentQuantity += quantity;
                        itemsFlags[currentPosition] = true;
                }
                currentPosition += step;
                currentPosition %= resources.length;
            }
            if (maxQuantity < currentQuantity) {
                maxQuantity = currentQuantity;
            }
        }
        System.out.println(maxQuantity);
    }
}
