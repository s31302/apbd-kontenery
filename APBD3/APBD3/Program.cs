namespace APBD3;

class Program
{
    static void Main(string[] args)
    {
        ContainerL stateczek = new ContainerL(5, 5, 10, 50);
        Console.WriteLine(stateczek);
        
        stateczek.Loading(new Product("paliwo","plyn",true,10),20);
        Console.WriteLine(stateczek);
        
        //stateczek.Loading(80);
        
        
        
        
        
        
        
        
        
        
        
        
    }
}