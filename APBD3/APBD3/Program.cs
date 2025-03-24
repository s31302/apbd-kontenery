namespace APBD3;

class Program
{
    static void Main(string[] args)
    {
            Product fuel = new Product("Paliwo", "Plyn", true, 10);
            Product milk = new Product("Mleko", "Plyn", false, 4);
            Product helium = new Product("Helium", "Gaz", true, 5);
            Product pineapple = new Product("Pineapple", "Food", false, 3);
            Product bananas = new Product("Bananas", "Food", false, 15);
            Product tv = new Product("Tv", "RTV", false, 15);
            
            ContainerL containerL = new ContainerL(10, 20, 5, 50);
            Console.WriteLine(containerL);
            ContainerC c2 = new ContainerC(10, 10, 10, 10, "Food", 8);
            Console.WriteLine(c2);
            ContainerG cg1 = new ContainerG(10, 10, 10, 10, 10);
            Console.WriteLine(cg1);
            Console.WriteLine();
            ContainerG cg2 = new ContainerG(10, 10, 10, 10, 10);
            ContainerG cg3 = new ContainerG(10, 10, 10, 10, 10);
            ContainerG cg4 = new ContainerG(10, 10, 10, 10, 10);
            ContainerC c3 = new ContainerC(10, 10, 10, 10, "RTV", 8);


            
            containerL.Loading(fuel, 20); 
            Console.WriteLine(containerL);
            containerL.Loading(milk, 1); 
            Console.WriteLine(containerL);
            containerL.Loading(fuel, 2); 
            Console.WriteLine(containerL);
            containerL.Loading(fuel, 3); 
            Console.WriteLine(containerL);
            Console.WriteLine();
            
            c2.Loading(bananas, 20); 
            Console.WriteLine(c2);
            c2.Loading(pineapple, 20);
            Console.WriteLine(c2);
            c2.Loading(pineapple, 8);
            Console.WriteLine(c2);
            Console.WriteLine();
            
            cg1.Loading(helium, 20);
            Console.WriteLine(cg1);
            cg1.Loading(helium, 10);
            Console.WriteLine(cg1);
            cg1.Unloading();
            Console.WriteLine(cg1);
            Console.WriteLine();
            
            cg3.Loading(tv, 5);
            containerL.Unloading();


            Ship ship1 = new Ship("ship1",100, 5, 500);
            Ship ship2 = new Ship("ship2",90, 5, 450);
            
            Console.WriteLine(ship1);
            Console.WriteLine(ship2);
            Console.WriteLine();


            ship1.LoadingContainerOntoShip(containerL);
            Console.WriteLine(ship1);
            ship1.LoadingContainerOntoShip(c2);
            ship1.LoadingContainerOntoShip(cg1);
            ship1.LoadingContainerOntoShip(cg2);
            ship1.LoadingContainerOntoShip(cg3);
            Console.WriteLine(ship1);
            ship1.LoadingContainerOntoShip(cg4);
            Console.WriteLine();

            
            List<Container> containers = new List<Container>
            {
                new ContainerL(15, 25, 10, 60),
                new ContainerL(12, 20, 6, 45)
            };
            ship1.LoadingContainerOntoShip(containers);
            Console.WriteLine(ship1);
            
            ship2.LoadingContainerOntoShip(containers);
            Console.WriteLine(ship2);
            Console.WriteLine();

            ship1.RemovingContainerFromShip(containerL);
            Console.WriteLine(ship1);
            ship1.RemovingContainerFromShip(containerL);
            Console.WriteLine(ship1);
            Console.WriteLine();
         
            
            ship1.ReplaceContainerAnother(cg3.serialNumber, containerL);
            Console.WriteLine(ship1);
            ship1.ReplaceContainerAnother(cg3.serialNumber, containerL);
            Console.WriteLine(ship1);
            
            ContainerL containerToReplace = new ContainerL(15, 20, 8, 55);
            ship1.ReplaceContainerAnother(c2.serialNumber, containerToReplace);
            Console.WriteLine(ship1);
            Console.WriteLine();

            Console.WriteLine(ship1); 
            Console.WriteLine(ship2);
            ship1.ContainerTransferBetweenShips(containerToReplace, ship2);
            Console.WriteLine(ship1); 
            Console.WriteLine(ship2);
        
    }
}