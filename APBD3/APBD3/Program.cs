namespace APBD3;

class Program
{
    static void Main(string[] args)
    {
        ContainerL containerL = new ContainerL(5, 5, 10, 50);
        Console.WriteLine(containerL);
        
        containerL.Loading(new Product("paliwo","plyn",true,10),20);
        Console.WriteLine(containerL);
        
        //stateczek.Loading(80);
        
        
        Ship ship = new Ship(100, 100, 100);
        Console.WriteLine(ship);
        
        ship.LoadingContainerOntoShip(containerL);
        Console.WriteLine(ship);
        
        

        
        
        
        
        
        
        
        
        
    }
}