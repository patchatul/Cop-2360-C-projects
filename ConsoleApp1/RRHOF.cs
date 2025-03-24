using System;
using static System.Console;

class RRHOF
{
    public static void Main()
    {
        Inductees inductee1 = new Inductees("ABBA", 2010);
        Inductees inductee2 = new Inductees("JANET JACKSON", 2019);
        Inductees inductee3 = new Inductees("CHER", 2024);
        
        inductee1.OutputMessage();
        inductee2.OutputMessage();
        inductee3.OutputMessage();
    }
}
class Inductees
    {
        public string Artist { get; set;}
        public int Year { get; set;}
        public Inductees(string artist, int year)
        {
            Artist = artist;
            Year = year;
        }
        public void OutputMessage()
        {
            WriteLine("The artist is " + Artist);
            WriteLine("The year of induction is " + Year);
        }
    }
    }