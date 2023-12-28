import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {

        System.out.println("-------------------------------------------------");
        System.out.println("Asocjacja zwykla 1-*");
        System.out.println("-------------------------------------------------");
        //Asocjacja zwykla 1-*
        World world1 = new World("Subway");
        World world2 = new World("Downside");
        Monster monster1 = new Monster("Zombie");
        Monster monster2 = new Monster("Skeleton");
        Monster monster3 = new Monster("Vampire");
        Monster monster4 = new Monster("Zombie King");

        world1.addMonsterToList(monster1);
        world1.addMonsterToList(monster2);
        world1.addMonsterToList(monster3);
        monster4.addWorld(world2);

        System.out.println(world1);
        System.out.println(world2);

        System.out.println(monster1);
        System.out.println(monster2);
        System.out.println(monster3);


        System.out.println("-------------------------------------------------");
        System.out.println("Asocjacja z atrybutem");
        System.out.println("-------------------------------------------------");
        //Asocjacja z atrybutem
        Gun gun = new Gun("Glock");
        Hero hero = new Hero("John Wick");
        Hero hero2 = new Hero("Spiderman");
        GunHero gunHero = new GunHero(10000000);

        gunHero.addGunToList(gun);
        gunHero.addGunToList(hero);
        gunHero.addGunToList(hero2);

        System.out.println(hero);
        System.out.println(gun);
        System.out.println(hero2);
        System.out.println(gunHero);

        System.out.println("-------------------------------------------------");
        System.out.println("Asocjacja kwalifikowana");
        System.out.println("-------------------------------------------------");
       //Asocjacja kwalifikowana
        Car carQualif1 = new Car("Skoda", "HGJ23SA");
        Car carQualif2 = new Car("BMW", "ZX2A4AC");
        Car carQualif3 = new Car("Lexus", "ZX2A4AC");
        Person personQualif1 = new Person("Big dick");
        Person personQualif2 = new Person("Small dick");

        personQualif1.addCarsQualif(carQualif1);
        personQualif1.addCarsQualif(carQualif2);
        personQualif2.addCarsQualif(carQualif3);

        try {
            System.out.println(personQualif1.findCarsQualif("ZX2A4AC"));
            System.out.println(personQualif1.findCarsQualif("HGJ23SA"));
            System.out.println(carQualif3);
        } catch (Exception e) {
            throw new RuntimeException(e);
        }

        System.out.println("-------------------------------------------------");
        System.out.println("Asocjacja kompozycja");
        System.out.println("-------------------------------------------------");
        //Asocjacja kompozycja
        Tree tree1 = new Tree("Sosna");
        Tree tree2 = new Tree("Brzoza");
        Tree tree3 = new Tree("Dab");

        try {
            Wood.createTree(tree1, "Drzewo z sosna");
            Wood.createTree(tree2, "Drzewo z brzoza");
            Wood.createTree(tree3, "Drzewo z Dab");
        } catch (Exception e) {
            throw new RuntimeException(e);
        }

        System.out.println(tree1);
        System.out.println(tree2);
        System.out.println(tree3);
    }
}
