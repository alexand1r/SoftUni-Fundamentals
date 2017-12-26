import java.util.Scanner;

/**
 * Created by Alec on 28-Jul-16.
 */
public class compareCharArrays {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String str1 = scan.nextLine();
        str1 = str1.replace(" ", "");
        String str2 = scan.nextLine();
        str2 = str2.replace(" ", "");

        int max = Math.max(str1.length(), str2.length());

        if (max == str1.length() && str1.length() != str2.length()) {
            System.out.println(str2);
            System.out.println(str1);
        } else if (max == str2.length() && str1.length() != str2.length()) {
            System.out.println(str1);
            System.out.println(str2);
        } else {
            for (int i = 0; i < max; i++) {
                if (str1.charAt(i) > str2.charAt(i)) {
                    System.out.println(str2);
                    System.out.println(str1);
                    break;
                } else if (str1.charAt(i) < str2.charAt(i)){
                    System.out.println(str1);
                    System.out.println(str2);
                    break;
                }
            }
        }
    }
}
