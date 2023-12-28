import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

public class House {
    private String name;
    private float size;
    private LocalDate additionDate;

    private static List<House> extent = new ArrayList<>();

    public House() {
        addHouse(this);
    }

    public House(String name, LocalDate localDate, float size) {
        this.name = name;
        this.size = size;
        this.additionDate = localDate;
        addHouse(this);
    }

    private static void addHouse(House house){
        extent.add(house);
    }

    private static void removeHouse(House house){
        extent.remove(house);
    }

    public static void writeExtent(DataOutputStream stream) throws IOException {
        stream.writeInt(extent.size());

        for (House house : extent) {
            house.write(stream);
        }
    }

    public static void showExtent() {
        System.out.println("Ekstensja klasy trwala " + House.class.getName());

        for (House house : extent) {
            System.out.println(house);
        }
    }

    public static void readExtent(DataInputStream stream) throws IOException {
        House house = null;

        int objectCount = stream.readInt();

        extent.clear();

        for (int i = 0; i < objectCount; i++) {
            house = new House();
            house.read(stream);
        }
    }

    private void write(DataOutputStream stream) throws IOException {
        stream.writeUTF(this.name);
        stream.writeFloat(this.size);
        stream.writeLong(this.additionDate.toEpochDay());
    }

    private void read(DataInputStream stream) throws IOException {
        name = stream.readUTF();
        size = stream.readFloat();
        long epochDay = stream.readLong();
        additionDate = LocalDate.ofEpochDay(epochDay);
    }

    @Override
    public String toString() {
        return "Name: " + name + ", size=" + size;
    }
}
