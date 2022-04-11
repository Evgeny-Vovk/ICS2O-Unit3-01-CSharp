// Created by: Evgeny
// Created on: Mar 2022
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        //input
        float baseA;
        float baseB;
        float height;

        Console.WriteLine("This program finds the area of a trapezoid.");
        Console.WriteLine("");

        Console.Write("Enter the first base(cm): ");
        baseA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second base(cm): ");
        baseB = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height(cm): ");
        height = Convert.ToInt32(Console.ReadLine());

        //process
        double area = (baseA + baseB) / 2 * height;

        //output
        Console.WriteLine("");
        Console.WriteLine("The area is: " + area.ToString("0.00") + "cm².");

        Console.WriteLine("\nDone.");
    }
}