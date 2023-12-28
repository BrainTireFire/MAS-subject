import java.io.*;
import java.time.LocalDate;
import java.util.ArrayList;

public class Main {

    public static void main(String[] args){

        //Ekstensja
        Room room = new Room("Room1", 20.2F);
        Room room2 = new Room("Room2", 40.2F);
        Room.showExtent();

        //atrybut złożony
        Vehicle vehicle = new Vehicle("Mazda", 200, null, 1992);
        System.out.println();

        //atrybut opcjonalny
        if(vehicle.getHeight() == null) {
            System.out.println("atrybut opcjonalny: height is empty");
        }else
        {
            System.out.println(vehicle.getHeight());
        }

        //atrybut klasowy
        System.out.println("atrybut klasowy: " + Vehicle.getWheelCount());

        //atrybut pochodny
        System.out.println("atrybut pochodny: " + vehicle.getAge());

        //atrybut powtarzalny
        ArrayList<String> brand = vehicle.getBrand();
        System.out.print("atrybut powtarzalny: ");
        for (var e: brand) {
            System.out.print(e + ", ");
        }

        System.out.println();
        //Metoda klasowa
        System.out.println("Metoda klasowa: " + Room.findRoomWithMinSize(1));

        //Przeciazenie metody
        System.out.println("Przeciazenie metody: " + vehicle.getWeight(2));

        //Ekstensja trwala
        final String extentFile = "p:\\extent-perm.bin";

        House house1 = new House("House 1", LocalDate.now(), 69.69f);
        House house2 = new House("House 2", LocalDate.now(), 420.420f);

        try {
            var output = new DataOutputStream(new BufferedOutputStream(new FileOutputStream(extentFile)));
            House.writeExtent(output);
            output.close();

            var input = new DataInputStream(new BufferedInputStream(new FileInputStream(extentFile)));
            House.readExtent(input);
            input.close();
        } catch (IOException e) {
            e.printStackTrace();
        }

        House.showExtent();


    }
}