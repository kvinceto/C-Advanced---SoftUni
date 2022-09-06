using System;
using System.Collections.Generic;
/*
 Create a program that simulates the queue that forms during a traffic jam. During a traffic jam, only N cars can pass the crossroads when the light goes green. Then the program reads the vehicles that arrive one by one and adds them to the queue. When the light goes green N number of cars pass the crossroads and for each, a message "{car} passed!" is displayed. When the "end" command is given, terminate the program and display a message with the total number of cars that passed the crossroads.
Input
•	On the first line, you will receive N – the number of cars that can pass during a green light
•	On the next lines, until the "end" command is given, you will receive commands – a single string, either a car or "green"
Output
•	Every time the "green" command is given, print out a message for every car that passes the crossroads in the format "{car} passed!"
•	When the "end" command is given, print out a message in the format "{number of cars} cars passed the crossroads."

Examples
Input	                Output
4
Hummer H2
Audi
Lada
Tesla
Renault
Trabant
Mercedes
MAN Truck
green
green
Tesla
Renault
Trabant
end	
                    Hummer H2 passed!
                    Audi passed!
                    Lada passed!
                    Tesla passed!
                    Renault passed!
                    Trabant passed!
                    Mercedes passed!
                    MAN Truck passed!
                    8 cars passed the crossroads.

3
Enzo's car
Jade's car
Mercedes CLS
Audi
green
BMW X5
green
end
                    Enzo's car passed!
                    Jade's car passed!
                    Mercedes CLS passed!
                    Audi passed!
                    BMW X5 passed!
                    5 cars passed the crossroads.
 */
namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCarsThatCanPass = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int counter = 0;

            while (true)
            {
                string cmd = Console.ReadLine();
                if(cmd == "end")
                {
                    break;
                }
                else if (cmd == "green")
                {
                    for (int i = 1; i <= numberOfCarsThatCanPass; i++)
                    {
                        if (cars.Count == 0)
                        {
                            break;
                        }
                        string car = cars.Dequeue();
                        Console.WriteLine($"{car} passed!");
                        counter++;
                    }
                }
                else
                {
                    cars.Enqueue(cmd);
                }
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
