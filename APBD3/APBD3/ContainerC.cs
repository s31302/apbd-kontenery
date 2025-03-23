namespace APBD3;

public class ContainerC : Container
{
    public string typeOfProduct;
    public double temperature;
    public double temperatureRequired;

    public ContainerC(double height, double depth, double ownWeight, double maxCapacity, string type, string typeOfProduct, double temperature) : base(height, depth, ownWeight, maxCapacity, type)
    {
        this.typeOfProduct = typeOfProduct;
        this.temperature = temperature;
    }
}