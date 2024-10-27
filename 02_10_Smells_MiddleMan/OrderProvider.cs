using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_10_Smells_MiddleMan;

internal class OrderProvider
{
    private OrderService _order;

    public OrderProvider(OrderService order)
    {
        _order = order;
    }

    public int GetOrderId()
    {
        return _order.OrderId;
    }

    public string GetStatus()
    {
        return _order.Status;
    }

    public void ProcessOrder()
    {
        _order.ProcessOrder();
    }

    public void CancelOrder()
    {
        _order.CancelOrder();
    }
}
