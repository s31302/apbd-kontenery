namespace APBD3;

public class ContainerL : Container , IHazardNotifier
{
    //public bool isHazardous;
    public ContainerL(double height, double depth, double ownWeight, double maxCapacity, string type) : base(height, depth, ownWeight, maxCapacity, "L")
    {
        
    }

    public void Warring(string message)
    {
        Console.WriteLine(message);
    }

    public void Loading(double loadMass)
    {
        //tutaj pomyslec jak to ogranac z tymi niebezpiecznymi
        if (true)
        {
            Warring($"UWAGA! Do kontenera {serialNumber} zaladowywany jest niebezpieczny ladunek");
            maxCapacity /= 2;
        }
        else
        {
            maxCapacity *= 0.9;
        }
        
        base.Loading(loadMass);
    }
}