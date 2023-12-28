public class Car {
    private String name;
    private String serialNumber;
    private Person person;


    public Car(String name, String serialNumber) {
        this.name = name;
        this.serialNumber = serialNumber;
    }

    public void addPerson(Person person)
    {
        if (this.person == null){
            this.person = person;
            person.addCarsQualif(this);
        }
    }

    public String getSerialNumber() {
        return serialNumber;
    }

    public String getName() {
        return name;
    }

    @Override
    public String toString() {
        String info = "Car " + name + ", Serial: " + this.serialNumber +  " \n"
                + " Person: " + person.getName();
        return info;
    }
}
