﻿namespace APBD3;

public class ContainerG : Container, IHazardNotifier
{
    private double pressure;
    private string type = "G";

    public ContainerG(double height, double depth, double ownWeight, double maxCapacity, double pressure) : base(height, depth, ownWeight, maxCapacity)
    {
        this.pressure = pressure;
        serialNumber = $"KON-{type}-{++id}";

    }
    
    public override void Unloading()
    {
        mass *= 0.05;
    }
    
    public void Warring(string message)
    {
        Console.WriteLine($"UWAGA! Zajscie niebezpieczne dla kontenera {serialNumber} : {message}");    
    }
}