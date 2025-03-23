namespace APBD3;

public class ContainerL : Container , IHazardNotifier
{
    //public bool isHazardous;
    string type = "L";
    public ContainerL(double height, double depth, double ownWeight, double maxCapacity) : base(height, depth, ownWeight, maxCapacity)
    {
        serialNumber = $"KON-{type}-{++id}";

    }

    public void Warring(string message)
    {
        Console.WriteLine(message);
    }

    public void Loading(Product product, double loadMass)
    {
        double limit = product.isHazardous ? maxCapacity * 0.5 : maxCapacity * 0.9;
        if (product.isHazardous)
        {
            Warring($"UWAGA! Do kontenera {serialNumber} zaladowywany jest niebezpieczny ladunek");
        }

        if (loadMass + mass > limit)
        {
            throw new OverfillException($"Przekroczono limit pojemności kontenera {serialNumber}.");
        }
        
        base.Loading(product, loadMass);
    }
}