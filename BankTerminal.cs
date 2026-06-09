using System;

namespace Lab7
{
    public class BankTerminal
    {
        public Action<int> OnMoneyWithdraw;

        public event Action<int> OnMoneyWithdrawSecure;

        public void Withdraw(int amount)
        {
            Console.WriteLine($"[Термінал 27] Ініційовано зняття коштів: {amount} грн.");
            OnMoneyWithdraw?.Invoke(amount);
            OnMoneyWithdrawSecure?.Invoke(amount);
        }
    }
}