using System;
using static System.Console;

class Storkester
{
public static void Main()
{
   Write("Enter stork's height in inches: ");
   double inches = Convert.ToDouble(ReadLine());
   //pass inches user's input to method InchesToOunces
   //output weightInOunce
   double outputWeightInOunces = InchesToOunces(inches);
   WriteLine("The weight of the stark is {0} ounces.", outputWeightInOunces);
}
public static double InchesToOunces(double inches)
{
    const double OUNCE = 2.77;
    double weightInOunce = inches * OUNCE;
    return weightInOunce;
}
}