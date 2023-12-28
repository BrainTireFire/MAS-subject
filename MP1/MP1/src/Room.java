import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

public class Room {
    private String name;
    private float size;
    private static List<Room> extent = new ArrayList<>();

    public Room() {
        addRoom(this);
    }

    public Room(String name, float size) {
        this.name = name;
        this.size = size;
        addRoom(this);
    }

    private static void addRoom(Room room){
        extent.add(room);
    }

    private static void removeRoom(Room room){
        extent.remove(room);
    }

    public float getSize() {
        return size;
    }

    public void setSize(float size) {
        this.size = size;
    }

    public static void showExtent() {
        System.out.println("Ekstensja klasy " + Room.class.getName());

        for (Room room : extent) {
            System.out.println(room);
        }
    }

    //Metoda klasowa
    public static List<Room> findRoomWithMinSize(float minSize){
        return extent.stream().filter(e -> e.getSize() > minSize).collect(Collectors.toCollection(ArrayList::new));
    }

    @Override
    public String toString() {
        return "Name: " + name + ", size=" + size;
    }
}
