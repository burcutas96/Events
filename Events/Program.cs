using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product harDisk = new Product(50);
            harDisk.ProductName = "Hard Disk";

            Product gsm = new Product(50);
            gsm.ProductName = "GSM";
            gsm.StockControlevent += Gsm_StockControlevent; 

            for (int i = 0; i < 10; i++)
            {
                harDisk.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        private static void Gsm_StockControlevent()
        {
            Console.WriteLine("Gsm about to finish!!!");
        }
       
    }
    
}
