package Abstract;

import java.time.LocalDate;

public class Bat extends Animal {

    private boolean canFly;
    private String sound;

    public Bat(String name, float size, LocalDate birthDate, String sound) {
        super(name, size, birthDate);
        this.sound = sound;
    }

    public boolean isCanFly() {
        return canFly;
    }

    public void setCanFly(boolean canFly) {
        this.canFly = canFly;
    }

    public String getSound() {
        return sound;
    }

    public void setSound(String sound) {
        this.sound = sound;
    }

    @Override
    public String getAnimalSound() {
        return this.getSound();
    }
}
