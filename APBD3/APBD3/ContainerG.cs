namespace APBD3;

public class ContainerG : Container, IHazardNotifier
{
    public double pressure;

    public ContainerG(double height, double depth, double ownWeight, double maxCapacity, string type, double pressure) : base(height, depth, ownWeight, maxCapacity, "G")
    {
        this.pressure = pressure;
    }
    
    public void Unloading()
    {
        mass *= 0.05;
    }
    
    public void Warring(string message)
    {
        Console.WriteLine($"UWAGA! Zajscie niebezpieczne dla kontenera {serialNumber} : {message}");    
    }
}