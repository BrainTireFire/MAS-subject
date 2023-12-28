import java.util.ArrayList;
import java.util.List;

public class GunHero {
    private int killCount;

    private List<Hero> heros;
    private List<Gun> guns;

    public GunHero(int killCount) {
        this.killCount = killCount;
        this.guns = new ArrayList<>();
        this.heros = new ArrayList<>();
    }

    public <T> void addGunToList(T object) {
        if (object instanceof Hero)
        {
            if (!this.heros.contains(object))
            {
                this.heros.add((Hero)object);
                ((Hero) object).addGunHero(this);
            }
        } else if (object instanceof Gun) {
            if (!this.guns.contains(object))
            {
                this.guns.add((Gun)object);
                ((Gun) object).addGunHero(this);
            }
        }
    }

    public int getkillCount() {
        return killCount;
    }

    @Override
    public String toString() {
        String info = "GunHero: " + killCount + "\n";

        // Add info about titles of his/her movies
        for(Hero hero : heros) {
            info += "   " + hero.getName() + "\n";
        }

        for(Gun gun : guns) {
            info += "   " + gun.getName() + "\n";
        }

        return info;
    }
}
