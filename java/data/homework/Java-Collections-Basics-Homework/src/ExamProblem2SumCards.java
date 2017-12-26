import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 25.03.2016 г..
 */
public class ExamProblem2SumCards {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        String[] hand = scan.nextLine().split("[S DCH]+");
        int[] cards = new int[hand.length];
        for (int i = 0; i < cards.length; i++) {
            switch (hand[i]){
                case "A": hand[i] = "15"; break;
                case "J": hand[i] = "12"; break;
                case "Q": hand[i] = "13"; break;
                case "K": hand[i] = "14"; break;
            }
            cards[i] = Integer.parseInt(hand[i]);
        }
        int sum = 0;
        int temp = 1;
        int prevValue = -1;
        for (int i = 0; i < cards.length; i++) {
            if (cards[i] == prevValue){
                temp++;
            } else {
                temp = 1;
            }
            sum = sum + cards[i];
            if (temp == 2){
                sum = sum + 2 * cards[i];
            }
            if (temp > 2) {
                sum = sum + cards[i];
            }
            prevValue = cards[i];
        }
        System.out.println(sum);
    }
}
