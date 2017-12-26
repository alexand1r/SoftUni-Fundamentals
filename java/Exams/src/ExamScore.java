import java.util.DoubleSummaryStatistics;
import java.util.Locale;
import java.util.Scanner;
import java.util.TreeMap;

/**
 * Created by Alec on 02.04.2016 г..
 */
public class ExamScore {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        scan.nextLine();
        scan.nextLine();
        scan.nextLine();
        TreeMap<Integer, TreeMap<String, Double>> points = new TreeMap<>();
        while (true) {
            String[] input = scan.nextLine().split("\\s*\\|\\s*");
            if (input.length < 4) {
                break;
            }
            String student = input[1];
            int score = Integer.parseInt(input[2]);
            double grade = Double.parseDouble(input[3]);
            if (!points.containsKey(score)) {
                points.put(score, new TreeMap<>());
            }

            points.get(score).put(student, grade);
        }

        for (Integer score : points.keySet()) {
            System.out.print(score + " -> ");
            System.out.print(points.get(score).keySet());
            double sum = 0;
            for (double grade : points.get(score).values()) {
                sum += grade;
            }
            double avg = sum / points.get(score).values().size();
            System.out.printf("; avg=%.2f\n", avg);
        }
    }
}
