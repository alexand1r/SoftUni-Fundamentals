/**
 * Created by Alec on 14.03.2016 г..
 */
import java.util.Scanner;

public class SumNumbersFrom1ToN {
    public static void main(String args[]){
        Scanner scan = new Scanner(System.in);
        int count = scan.nextInt();
        int sum = 0;

        for (int i = 1; i <= count; i++){
            sum += i;
        }

        System.out.println(sum);
    }
}
