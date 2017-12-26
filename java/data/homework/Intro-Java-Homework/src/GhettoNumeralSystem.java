/**
 * Created by Alec on 14.03.2016 г..
 */
import java.util.Scanner;

public class GhettoNumeralSystem {
    public static void main(String args[]){
        Scanner scan = new Scanner(System.in);
        String str = scan.next();
        for (int i = 0; i < str.length(); i++){
            switch(str.charAt(i)){
                case '0':
                    System.out.print("Gee");
                    break;
                case '1':
                    System.out.print("Bro");
                    break;
                case '2':
                    System.out.print("Zuz");
                    break;
                case '3':
                    System.out.print("Ma");
                    break;
                case '4':
                    System.out.print("Duh");
                    break;
                case '5':
                    System.out.print("Yo");
                    break;
                case '6':
                    System.out.print("Dis");
                    break;
                case '7':
                    System.out.print("Hood");
                    break;
                case '8':
                    System.out.print("Jam");
                    break;
                case '9':
                    System.out.print("Mack");
                    break;
                default:
                    System.out.println("Wrong Input!");
                    break;
            }
        }
    }
}
