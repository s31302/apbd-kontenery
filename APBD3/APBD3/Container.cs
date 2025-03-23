namespace APBD3;

public abstract class Container
{
    public static int id = 0;
    public double mass;
    public double height;
    public double depth;
    public double ownWeight;
    public string serialNumber;
    public double maxCapacity; //maksymalna ladownosc

    protected Container(double height, double depth, double ownWeight, double maxCapacity, string type)
    {
        this.height = height;
        this.depth = depth;
        this.ownWeight = ownWeight;
        this.maxCapacity = maxCapacity;
        mass = 0.0;
        serialNumber = $"KON-{type}-{++id}";
    }

    public void Unloading()
    {
        mass = 0.0;
    }

    public void Loading(double loadMass)
    {
        if (loadMass > maxCapacity)
        {
            var przekroczenie = loadMass - maxCapacity;
            throw new OverfillException($"Nie można zaladowac!\nLadunek ktory chcesz zaladowac przekracza maksymalana ladownosc kontenera o {przekroczenie}kg." );
        }
        mass += loadMass;
    }
    
}