package Wieloaspektowe;

public class Overland extends Type{
    private int wheelCount;

    protected Overland(Vehicle vehicle) {
        super(vehicle);
    }

    public String rideOnTheGround(){
        return "is riding";
    }
}
