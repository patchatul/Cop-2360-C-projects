using System;
using static System.Console;

class Storkester
{
public static void Main()
{
   Write("Enter stork's height in inches: ");
   double inputHeight = Convert.ToDouble(ReadLine());
   //pass inputHeight to method InchesToOunces
   //output weightInOunce
   double outputWeightInOunce = InchesToOunces(weightInOunce);
   WriteLine($"The weight of the stork is {outputWeightInOunce}");
}
public static double InchesToOunces(double inputHeight)
{
    const double OUNCE = 2.77;
    double weightInOunce = inputHeight * OUNCE;
    return weightInOunce;
}
}