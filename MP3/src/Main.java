import Abstract.Animal;
import Abstract.Bat;
import Abstract.Dog;
import Dynamic.MonsterUnderOnGround;
import Overllaping.ElementOfScenography;
import Wieloaspektowe.*;

import java.time.LocalDate;

public class Main {
    public static void main(String[] args) {
        //Abstract i polimorfizm
        System.out.println("------------------------------------");
        System.out.println("Abstract");
        System.out.println("------------------------------------");
        Animal dog = new Dog("Burek", 20.4F, LocalDate.of(2018,1,20), "Hau hau");
        Animal bat = new Bat("Netoper", 5.1F, LocalDate.of(2000,7,4), "Prprprpprprprr ciicicic");

        System.out.println("Dog: " + dog.getAnimalSound());
        System.out.println("Bat: " + bat.getAnimalSound());

        //Overllaping
        System.out.println("------------------------------------");
        System.out.println("Overllaping");
        System.out.println("------------------------------------");

        ElementOfScenography watch = new ElementOfScenography("Watch", 1.9F);
        ElementOfScenography belt = new ElementOfScenography("Belt", 5.9F);
        ElementOfScenography watchAndBelt = new ElementOfScenography("Watch and belt", 5.9F);

        watch.makeProp();
        belt.makeDecoration_element();
        watchAndBelt.makeProp();
        watchAndBelt.makeDecoration_element();

        System.out.println(watchAndBelt.getName());
        System.out.println(watch.getName());
        System.out.println(belt.getName());

        //Wielodziedziczenie
        System.out.println("------------------------------------");
        System.out.println("Wielodziedziczenie");
        System.out.println("------------------------------------");

        MonsterUnderOnGround monsterUnderOnGround = new MonsterUnderOnGround("Mole zombie", 69.0);
        System.out.println(monsterUnderOnGround.toString());
        monsterUnderOnGround.walkUnderGround();
        monsterUnderOnGround.walkOnTheGround();

        //Dynamic
        System.out.println("------------------------------------");
        System.out.println("Dynamic");
        System.out.println("------------------------------------");



        //Wieloaspektowe
        System.out.println("------------------------------------");
        System.out.println("Wieloaspektowe");
        System.out.println("------------------------------------");

        Vehicle car = new Car("BMW", 200.0F);
        Vehicle spaceShip = new SpaceShip("Space Ship 1", 1000.9F);

        System.out.println(car.toString() + ": " + car.getVehicleSound()+ " : ");
        System.out.println(spaceShip.toString() + ": " + spaceShip.getVehicleSound() + " : ");

    }
}
