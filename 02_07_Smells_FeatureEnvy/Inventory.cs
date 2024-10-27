using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_07_Smells_FeatureEnvy;

public class Inventory
{
    public string Item { get; set; }
    public int Stock { get; set; }

    public bool IsInStock()
    {
        return Stock > 0;
    }
}
