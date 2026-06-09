using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ClosureDemo.Run();

            Console.WriteLine("\n=== ЗАВДАННЯ 2: ДЕЛЕГАТ ПРОТИ ПОДІЇ ===");

            BankTerminal terminal = new BankTerminal();

            terminal.OnMoneyWithdraw += (sum) => Console.WriteLine($"[SMS Notification] Знято: {sum} грн.");

            terminal.OnMoneyWithdraw = null;
            terminal.OnMoneyWithdraw?.Invoke(999999);

            terminal.OnMoneyWithdrawSecure += (sum) => Console.WriteLine($"[Secure Notification] Знято: {sum} грн.");

            // terminal.OnMoneyWithdrawSecure = null; 
            // terminal.OnMoneyWithdrawSecure.Invoke(500);

            terminal.Withdraw(500);

            DiscountManager.Run();

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}