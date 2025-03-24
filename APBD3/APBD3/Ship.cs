namespace APBD3;

public class Ship
{
    private string name;
    private List<Container> containers;
    private double maxSpeed;
    private int maxContainers;
    private double maxWeight;
    private int counter = 0;

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
        try
        {
            if (counter + 1 <= maxContainers)
            {
                containers.Add(cont);
                counter++;
                
                Console.WriteLine($"Kontener {cont.serialNumber} zostal zaladowany na statek {name}.");
            }
            else
            {
                throw new OverfillException(
                    "Nie można zaladowac!\nLadunek ktory chcesz zaladowac przekracza maksymalana ladownosc statku.");
            }
        }
        catch (OverfillException e)
        {
            Console.WriteLine(e.Message);
        }
    }
    
    public void LoadingContainerOntoShip(List<Container> cont)
    {
        try
        {
            if (counter + cont.Count <= maxContainers)
            {
                containers.AddRange(cont);
                counter += cont.Count;
            }
            else
            {
                throw new OverfillException(
                    "Nie można zaladowac!\nLadunek ktory chcesz zaladowac przekracza maksymalana ladownosc statku.");
            }
        }
        catch (OverfillException e)
        {
            Console.WriteLine(e.Message);
        }
    }
    
    public void RemovingContainerFromShip(Container cont)
    {
        if (containers.Contains(cont))
        {
            containers.Remove(cont);
            counter--;

            Console.WriteLine($"Kontener {cont.serialNumber} zostal usuniety z statku {name}.");
        }
        else
        {
            Console.WriteLine($"Kontener {cont.serialNumber} nie znajduje sie na statku {name}. Nie można usunac kontenera!");
        }
    }
    
    public void RemovingContainerFromShip(string number)
    {
        Container containerWithSerialNumber = containers.Find(k => k.serialNumber == number);
    
        if (containerWithSerialNumber != null)
        {
            containers.Remove(containerWithSerialNumber);
            counter--;
        }
        else
        {
            Console.WriteLine($"Kontener {number} nie znajduje sie na statku {name}. Nie można usunac kontenera!");
        }
    }

    
    public void ContainerTransferBetweenShips(Container cont, Ship ship)
    {
        RemovingContainerFromShip(cont);
        ship.LoadingContainerOntoShip(cont);
    }
    
    public void ReplaceContainerAnother(string serialNumber, Container cont)
    {
        Container containerWithSerialNumber = containers.Find(k => k.serialNumber == serialNumber);
    
        if (containerWithSerialNumber != null)
        {
            RemovingContainerFromShip(serialNumber);
            LoadingContainerOntoShip(cont);
        }
        else
        {
            Console.WriteLine($"Kontener o numerze seryjnym {serialNumber} nie zostal znaleziony na statku {name}. Nie moze dojac do wymiany.");
        }
    }
    
    
    public override string ToString()
    {
        string containersList = string.Join(", ", containers.Select(c => c.serialNumber));
        
        return $"Ship {name} MaxSpeed: {maxSpeed} knots, MaxContainers: {maxContainers}, MaxWeight: {maxWeight} tons, Loaded: {counter} \nContainers: [{containersList}]\n";
    }
    
}