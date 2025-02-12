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
        const double ENDLOOP = -1;
        Write("Enter size of fish: ");
        input_fish_size = Convert.ToDouble(ReadLine());
        while(input_fish_size != -1)
        {
            fish_size += input_fish_size;
            ++total_fish_number;
            average_fish_size = fish_size/total_fish_number;
            Write("Enter size of fish or enter " + ENDLOOP + " to quit: ");
            input_fish_size = Convert.ToDouble(ReadLine());
        }
        
        WriteLine("Total number of fish collected: " + total_fish_number);
        WriteLine("Total sizes of fish: " + fish_size);
        WriteLine("Average size of fish: " + average_fish_size);
    }
}