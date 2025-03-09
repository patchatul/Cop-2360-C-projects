using System;
using static System.Console;

class RaisePuppyProgram
{
    public static void Main()
    {
        Write("Enter your salary: $");//salary $97500
        double salary = Convert.ToDouble(ReadLine());
        double raisePercent = 0.042;
        double raiseAmount = 3750;
        SalaryRaisePercent(salary, raisePercent);
        Write("\n");
        SalaryRaiseAmount(salary, raiseAmount);
    }
    //1st overloaded method w/ 2 parameters double salary, double raisePercent 0.042
    private static double SalaryRaisePercent(double salary, double percent)
    {
        double salaryTimesPercent = salary * percent;
        double totalSalaryTimesPercent = salary + salaryTimesPercent;
        WriteLine("The initial salary is $" + salary);
        WriteLine("The raise is $" + salaryTimesPercent);
        WriteLine("Total salary after raise percent is $" + totalSalaryTimesPercent);
        return totalSalaryTimesPercent;
    }  
    //2nd overloaded method w/ 2 parameters double salary, int raiseAmount add 3750
    private static double SalaryRaiseAmount(double salary, double amount)
    {
        double salaryAddsAmount = salary + amount;
        WriteLine("The initial salary is $" + salary);
        WriteLine("The raise is $" + amount);
        WriteLine("Total salary after raise amount is $" + salaryAddsAmount);
        return salaryAddsAmount;
    }
}
// 2 overloaded methods w/ 2 parameters calculate raise to initial salary then display total salary