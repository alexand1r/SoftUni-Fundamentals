import java.util.Locale;
import java.util.Scanner;

/**
 * Created by Alec on 09.04.2016 г..
 */
public class TinySporebat {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        int lifePoints = 5800;
        int glowcapsTotal = 0;
        String sporeggar = scan.nextLine();

        while (!sporeggar.equals("Sporeggar") && lifePoints > 0) {
            char[] enemies = sporeggar.substring(0, sporeggar.length() - 1).toCharArray();
            int glowcaps = Integer.parseInt(sporeggar.substring(sporeggar.length() - 1));

            for (int i = 0; i < enemies.length; i++) {
                char currentEnemy = enemies[i];
                if (currentEnemy == 'L') {
                    lifePoints += 200;
                } else {
                    lifePoints -= currentEnemy;
                    if (lifePoints <= 0) {
                        break;
                    }
                }
            }

            if (lifePoints > 0) {
                glowcapsTotal += glowcaps;
            }

            sporeggar = scan.nextLine();
        }

        if (lifePoints <= 0) {
            System.out.printf("Died. Glowcaps: %d", glowcapsTotal);
        } else {
                if (glowcapsTotal >= 30) {
                    System.out.printf("Health left: %d%n", lifePoints);
                    System.out.printf("Bought the sporebat. Glowcaps left: %d", glowcapsTotal - 30);
                } else {
                    System.out.printf("Health left: %d%n", lifePoints);
                    System.out.printf("Safe in Sporeggar, but another %d Glowcaps needed.", 30 - glowcapsTotal);
                }
               }
    }
}
