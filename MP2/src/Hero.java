import java.util.Map;
import java.util.TreeMap;

public class Hero {
    private String name;
    private World world;
    private GunHero gunHero;
    public Hero(String name) {
        this.name = name;
    }

    public void addGunHero(GunHero gunHero) {
        if (this.gunHero == null){
            this.gunHero = gunHero;
            gunHero.addGunToList(this);
        }
    }

    public String getName() {
        return name;
    }

    @Override
    public String toString() {
        return "Hero " + name + ", " + gunHero.getkillCount();
    }
}
