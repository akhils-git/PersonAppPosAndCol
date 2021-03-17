using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAppPosAndCol.ProjectAssets
{
    public class DatabaseConnections
    {
        public static string MSSQLConnectionString = GetConnectionStringFromFile();
           private static string GetConnectionStringFromFile()
        {
            return File.ReadAllText(@"C:/Connection.txt");
        }

    }
    
}
