package Abstract;

import java.time.LocalDate;

public class Dog extends Animal {
    private String sound;

    public Dog(String name, float size, LocalDate birthDate, String sound) {
        super(name, size, birthDate);
        this.sound = sound;
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
