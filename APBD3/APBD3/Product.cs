namespace APBD3;

public class Product
{
    public string name;
    public string type;
    public bool isHazardous;
    public double requiredTemperature;


    public Product(string name, string type, bool isHazardous, double requiredTemperature)
    {
        this.name = name;
        this.type = type;
        this.isHazardous = isHazardous;
        this.requiredTemperature = requiredTemperature;
    }
}