namespace APBD3;

class Program
{
    static void Main(string[] args)
    {
        // ContainerL containerL = new ContainerL(5, 5, 10, 50);
        // Console.WriteLine(containerL);
        //
        // containerL.Loading(new Product("paliwo","plyn",true,10),20);
        // Console.WriteLine(containerL);
        //
        // //stateczek.Loading(80);
        //
        //
        // Ship ship = new Ship(100, 100, 100);
        // Console.WriteLine(ship);
        //
        // ship.LoadingContainerOntoShip(containerL);
        // Console.WriteLine(ship);
         // Tworzenie obiektów produktów
            Product fuel = new Product("Paliwo", "Plyn", true, 10);
            Product milk = new Product("Mleko", "Plyn", false, 4);
            Product helium = new Product("Helium", "Gaz", true, 5);
            
            // Tworzenie obiektów kontenerów
            ContainerL containerL = new ContainerL(10, 20, 5, 50);
            Console.WriteLine(containerL); // Wyświetlamy kontener L przed załadunkiem

            // Załadunek kontenera z produktem
            containerL.Loading(fuel, 20); 
            Console.WriteLine(containerL); // Wyświetlamy kontener L po załadunku

            // Tworzenie statku
            Ship ship1 = new Ship("ship1",100, 5, 500);
            Ship ship2 = new Ship("ship2",90, 5, 450);
            
            Console.WriteLine(ship1); // Wyświetlamy statek przed załadunkiem

            // Załadunek kontenera na statek
            ship1.LoadingContainerOntoShip(containerL);
            Console.WriteLine(ship1); // Wyświetlamy statek po załadunku kontenera
            
            // Sprawdzamy metodę załadunku wielu kontenerów
            List<Container> containers = new List<Container>
            {
                new ContainerL(15, 25, 10, 60),
                new ContainerL(12, 20, 6, 45)
            };
            ship1.LoadingContainerOntoShip(containers);
            Console.WriteLine(ship1); // Wyświetlamy statek po załadunku wielu kontenerów

            // Tworzenie nowego kontenera i zamiana go na innym statku
            ContainerL containerToReplace = new ContainerL(15, 20, 8, 55);
            ship1.ReplaceContainerAnother(containerL.serialNumber, containerToReplace);
            Console.WriteLine(ship1); // Wyświetlamy statek po zastąpieniu kontenera

            // Usuwanie kontenera z statku
            ship1.RemovingContainerFromShip(containerL);
            Console.WriteLine(ship1); // Wyświetlamy statek po usunięciu kontenera

            // Transfer kontenera między dwoma statkami
            ship1.ContainerTransferBetweenShips(containerToReplace, ship2);
            Console.WriteLine(ship1); // Wyświetlamy statek 1 po transferze
            Console.WriteLine(ship2); // Wyświetlamy statek 2 po transferze
        
    }
}