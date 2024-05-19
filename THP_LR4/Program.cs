using System.Numerics;
using Weapons;
using Logic;
using Logic.Interfaceies;
using Logic.Creatories;

class Program
{
    static void Main(string[] args)
    {
        PrintSum printSum = new PrintSum();
        MilitaryUnitCreator militaryUnitCreator = new MilitaryUnitCreator();
        CalculatePrice calculatePrice = new CalculatePrice();
        MilitaryUnit unit = militaryUnitCreator.create();
        
        printSum.Print(calculatePrice.Calculate(unit));
    }
}