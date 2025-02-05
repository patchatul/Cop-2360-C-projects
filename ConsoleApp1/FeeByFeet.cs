using System;
using static System.Console;
class FeeByFeet
{
    static void Main()
    {
        const double FEE_UNDER_FIVE = 39.95;
        const double FEE_FIVE_TO_EIGHT = 89.99;
        const double FEE_ABOVE_EIGHT = 139.95;
        const int FIVE_FEET_HEIGHT = 5;
        const int EIGHT_FEET_HEIGHT = 8;
        Write("Enter height of the sign in feet: ");
        string height_string_input = ReadLine();
        double height_input = Convert.ToDouble(height_string_input);
        if (height_input < FIVE_FEET_HEIGHT){
            WriteLine($"Fee is $ {FEE_UNDER_FIVE}.");
        }
        else if (height_input > FIVE_FEET_HEIGHT && height_input < EIGHT_FEET_HEIGHT){
            WriteLine($"Fee is $ {FEE_FIVE_TO_EIGHT}.");
        }
        else if (height_input > EIGHT_FEET_HEIGHT){
            WriteLine($"Fee is $ {FEE_ABOVE_EIGHT}.");
        }
    }

}