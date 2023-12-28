package Dynamic;

public class MonsterOnGround extends Monster{
    public MonsterOnGround(String name, Double height) {
        super(name, height);
    }

    public void walkOnTheGround(){
        System.out.println("Walking on the ground");
    }
}
