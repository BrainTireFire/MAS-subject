package Dynamic;

public class Monster {
    private String name;
    private Double height;

    public Monster(String name, Double height) {
        this.name = name;
        this.height = height;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Double getHeight() {
        return height;
    }

    public void setHeight(Double height) {
        this.height = height;
    }

    @Override
    public String toString() {
        return "Monster " + name + " height " +  height;
    }
}
