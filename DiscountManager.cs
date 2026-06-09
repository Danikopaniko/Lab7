using System;

namespace Lab7
{
    public class DiscountManager
    {
        public static void Run()
        {
            Console.WriteLine("\n=== ЗАВДАННЯ 3: ЛАНЦЮЖОК ЗНИЖОК ===");

            Func<double, double> discountChain = (price) => price * 0.95;
            discountChain += (price) => price * 0.90;
            discountChain += (price) => price - 100;

            double startPrice = 1000;
            double finalPrice = startPrice;

            Delegate[] discounts = discountChain.GetInvocationList();

            foreach (Func<double, double> discount in discounts)
            {
                finalPrice = discount(finalPrice);
            }

            Console.WriteLine($"Початкова ціна товару: {startPrice} грн.");
            Console.WriteLine($"Ціна після всіх знижок (ланцюжком): {finalPrice} грн.");
        }
    }
}