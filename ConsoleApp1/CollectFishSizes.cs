using System;
using static System.Console;
class CollectFishSizes
{
    static void Main()
    {
        int total_fish_number = 0;
        double fish_size = 0;
        double input_fish_size;
        double average_fish_size = 0;
        WriteLine("To enter fish's size, type 1. To stop, type -1: ");
        int input_int = Convert.ToInt16(ReadLine());
        while(input_int == 1)
        {
            WriteLine("Enter size of fish: ");
            input_fish_size = Convert.ToDouble(ReadLine());
            fish_size += input_fish_size;
            total_fish_number += 1;
            average_fish_size = fish_size/total_fish_number;
            WriteLine("To enter fish's size, type 1. To stop, type -1: ");
            input_int = Convert.ToInt16(ReadLine());
        }
        
        WriteLine("Total number of fish collected: " + total_fish_number);
        WriteLine("Total sizes of fish: " + fish_size);
        WriteLine("Average size of fish: " + average_fish_size);
    }
}