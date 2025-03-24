namespace APBD3;

public abstract class Container
{
    protected static int id = 0;
    protected double mass;
    protected  double height;
    protected  double depth;
    protected  double ownWeight;
    public string serialNumber;
    protected  double maxCapacity; //maksymalna ladownosc
    protected  List<Product> products;

    public Container(double height, double depth, double ownWeight, double maxCapacity)
    {
        this.height = height;
        this.depth = depth;
        this.ownWeight = ownWeight;
        this.maxCapacity = maxCapacity;
        mass = 0.0;
        products = new List<Product>();
    }

    public virtual void Unloading()
    {
        mass = 0.0;
        products.Clear();
    }

    public virtual void Loading(Product product, double loadMass)
    {
        try
        {
            if (loadMass + mass > maxCapacity)
            {
                var przekroczenie = loadMass - maxCapacity;
                throw new OverfillException(
                    $"Nie można zaladowac!\nLadunek ktory chcesz zaladowac przekracza maksymalana ladownosc kontenera o {przekroczenie}kg.");
            }

            mass += loadMass;
            products.Add(product);
        }
        catch (OverfillException e)
        { 
            Console.WriteLine(e.Message);
        }
    }
    
    public override string ToString()
    {
        return $"{serialNumber}: Load={mass}kg, OwnWeight={ownWeight}kg, MaxCapacity={maxCapacity}kg";
    }
    
}