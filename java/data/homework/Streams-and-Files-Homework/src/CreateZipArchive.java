import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.zip.ZipEntry;
import java.util.zip.ZipOutputStream;

/**
 * Created by Alec on 21.03.2016 г..
 */
public class CreateZipArchive {
    public static void main(String[] args) {
        String zipFile = "src/text-files.zip";
        String srcDir = "src/zipArchive";
        try {
            FileOutputStream fos = new FileOutputStream(zipFile);
            ZipOutputStream zos = new ZipOutputStream(fos);
            File srcFile = new File(srcDir);
            addDirToArchive(zos, srcFile);
            zos.close();
        }
        catch (IOException ioe) {
            System.out.println("Error creating zip file: " + ioe);
        }
    }
    private static void addDirToArchive(ZipOutputStream zos, File srcFile) {
        File[] files = srcFile.listFiles();
        System.out.println("Adding directory: " + srcFile.getName());
        for (int i = 0; i < files.length; i++) {
            if (files[i].isDirectory()) {
                addDirToArchive(zos, files[i]);
                continue;
            }
            try {
                System.out.println("tAdding file: " + files[i].getName());
                byte[] buffer = new byte[1024];
                FileInputStream fis = new FileInputStream(files[i]);
                zos.putNextEntry(new ZipEntry(files[i].getName()));
                int length;
                while ((length = fis.read(buffer)) > 0) {
                    zos.write(buffer, 0, length);
                }
                zos.closeEntry();
                fis.close();
            } catch (IOException ioe) {
                System.out.println("IOException :" + ioe);
            }
        }
    }
}
