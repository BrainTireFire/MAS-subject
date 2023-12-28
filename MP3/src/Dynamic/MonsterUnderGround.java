package Dynamic;

public class MonsterUnderGround extends Monster implements IMonsterUnderGround  {

    public MonsterUnderGround(String name, Double height) {
        super(name, height);
    }

    @Override
    public void walkUnderGround() {
        System.out.println("Walking underground");
    }
}
