package Dynamic;

public class MonsterUnderOnGround extends MonsterOnGround implements IMonsterUnderGround{
    public MonsterUnderOnGround(String name, Double height) {
        super(name, height);
    }

    @Override
    public void walkUnderGround() {
        System.out.println("Walking underground");
    }
}
