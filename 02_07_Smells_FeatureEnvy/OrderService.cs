using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_07_Smells_FeatureEnvy;

public class OrderService
{
    private Inventory _inventory;

    public OrderService(Inventory inventory)
    {
        _inventory = inventory;
    }

    public int CalculateDeliveryTime()
    {
        if (_inventory.Stock > 20)
        {
            return 1; // 1 Tag bei hohem Lagerbestand
        }
        else if (_inventory.Stock > 0)
        {
            return 3; // 3 Tage bei niedrigem Lagerbestand
        }
        else
        {
            return 7; // 7 Tage, wenn das Produkt nicht auf Lager ist
        }
    }
}
