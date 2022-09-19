using System;
using System.Collections.Generic;

/*
 Our favorite super-spy action hero Sam is back from his mission in the previous exam, and he has finally found some time to go on a holiday. He is taking his wife somewhere nice and they’re going to have a really good time, but first, they have to get there. Even on his holiday trip, Sam is still going to run into some problems and the first one is, of course, getting to the airport. Right now, he is stuck in a traffic jam at a very active crossroads where a lot of accidents happen.
Your job is to keep track of traffic at the crossroads and report whether a crash happened or everyone passed the crossroads safely and our hero is one step closer to a much-desired vacation.
The road Sam is on has a single lane where cars queue up until the light goes green. When it does, they start passing one by one during the green light and the free window before the intersecting road’s light goes green. During one second only one part of a car (a single character) passes the crossroads. If a car is still at the crossroads when the free window ends, it will get hit at the first character that is still in the crossroads.
Input
•	On the first line, you will receive the duration of the green light in seconds – an integer in the range [1-100]
•	On the second line, you will receive the duration of the free window in seconds – an integer in the range [0-100]
•	On the following lines, until you receive the "END" command, you will receive one of two things:
	A car – a string containing any ASCII character, or
	The command "green" indicates the start of a green light cycle
A green light cycle goes as follows:
•	During the green light, cars will enter and exit the crossroads one by one
•	During the free window, cars will only exit the crossroads
Output
•	If a crash happens, end the program and print:
"A crash happened!"
"{car} was hit at {characterHit}."
•	If everything goes smoothly and you receive an "END" command, print:
"Everyone is safe."
"{totalCarsPassed} total cars passed the crossroads."
Constraints
•	The input will be within the constraints specified above and will always be valid. There is no need to check it explicitly.
Examples
Input	Output

10
5
Mercedes
green
Mercedes
BMW
Skoda
green
END

        Everyone is safe.
        3 total cars passed the crossroads.
 */
namespace _10._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queuedCars = new Queue<string>();
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());
            int totalCarsPassed = 0;
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                if (input == "green" && queuedCars.Count > 0)
                {
                    string currentCar = queuedCars.Dequeue();
                    Queue<char> passingCarChars = new Queue<char>(currentCar);
                    
                    for (int i = 0; i < greenLightDuration; i++)
                    {
                        if (passingCarChars.Count > 0)
                        {
                            passingCarChars.Dequeue();
                            if (passingCarChars.Count == 0) totalCarsPassed++;
                        }
                        else if (queuedCars.Count > 0)
                        {
                            currentCar = queuedCars.Dequeue();
                            foreach (char ch in currentCar)
                                passingCarChars.Enqueue(ch);
                            passingCarChars.Dequeue();
                        }
                    }
                    for (int i = 0; i < freeWindowDuration; i++)
                    {
                        if (passingCarChars.Count > 0)
                        {
                            passingCarChars.Dequeue();
                            if (passingCarChars.Count == 0) totalCarsPassed++;
                        }
                    }

                    if (passingCarChars.Count > 0)
                    {
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{currentCar} was hit at {passingCarChars.Peek()}.");
                        return;
                    }
                }

                else if (input != "green")
                {
                    queuedCars.Enqueue(input);
                }
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
        }

    }
}
