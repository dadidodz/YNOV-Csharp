namespace CSharpDiscovery.Quest03;

public class HistoricalMonument : PointOfInterest{

    public int BuildYear {get; set;}

    public HistoricalMonument(){

    }

    public HistoricalMonument (string nameParam, double latitudeParam, double longitudeParam, int buildYearParam): base (nameParam, latitudeParam, longitudeParam){
        BuildYear = buildYearParam;
    }

    public override string ToString()
    {
        return $"{Name} is a historical monument built in {BuildYear}";
    }
}