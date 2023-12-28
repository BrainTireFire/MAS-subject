package Wieloaspektowe;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

public abstract class Vehicle {
    private String name;
    private float size;
    private static List<Vehicle> extent = new ArrayList<>();
    private List<Type> types;
    private static Set<Type> allParts = new HashSet<>();

    public Vehicle(String name, float size) {
        this.name = name;
        this.size = size;
        types = new ArrayList<>();
        addVehicle(this);
    }

    public Type getType() {
        return types.stream().findFirst().orElse(null);
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public float getSize() {
        return size;
    }

    public void setSize(float size) {
        this.size = size;
    }

    public void addVehicle(Type type) throws Exception{
        if(!types.contains(type)){
            if (allParts.contains(type)){
                throw new Exception("The part is already connected with a whole!");
            }
            types.add(type);
            allParts.add(type);
        }
    }

    public static void removeVehicle(Vehicle vehicle) throws Exception {
        extent.remove(vehicle);
        for(Type type : vehicle.types) {
            allParts.remove(type);
            vehicle.types.remove(type);
            type.removeType(vehicle);
        }
    }

    private static void addVehicle(Vehicle vehicle){
        extent.add(vehicle);
    }

    public abstract String getVehicleSound();

    @Override
    public String toString() {
        return getClass().toString() + " " + this.getName() + " ";
    }
}
