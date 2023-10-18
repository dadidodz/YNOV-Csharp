namespace CSharpDiscovery.Quest03;

public class Campus : PointOfInterest {
    public int Capacity = 3000;

    public override string ToString()
    {
        return $"{Name} is a campus with a capacity of {Capacity} students";
    }

}