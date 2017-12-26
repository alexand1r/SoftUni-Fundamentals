import java.util.*;
import java.util.ArrayList;
/**
 * Created by Alec on 06.04.2016 г..
 */
public class SchoolSystem {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        int n = Integer.parseInt(scan.nextLine());
        Map<String, TreeMap<String, ArrayList<Integer>>> students = new TreeMap<>();

        for (int i = 0; i < n; i++) {
            String[] input = scan.nextLine().split(" ");
            String name = input[0] + input[1];
            String subject = input[2];
            int grade = Integer.parseInt(input[3]);

            TreeMap<String, ArrayList<Integer>> subjects = new TreeMap<>();
            if (students.containsKey(name)) {
                subjects = students.get(name);
                if (!subjects.containsKey(subject)) {
                    subjects.put(subject, new ArrayList<>());
                }

                subjects.get(subject).add(grade);
            } else {
                ArrayList<Integer> marks = new ArrayList<>();
                marks.add(grade);
                subjects.put(subject, marks);
                students.put(name, subjects);
            }
        }

        for ( Map.Entry<String, TreeMap<String, ArrayList<Integer>>> student : students.entrySet() ) {
            String studentName = student.getKey();
            TreeMap<String, ArrayList<Integer>> subjects = student.getValue();
            String output  = studentName + ": [";
            ArrayList<Double> avrgMarks = new ArrayList<>();
            for (Map.Entry<String, ArrayList<Integer> > subject : subjects.entrySet()) {
                String subjectName = subject.getKey();
                Object[] marks = subject.getValue().toArray();
                output += subjectName + " - " + String.format("%.2f", averageOf(marks)) + ", ";
                avrgMarks.add(averageOf(marks));
            }

            output = output.substring(0, output.length() - 2) + "]";
            System.out.print(output + "\n");
        }
    }

    public static double averageOf(Object[] arr) {
        double sum = 0;
        for (int i = 0; i < arr.length; i++) {
            sum += (int)arr[i];
        }

        double average = sum / arr.length;

        return average;
    }
}
