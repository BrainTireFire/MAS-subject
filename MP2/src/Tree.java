import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

public class Tree {
    private String name;
    private List<Wood> woods;
    private static Set<Wood> allParts = new HashSet<>();

    public Tree(String name) {
        this.name = name;
        woods = new ArrayList<>();
    }

    public void addWood(Wood wood) throws Exception{
        if(!woods.contains(wood)){
            if (allParts.contains(wood)){
                throw new Exception("The part is already connected with a whole!");
            }
            woods.add(wood);
            allParts.add(wood);
        }
    }

    @Override
    public String toString() {
        String info = "Tree: " + name + "\n";
        for(Wood wood : woods) {
            info += "   " + wood.getName() + "\n";
        }

        return info;
    }
}
