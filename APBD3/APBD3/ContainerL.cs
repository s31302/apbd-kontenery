namespace APBD3;

public class ContainerL : Container , IHazardNotifier
{
    string type = "L";
    bool isHazardous = false;
    public ContainerL(double height, double depth, double ownWeight, double maxCapacity) : base(height, depth, ownWeight, maxCapacity)
    {
        serialNumber = $"KON-{type}-{++id}";
    }

    public void Warring(string message)
    {
        Console.WriteLine(message);
    }

    public override void Loading(Product product, double loadMass)
    {
        try{
            
            if (product.isHazardous)
            {
                if (!isHazardous)
                {
                    isHazardous = true;
                }
                Warring($"UWAGA! Do kontenera {serialNumber} zaladowywany jest niebezpieczny ladunek");
            }
            
            double limit = isHazardous ? maxCapacity * 0.5 : maxCapacity * 0.9;
        
            if (loadMass + mass > limit)
            {
                throw new OverfillException($"Przekroczono limit pojemności kontenera {serialNumber}.");
            }   
        
            mass += loadMass;
            products.Add(product);
        }
        catch (OverfillException e)
        { 
            Console.WriteLine(e.Message);
        }
    }
}