import java.util.Map;
import java.util.TreeMap;

public class Person {
    private String name;
    private Map<String, Car> carQualif;

    public Person(String name) {
        this.name = name;
        this.carQualif = new TreeMap<>();
    }

    public void addCarsQualif(Car newCar){
        if (!carQualif.containsKey(newCar.getSerialNumber()))
        {
            carQualif.put(newCar.getSerialNumber(), newCar);
            newCar.addPerson(this);
        }
    }

    public Car findCarsQualif(String serialNumber) throws Exception{
        if (!carQualif.containsKey(serialNumber)){
            throw new Exception("Unable to find a gun with this serial number:  " + serialNumber);
        }
        return carQualif.get(serialNumber);
    }

    public String getName() {
        return name;
    }

    @Override
    public String toString() {
        return "Person " + name;
    }
}
