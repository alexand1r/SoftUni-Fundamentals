import java.io.*;
import java.util.ArrayList;
import java.util.List;
import java.lang.*;

/**
 * Created by Alec on 21.03.2016 г..
 */
public class SaveAnArrayListOfDoubles implements Serializable {
    public static void main(String[] args) {
        ArrayList<Double> list = new ArrayList<Double>();
        ArrayList<Double> arraylist = new ArrayList<Double>();
        list.add(3.55);
        list.add(4.62);
        list.add(8.64);
        try (FileOutputStream fos = new FileOutputStream("resources/doubles.list");
             ObjectOutputStream oos = new ObjectOutputStream(fos);){
            oos.writeObject(list);
            oos.close();
            fos.close();
            FileInputStream fis = new FileInputStream("resources/doubles.list");
            ObjectInputStream ois = new ObjectInputStream(fis);
            arraylist = (ArrayList) ois.readObject();
            ois.close();
            fis.close();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }catch(ClassNotFoundException c){
            System.out.println("Class not found");
            c.printStackTrace();
            return;
        }
        for(double tmp: arraylist){
            System.out.println(tmp);
        }

    }
}
