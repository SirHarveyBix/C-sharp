﻿using System;

namespace FirstClass;
class Program
{
    static void Main(string[] args)
    {
        Car audi = new Car("Audi A4", 125, "pink");
        audi.Drive();
        audi.Details();

        Car bmw = new Car("BMW M5", 350, "mate black");
        bmw.Drive();
        bmw.Details();

        Console.WriteLine("\nif you want a car to stop write down'stop'.");

        string userInput = Console.ReadLine();

        if (userInput!.Contains("stop") || userInput.Contains("Stop"))
        {
            if (userInput.Contains("bmw")
                || userInput.Contains("BMW"))
            {
                bmw.Stop();
            }
            else if (userInput.Contains("audi")
                || userInput.Contains("Audi"))
            {
                audi.Stop();
            }
        }
        else
        {
            audi.Drive();
        }

        Console.Read();
    }
}
