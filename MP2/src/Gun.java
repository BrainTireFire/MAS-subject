import java.util.ArrayList;
import java.util.List;

public class Gun {
    private String name;
    private GunHero gunHero;

    public Gun(String name) {
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
        String info = "Gun " + name + ", " +  gunHero.getkillCount();
        return info;
    }
}
