namespace CSharpDiscovery.Quest04;

public class Truck : Vehicule{

    public int Tonnage {get; set;}

    public Truck(){
        Tonnage = 0;
    }

    public Truck(int tonnage, string brand, string color, int currentSpeed) :base(brand, color, currentSpeed){
        Tonnage = tonnage;
    }

    public override string ToString()
    {
        return $"{Color} {Brand} {Tonnage}T Truck";
    }

    public override void Accelerate(int Speed)
    {
        CurrentSpeed += Speed;
        if (CurrentSpeed>100) {
            CurrentSpeed = 100;
        }
    }

    public override void Brake(int BrakePower)
    {
        CurrentSpeed -= BrakePower;
        if (CurrentSpeed<0) {
            CurrentSpeed = 0;
        }

    }


}