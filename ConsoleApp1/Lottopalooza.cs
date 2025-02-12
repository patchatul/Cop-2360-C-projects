using System;
using static System.Console;

class Lottopalooza
{
    static void Main()
    {
        int[] recentFloridaLotto = {4, 6, 7, 15, 32, 48};
        const string DATE = "02/08/2025"; 
        bool isMatched = false;
        Write("Enter your lotto number: ");
        int inputLottoNum = Convert.ToInt16(ReadLine());
        
        for (int x = 0; x < recentFloridaLotto.Length; ++x)
        {
            if(inputLottoNum == recentFloridaLotto[x])
            {
                isMatched = true;
                x = recentFloridaLotto.Length; //break out of loop when it's matched
            }
        }
        if(isMatched)
        {
            WriteLine("We have an amazing winner!");
        }
        else
        {
            WriteLine("We have a super loser!");
        }        
        WriteLine("The date is " + DATE);
    }
}