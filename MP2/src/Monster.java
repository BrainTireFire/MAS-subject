public class Monster {
    private String name;
    private World world;

    public Monster(String name) {
        this.name = name;
    }

    public void setWorld(World world) {
        this.world = world;
    }

    public void addWorld(World world) {
        if (this.world == null){
            this.world = world;
            world.addMonsterToList(this);
        }
    }

    public String getName() {
        return name;
    }

    @Override
    public String toString() {
        return "Monster " + name + ", " + world;
    }
}
