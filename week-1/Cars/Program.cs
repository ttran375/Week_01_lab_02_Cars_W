namespace Cars;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class Car
{
    private int year;
    private string model;
    private bool isDrivable;
    private double price;

    public Car(int year, string model, bool isDrivable = true, double price)
        {
            this.year = year;
            this.model = model;
            this.isDrivable = isDrivable;
            this.price = price;
        }

    
}
