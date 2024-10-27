using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_10_Smells_MiddleMan;

public class OrderService
{
    public int OrderId { get; set; }
    public string Status { get; set; }

    public void ProcessOrder()
    {
        Console.WriteLine($"Processing order {OrderId}");
        Status = "Processed";
    }

    public void CancelOrder()
    {
        Console.WriteLine($"Cancelling order {OrderId}");
        Status = "Cancelled";
    }
}
