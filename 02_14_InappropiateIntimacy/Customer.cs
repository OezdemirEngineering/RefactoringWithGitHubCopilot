using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_14_InappropiateIntimacy;

public class Customer
{
    public string Name { get; set; }
    public BankAccount Account { get; set; }

    public Customer(string name, BankAccount account)
    {
        Name = name;
        Account = account;
    }

    public void DisplayAccountInfo()
    {
        // Direkter Zugriff auf BankAccount-Felder (Inappropriate Intimacy)
        Console.WriteLine($"Kunde: {Name}, Konto: {Account.AccountNumber}, Kontostand: {Account.Balance}");
    }

    public void PerformTransaction(double amount, bool isDeposit)
    {
        // Direkter Zugriff und Manipulation der BankAccount-Felder
        if (isDeposit)
        {
            Account.Balance += amount; // Direkte Änderung am Kontostand
            Console.WriteLine($"{Name} hat {amount} auf Konto {Account.AccountNumber} eingezahlt.");
        }
        else
        {
            if (Account.Balance >= amount)
            {
                Account.Balance -= amount; // Direkte Änderung am Kontostand
                Console.WriteLine($"{Name} hat {amount} von Konto {Account.AccountNumber} abgehoben.");
            }
            else
            {
                Console.WriteLine($"Nicht genügend Guthaben für Abhebung bei Konto {Account.AccountNumber}.");
            }
        }
    }
}
