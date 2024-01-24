import java.util.Date;

/*
    Johnathan R. Burgess
    CSC-151 JAVA Programming
    Final Project
    May 2nd, 2019
 */
public class CourseSection extends Course {

    private String id;
    private String days;
    private String startTime;
    private String building;
    private String room;

    //==============================================================================
    // Class Constructors
    //==============================================================================
    public CourseSection() {

    }
    public CourseSection(String subject, String number, String name, String id, String days, String startTime, String room, String building) {
        super(subject, number, name);
        this.id = id;
        this.days = days;
        this.startTime = startTime;
        this.building = building;
        this.room = room;
    }
    public CourseSection(Course c, String id, String days, String startTime, String building, String room) {
        super(c.getSubject(), c.getNumber(), c.getName());
        this.id = id;
        this.days = days;
        this.startTime = startTime;
        this.building = building;
        this.room = room;
    }
    //==============================================================================


    //==============================================================================
    // Getter and Setter Methods
    //==============================================================================
    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getDays() {
        return days;
    }

    public void setDays(String days) {
        this.days = days;
    }

    public String getStartTime() {
        return startTime;
    }

    public void setStartTime(String startTime) {
        this.startTime = startTime;
    }

    public String getBuilding() {
        return building;
    }

    public void setBuilding(String building) {
        this.building = building;
    }

    public String getRoom() {
        return room;
    }

    public void setRoom(String room) {
        this.room = room;
    }
    //==============================================================================

    @Override
    public String toString() {
        return "\nCourseSection{" +
                super.toString() +
                "id='" + id + '\'' +
                ", days='" + days + '\'' +
                ", startTime='" + startTime + '\'' +
                ", building='" + building + '\'' +
                ", room='" + room + '\'' +
                '}' + "\n";
    }
}

