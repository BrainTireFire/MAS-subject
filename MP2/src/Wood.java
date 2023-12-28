public class Wood {
    public String name;
    private Tree tree;

    private Wood(Tree tree, String name) {
        this.name = name;
        this.tree = tree;
    }

    public static Wood createTree(Tree tree, String name) throws Exception{
        if (tree == null){
            throw new Exception("The given tree does not exist!");
        }

        Wood wood = new Wood(tree, name);

        tree.addWood(wood);

        return wood;
    }

    public String getName() {
        return name;
    }

    @Override
    public String toString() {
        return "Wood: " + name;
    }
}
