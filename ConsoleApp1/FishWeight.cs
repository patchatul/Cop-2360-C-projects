using System;

class FishWeight
{
    static void Main()
    {
        int Fish1 = 23;
        int Fish2 = 10;
        int Fish3 = 30;
        int Fish4 = 15;
        int Fish5 = 8;
        float AverageFishWeight = (float) (Fish1 + Fish2 + Fish3 + Fish4 + Fish5) / 5;
        string OneDecimalAverageFishWeight = AverageFishWeight.ToString("F1");
        Console.WriteLine(OneDecimalAverageFishWeight);
    }
}