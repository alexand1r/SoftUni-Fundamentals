import java.util.Scanner;

/**
 * Created by Alec on 17.03.2016 г..
 */
public class TriangleArea {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int ax = scan.nextInt();
        int ay = scan.nextInt();
        int bx = scan.nextInt();
        int by = scan.nextInt();
        int cx = scan.nextInt();
        int cy = scan.nextInt();

        int area = (ax * (by - cy) + bx * (cy - ay) + cx * (ay - by)) / 2;
        System.out.println(Math.abs(area));
    }
}

// it is impossible for three points not to form a triangle
