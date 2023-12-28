package Overllaping;

import java.util.EnumSet;

public class ElementOfScenography {
    private String name;
    private float size;

    private EnumSet<ScenographyType> scenographyTypes = EnumSet.of(ScenographyType.Costume);

    public ElementOfScenography(String name, float size) {
        this.name = name;
        this.size = size;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public float getSize() {
        return size;
    }

    public void setSize(float size) {
        this.size = size;
    }

    public void makeProp(){
        this.scenographyTypes.add(ScenographyType.Prop);
    }

    public void makeDecoration_element(){
        this.scenographyTypes.add(ScenographyType.Decoration_element);
    }


    public EnumSet<ScenographyType> getTypes() {
        return scenographyTypes;
    }
}
