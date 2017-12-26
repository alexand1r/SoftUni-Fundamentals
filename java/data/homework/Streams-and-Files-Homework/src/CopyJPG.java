/**
 * Created by Alec on 21.03.2016 г..
 */
import java.io.*;
import java.nio.channels.FileChannel;

public class CopyJPG {

    public static void main(String[] args) {

        File image = new File("resources/image.jpg");
        File copiedImage = new File("resources/my-copied-picture.jpg");
        //InputStream input = null;
        //OutputStream output = null;
        FileChannel inputChannel = null;
        FileChannel outputChannel = null;
        /*try {
            input = new FileInputStream(image);
            output = new FileOutputStream(copiedImage);
            byte[] buf = new byte[1024];
            int bytesRead;
            while ((bytesRead = input.read(buf)) > 0) {
                output.write(buf, 0, bytesRead);
            }*/
        try {
            inputChannel = new FileInputStream(image).getChannel();
            outputChannel = new FileOutputStream(copiedImage).getChannel();
            outputChannel.transferFrom(inputChannel, 0, inputChannel.size());

            //input.close();
            //output.close();
            inputChannel.close();
            outputChannel.close();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}