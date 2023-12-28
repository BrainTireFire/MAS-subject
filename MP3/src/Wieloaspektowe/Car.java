package Wieloaspektowe;

public class Car extends Vehicle{

    public Car(String name, float size) {
        super(name, size);
        Type.createVehicle(new Overland(this));
    }

    @Override
    public String getVehicleSound() {
        return "WRUMMMM";
    }
}
