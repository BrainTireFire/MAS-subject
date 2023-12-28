package Abstract;

import java.time.LocalDate;

public abstract class Animal {
    private String name;
    private float size;
    private LocalDate birthDate;

    public Animal(String name, float size, LocalDate birthDate) {
        this.name = name;
        this.size = size;
        this.birthDate = birthDate;
    }

    public abstract String getAnimalSound();
}
