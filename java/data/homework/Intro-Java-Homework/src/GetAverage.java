/**
 * Created by Alec on 14.03.2016 г..
 */
import java.util.Scanner;

public class GetAverage {
    public static void main(String args[]){
        Scanner scan = new Scanner(System.in);
        float a = scan.nextFloat();
        float b = scan.nextFloat();
        float c = scan.nextFloat();
        float result = Average(a, b, c);
        System.out.printf("%.2f", result);
    }

    public static float Average(float a, float b, float c){
        float avg = (a + b + c) / 3;
        return avg;
    }
}
