import java.time.Year;
import java.util.ArrayList;

public class Vehicle {
    private String name;
    private int weight;
    //atrybut opcjonalny
    private Double height;
    //atrybut klasowy
    private static int wheelCount = 4;
    private int yearOfProduction;
    private ArrayList<String> brand;

    //atrybut powtarzalny
    public ArrayList<String> getBrand() {
        return brand;
    }

    private void setBrand() {
        this.brand = new ArrayList<>();
        this.brand .add("Mazda");
        this.brand .add("BMW");
        this.brand .add("Skoda");
    }

    public Vehicle() {
        this.name = "Super car";
        this.weight = 42069;
        this.height = 180.0;
        this.setBrand();
    }

    public Vehicle(String name, int weight, Double height, int yearOfProduction) {
        this.name = name;
        this.weight = weight;
        this.height = height;
        this.yearOfProduction = yearOfProduction;
        this.setBrand();
    }

    //atrybut pochodny
    public int getAge(){
        int actualYear = Year.now().getValue();
        return actualYear - yearOfProduction;
    }

    public static int getWheelCount() {
        return wheelCount;
    }

    public static void setWheelCount(int wheelCount) {
        Vehicle.wheelCount = wheelCount;
    }

    public Double getHeight() {
        return height;
    }

    public void setHeight(Double height) {
        this.height = height;
    }

    public String getName() {
        return this.name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getWeight() {
        return weight;
    }

    //Przeciazenie metody
    public int getWeight(int multiple) {
        return weight * multiple;
    }

    public void setWeight(int weight) {
        this.weight = weight;
    }
}
