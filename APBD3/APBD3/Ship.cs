namespace APBD3;

public class Ship
{
    public string name;
    private List<Container> containers;
    private double maxSpeed;
    public int maxContainers;
    public double maxWeight;
    int counter = 0;

    public Ship(string name, double speed, int maxContainers, double maxWeight)
    {
        this.name = name;
        this.maxSpeed = speed;
        this.maxContainers = maxContainers;
        this.maxWeight = maxWeight;
        containers = new List<Container>();
        
    }
    
    public void LoadingContainerOntoShip(Container cont)
    {
        if (counter + 1 < maxContainers)
        {
            containers.Add(cont);
            counter++;
        }
    }
    
    public void LoadingContainerOntoShip(List<Container> cont)
    {
        if(counter + cont.Count < maxContainers)
            containers.AddRange(cont);
        counter += cont.Count;
    }
    
    public void RemovingContainerFromShip(Container cont)
    {
        containers.Remove(cont);
        counter--;
    }
    
    public void RemovingContainerFromShip(string number)
    {
        Container containerWithSerialNumber= containers.Find(k => k.serialNumber == number);
        
        if (containerWithSerialNumber != null)
        {
            //containerWithSerialNumber.Wyladunek();
            containers.Remove(containerWithSerialNumber);
        }
    }
    
    public void ContainerTransferBetweenShips(Container cont, Ship ship)
    {
        RemovingContainerFromShip(cont);
        ship.LoadingContainerOntoShip(cont);
    }
    
    public void ReplaceContainerAnother(string serialNumber, Container cont)
    {
        RemovingContainerFromShip(serialNumber);
        LoadingContainerOntoShip(cont);
    }
    
    
    public override string ToString()
    {
        return $"Ship {name} MaxSpeed: {maxSpeed} knots, MaxContainers: {maxContainers}, MaxWeight: {maxWeight} tons, Loaded: {counter}";
    }
    
}