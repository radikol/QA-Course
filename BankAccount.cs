using System;

public class BankAccount
{
    private decimal balance;

    public BankAccount(decimal initialBalance = 0)
    {
        balance = initialBalance;
    }

    public decimal Deposit(decimal amount)
    {
        balance += amount;
        return balance;
    }

    public string Withdraw(decimal amount)
    {
        if (amount > balance)
        {
            return "Error: Insufficient funds";
        }
        balance -= amount;
        return $"New balance: {balance}";
    }

    public decimal GetBalance()
    {
        return balance;
    }
}
