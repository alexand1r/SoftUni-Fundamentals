import java.io.*;

/**
 * Created by Alec on 21.03.2016 г..
 */
public class SaveACustomObjectInAFile {
    public static void main(String[] args) {
        try {
            FileOutputStream fileOutputStream = new FileOutputStream(
                    "resources/course.save");
            Course course = new Course("Java", 90);
            ObjectOutputStream output = new ObjectOutputStream(fileOutputStream);
            output.writeObject(course);
            output.close();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }

        try {
            FileInputStream fileInputStream = new FileInputStream(new File(
                    "resources/course.save"));
            ObjectInputStream input = new ObjectInputStream(fileInputStream);
            Course course2 = (Course) input.readObject();
            System.out.println(course2.getName());
            input.close();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
        }
    }
}
