import java.util.ArrayList;
import java.util.List;

public class World {
    private String name;
    private List<Monster> monsterList;

    public World(String name) {
        this.name = name;
        this.monsterList = new ArrayList<Monster>();
    }

    public void addMonsterToList(Monster monster) {
        if (!this.monsterList.contains(monster))
        {
            this.monsterList.add(monster);
            monster.addWorld(this);
        }
    }

    public String getName() {
        return name;
    }

    @Override
    public String toString() {
        String info = "World: " + name + "\n";

        // Add info about titles of his/her movies
        for(Monster monster : monsterList) {
            info += "   " + monster.getName() + "\n";
        }

        return info;
    }
}
