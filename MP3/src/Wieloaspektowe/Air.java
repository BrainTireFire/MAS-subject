package Wieloaspektowe;

public class Air extends Type {
    private int wingCount;

    protected Air(Vehicle vehicle) {
        super(vehicle);
    }

    public String fly(){
        return "is flying";
    }
}
