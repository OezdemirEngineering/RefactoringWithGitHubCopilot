using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_8_Smells_BigClasses;

public class OrderProcessor
{
    // Kundeninformationen
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }

    // Bestellpositionen
    private List<string> items = new List<string>();
    private List<double> prices = new List<double>();

    // Zahlungsinformationen
    public string PaymentMethod { get; set; }
    public double TotalAmount { get; private set; }
    public bool PaymentStatus { get; private set; }

    // Bestellstatus
    public string OrderStatus { get; private set; }

    public OrderProcessor(string customerName, string customerEmail, string paymentMethod)
    {
        CustomerName = customerName;
        CustomerEmail = customerEmail;
        PaymentMethod = paymentMethod;
        OrderStatus = "Pending";
    }

    // Methoden für Bestellpositionen
    public void AddItem(string item, double price)
    {
        items.Add(item);
        prices.Add(price);
        TotalAmount += price;
    }

    public void DisplayItems()
    {
        Console.WriteLine("Items in the order:");
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"- {items[i]}: ${prices[i]:0.00}");
        }
    }

    // Zahlungsabwicklung
    public void ProcessPayment()
    {
        // Simulierter Zahlungsprozess
        PaymentStatus = PaymentMethod == "Credit Card";
        if (PaymentStatus)
        {
            Console.WriteLine("Payment successful.");
            OrderStatus = "Paid";
        }
        else
        {
            Console.WriteLine("Payment failed.");
            OrderStatus = "Pending";
        }
    }

    // Bestellstatus anzeigen
    public void DisplayOrderStatus()
    {
        Console.WriteLine($"Order Status: {OrderStatus}");
    }
}

