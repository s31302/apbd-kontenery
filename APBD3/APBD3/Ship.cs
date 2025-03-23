namespace APBD3;

public class Ship
{
    private List<Container> containers;
    private double maxSpeed;
    public int maxContainers;
    public double maxWeight;
    static int counter = 0;

    public Ship(double speed, int maxContainers, double maxWeight)
    {
        this.maxSpeed = speed;
        this.maxContainers = maxContainers;
        this.maxWeight = maxWeight;
        
    }
    
    public void LoadingContainerOntoShip(Container cont)
    {
        if(counter + 1  < maxContainers)
        containers.Add(cont);
        counter++;
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
        return $"Ship MaxSpeed: {maxSpeed} knots, MaxContainers: {maxContainers}, MaxWeight: {maxWeight} tons, Loaded: {counter}";
    }
    
}