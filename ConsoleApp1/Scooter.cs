using System;
using static System.Console;

class Scooter
{
    public double weightInPound;
    public double price;
    public double WeightInPound
    {
        get
        {
            return weightInPound;
        }
        set
        {
            weightInPound = value;
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
    
}
class ElectricScooter : Scooter
{
    public int Watthours{get; set;} //350
}

class Program
{
    static void Main()
    {
        
    }
}