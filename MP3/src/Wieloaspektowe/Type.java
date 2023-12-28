package Wieloaspektowe;

public class Type {
    private Vehicle vehicle;

    protected Type(Vehicle vehicle) {
        this.vehicle = vehicle;
    }

    public static Type createVehicle(Vehicle vehicle) throws Exception{
        if (vehicle == null){
            throw new Exception("The given tree does not exist!");
        }

        if (vehicle instanceof Car) {
            // Create a new Car object and return its Type object
            Car car = (Car) vehicle;
            return new Type(car);
        } else if (vehicle instanceof SpaceShip) {
            // Create a new SpaceShip object and return its Type object
            SpaceShip spaceShip = (SpaceShip) vehicle;
            return new Type(spaceShip);
        } else {
            // Unknown vehicle type
            throw new Exception("Unknown vehicle type.");
        }


        return type;
    }

    public void removeType(Vehicle vehicle) throws Exception{
        if (vehicle == null){
            throw new Exception("The given tree does not exist!");
        }
        vehicle = null;
    }
}
