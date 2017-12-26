import java.lang.reflect.Array;
import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import java.util.stream.Collectors;

/**
 * Created by Alec on 08.05.2016 г..
 */
public class RoyalFlush {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);

        int count = 0;
        int n = scan.nextInt(); scan.nextLine();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++) {
            sb.append(scan.nextLine());
        }

        String allHands = sb.toString();
        Pattern cardFace = Pattern.compile("([\\dJQKA]+)");
        Pattern cardSuits = Pattern.compile("([s|h|c|d])");

        ArrayList<String> cards = new ArrayList<>();
        ArrayList<String> suits = new ArrayList<>();

        Matcher cardFaceM = cardFace.matcher(allHands);
        while (cardFaceM.find()) {
            cards.add(cardFaceM.group(1));
        }
        Matcher cardSuitM = cardSuits.matcher(allHands);
        while (cardSuitM.find()) {
            suits.add(cardSuitM.group(1));
        }

        ArrayList<String> spades = new ArrayList<>();
        ArrayList<String> hearts = new ArrayList<>();
        ArrayList<String> diamonds = new ArrayList<>();
        ArrayList<String> clubs = new ArrayList<>();

        for (int card = 0, suit = 0; card < cards.size() && suit < suits.size(); card++, suit++) {
            String cardSuit = suits.get(suit);
            String currentCard = cards.get(card);
            switch (currentCard) {
                case "J": currentCard = "11";
                    break;
                case "Q": currentCard = "12";
                    break;
                case "K": currentCard = "13";
                    break;
                case "A": currentCard = "14";
                default: break;
            }
            if (currentCard.equals("10") || currentCard.equals("11") || currentCard.equals("12")
                    ||currentCard.equals("13") || currentCard.equals("14")) {
                switch (cardSuit) {
                    case "s":
                        if (spades.contains(currentCard)){
                            spades.clear();
                        } else {
                            spades.add(currentCard);
                        }
                        ArrayList<Integer> facess = new ArrayList<>();
                        for (String spade : spades) {
                            facess.add(Integer.parseInt(spade));
                        }
                        int maxs = Integer.MIN_VALUE;
                        for (int i = 0; i < facess.size(); i++) {
                            if (facess.get(i) > maxs) {
                                maxs = facess.get(i);
                            }
                        }
                        if (maxs != Integer.parseInt(currentCard)) {
                            spades.clear();
                        }
                        break;
                    case "h":
                        if (hearts.contains(currentCard)){
                            hearts.clear();
                        } else {
                            hearts.add(currentCard);
                        }
                        ArrayList<Integer> facesh = new ArrayList<>();
                        for (String heart : hearts) {
                            facesh.add(Integer.parseInt(heart));
                        }
                        int maxh = Integer.MIN_VALUE;
                        for (int i = 0; i < facesh.size(); i++) {
                            if (facesh.get(i) > maxh) {
                                maxh = facesh.get(i);
                            }
                        }
                        if (maxh != Integer.parseInt(currentCard)) {
                            hearts.clear();
                        }
                        break;
                    case "d":
                        if (diamonds.contains(currentCard)){
                            diamonds.clear();
                        } else {
                            diamonds.add(currentCard);
                        }
                        ArrayList<Integer> facesd = new ArrayList<>();
                        for (String diamond : diamonds) {
                            facesd.add(Integer.parseInt(diamond));
                        }
                        int maxd = Integer.MIN_VALUE;
                        for (int i = 0; i < facesd.size(); i++) {
                            if (facesd.get(i) > maxd) {
                                maxd = facesd.get(i);
                            }
                        }
                        if (maxd != Integer.parseInt(currentCard)) {
                            diamonds.clear();
                        }
                        break;
                    case "c":
                        if (clubs.contains(currentCard)){
                            clubs.clear();
                        } else {
                            clubs.add(currentCard);
                        }
                        ArrayList<Integer> facesc = new ArrayList<>();
                        for (String club : clubs) {
                            facesc.add(Integer.parseInt(club));
                        }
                        int maxc = Integer.MIN_VALUE;
                        for (int i = 0; i < facesc.size(); i++) {
                            if (facesc.get(i) > maxc) {
                                maxh = facesc.get(i);
                            }
                        }
                        if (maxc != Integer.parseInt(currentCard)) {
                            clubs.clear();
                        }
                        break;
                    default:
                        break;
                }
            }

            ArrayList<String> straightFlush = new ArrayList<>(Arrays.asList("10", "11", "12", "13", "14"));

            if (clubs.containsAll(straightFlush)) {
                System.out.println("Royal Flush Found - Clubs");
                clubs.clear();
                count++;
            }
            if (diamonds.containsAll(straightFlush)) {
                System.out.println("Royal Flush Found - Diamonds");
                diamonds.clear();
                count++;
            }
            if (hearts.containsAll(straightFlush)) {
                System.out.println("Royal Flush Found - Hearts");
                hearts.clear();
                count++;
            }
            if (spades.containsAll(straightFlush)) {
                System.out.println("Royal Flush Found - Spades");
                spades.clear();
                count++;
            }
        }

        System.out.printf("Royal's Royal Flushes - %d.", count);
    }
}
