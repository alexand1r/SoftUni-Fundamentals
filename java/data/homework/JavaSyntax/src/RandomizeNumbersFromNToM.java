import java.util.ArrayList;
import java.util.Locale;
import java.util.Random;
import java.util.Scanner;

/**
 * Created by Alec on 17.03.2016 г..
 */
public class RandomizeNumbersFromNToM {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();
        int m = scan.nextInt();
        int max, min;
        if (n > m){
            max = n;
            min = m;
        } else {
            min = n;
            max = m;
        }

        ArrayList<Integer> list = new ArrayList<Integer>();
        for(int i = min; i <= max; i++) {
            list.add(i);
        }

        Random rand = new Random();
        while(list.size() > 0) {
            int index = rand.nextInt(list.size());
            System.out.print(list.get(index) + " ");
            list.remove(index);
        }
    }
}
