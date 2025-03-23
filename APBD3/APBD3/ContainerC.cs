namespace APBD3;

public class ContainerC : Container
{
    public string typeOfProduct;
    public double temperature;
    //public double temperatureRequired;

    public ContainerC(double height, double depth, double ownWeight, double maxCapacity, string type, string typeOfProduct, double temperature) : base(height, depth, ownWeight, maxCapacity, type)
    {
        this.typeOfProduct = typeOfProduct;
        this.temperature = temperature;
    }
    
    public void Loading(Product product, double loadMass)
    {
        if (temperature < product.requiredTemperature)
        {
            throw new Exception("Temperatura kontenera jest za niska dla tego produktu!");
        }
        if (typeOfProduct != product.type)
        {
            throw new Exception($"Kontener nie przechowuje tego typu produktu! Wymagany typ: {typeOfProduct}");
        }
        
        base.Loading(product, loadMass);
    }
}