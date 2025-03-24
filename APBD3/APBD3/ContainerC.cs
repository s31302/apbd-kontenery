namespace APBD3;

public class ContainerC : Container
{
    private string typeOfProduct;
    private double temperature;

    private string type = "C";
    //public double temperatureRequired;

    public ContainerC(double height, double depth, double ownWeight, double maxCapacity, string typeOfProduct, double temperature) : base(height, depth, ownWeight, maxCapacity)
    {
        this.typeOfProduct = typeOfProduct;
        this.temperature = temperature;
        serialNumber = $"KON-{type}-{++id}";
    }
    
    public override void Loading(Product product, double loadMass)
    {
        try
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
        catch (Exception e)
        {
            Console.WriteLine($"Błąd w kontenerze {serialNumber}: {e.Message}");
        }
    }
}