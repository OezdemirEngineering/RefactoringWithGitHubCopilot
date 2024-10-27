using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_2_Smells_DuplicateCode;

public class CustomerService
{
    public bool AddNewCustomer(Customer customer)
    {
        if (string.IsNullOrEmpty(customer.Email) || !customer.Email.Contains("@"))
        {
            Console.WriteLine("Invalid email address.");
            return false;
        }

        if (string.IsNullOrEmpty(customer.Name))
        {
            Console.WriteLine("Name cannot be empty.");
            return false;
        }

        SaveCustomerToDatabase(customer);

        string message = $"Welcome, {customer.Name}!";
        SendEmail(customer.Email, message);

        Console.WriteLine("New customer added successfully.");
        return true;
    }

    public bool UpdateExistingCustomer(Customer customer)
    {
        if (string.IsNullOrEmpty(customer.Email) || !customer.Email.Contains("@"))
        {
            Console.WriteLine("Invalid email address.");
            return false;
        }

        if (string.IsNullOrEmpty(customer.Name))
        {
            Console.WriteLine("Name cannot be empty.");
            return false;
        }

        UpdateCustomerInDatabase(customer);

        string message = $"Hello {customer.Name}, your information has been updated.";
        SendEmail(customer.Email, message);

        Console.WriteLine("Customer updated successfully.");
        return true;
    }

    private void SaveCustomerToDatabase(Customer customer)
    {

    }

    private void UpdateCustomerInDatabase(Customer customer)
    {

    }

    private void SendEmail(string email, string message)
    {
        Console.WriteLine($"Sending email to {email}: {message}");

    }
}
