import java.io.Serializable;

/**
 * Created by Alec on 21.03.2016 г..
 */
public class Course implements Serializable {
    private static final long serialVersionUID = 8309080721495266420L;
    private String name;
    private int numberOfStudents;

    public String getName() {
        return name;
    }

    public Course(String name, int numberOfStudents) {
        super();
        this.name = name;
        this.numberOfStudents = numberOfStudents;
    }

}

