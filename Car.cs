namespace CSharpDiscovery.Quest04;

public class Car : Vehicule{

    public string Model {get; set;}

    public Car(){
        Model = "Unknown";
    }

    public Car(string model, string brand, string color, int currentSpeed) :base(brand, color, currentSpeed){
        Model = model;
    }

    public override string ToString()
    {
        return $"{Color} {Brand} {Model}";
    }
}