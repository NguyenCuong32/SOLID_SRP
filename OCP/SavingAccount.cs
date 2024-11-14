using System;

namespace OCP;

public class SavingAccount : IAccount
{
    public double CalculateBalance(Account account)
    {
        return account.Balance + account.Balance * 0.5;
    }
}
