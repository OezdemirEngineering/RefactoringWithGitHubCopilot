using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_5_Smells_Globals;

public static class GlobalConfig
{
    public static string DatabaseConnectionString = "Server=myServer;Database=myDB;";
    public static int MaxConnections = 10;
}
