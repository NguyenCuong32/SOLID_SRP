using System;

namespace OCP;

public interface IAccount
{
    /// <summary>
    /// To calculate balance
    /// </summary>
    /// <returns></returns>
    double CalculateBalance(Account account);
}
