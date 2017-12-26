/**
 * Created by Alec on 14.03.2016 г..
 */
import java.util.Scanner;

public class PrintACharacterTriangle {
    public static void main(String args[]) {
        Scanner scan = new Scanner(System.in);
        int count = scan.nextInt();

        for (int i = 0; i <= count; i++){
            for (int j = 1; j <= i; j++) {
                System.out.print((char)(j + 96) + " ");
            }
            System.out.println();
        }

        for (int i = count - 1; i > 0; i--){
            for (int j = 1; j <= i; j++) {
                System.out.print((char)(j + 96) + " ");
            }
            System.out.println();
        }
    }
}
