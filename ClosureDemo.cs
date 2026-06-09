using System;
using System.Collections.Generic;

namespace Lab7
{
    public class ClosureDemo
    {
        public static void Run()
        {
            Console.WriteLine("\n=== ЗАВДАННЯ 1: ЗАХОПЛЕННЯ КОНТЕКСТУ ===");

            List<Action> actions = new List<Action>();

            for (int i = 1; i <= 5; i++)
            {
                int currentNumber = i;
                actions.Add(() => Console.WriteLine($"Значення з замикання: {currentNumber}"));
            }

            foreach (var action in actions)
            {
                action();
            }
        }
    }
}