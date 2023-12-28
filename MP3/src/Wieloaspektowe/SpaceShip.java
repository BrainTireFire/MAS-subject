package Wieloaspektowe;

public class SpaceShip extends Vehicle {

    public SpaceShip(String name, float size) {
        super(name, size);
    }

    @Override
    public String getVehicleSound() {
        return "BRRRRRRRRR";
    }
}
