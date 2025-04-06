/*using System;
using static System.Console;

class Scooter
{
    public double weight;
    public double price;
    public double WeightInPound
    {
        get
        {
            return weight;
        }
        set
        {
            weight = value;
        }
    }
    public double Price
    {
        get
        {
            return price;
        }
        set
        {
            price = value;
        }
    }
    public Scooter(double weight, double price)
    {
        WeightInPound = weight;
        Price = price;
    }
    public void OutputMessage()
    {
        WriteLine("Scooter's weight is " + weight + " pounds.");
        WriteLine("Scooter's price is $" + price);
    }
}
class ElectricScooter : Scooter
{
    public int wattHours;
    public int WattHours
    {
        get
        {
            return wattHours;
        }
        set
        {
            wattHours = value;
        }
    }
    public ElectricScooter(double weight, double price, int wattHours): base(weight, price)
    {
        WattHours = wattHours;
    }
    public void OutputMessage2()
    {
        WriteLine("Electric Scooter's weight is " + weight + " pounds.");
        WriteLine("Electric Scooter's price is $" + price);
        WriteLine("Electric Scooter's watthours are "+ wattHours + " watts.");
    }
}

class Program
{
    static void Main()
    {
        Scooter scooter1 = new Scooter(4.62, 29.99); //Razor - A Kick Scooter for Kids on Bestbuy
        scooter1.OutputMessage();
        ElectricScooter electricScooter1 = new ElectricScooter(33.5, 299.99, 350); //HiBoy from BestBuy
        electricScooter1.OutputMessage2();
    }
    
}
*/