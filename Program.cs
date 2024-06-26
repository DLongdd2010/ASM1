using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name"); 
            string Name = Console.ReadLine();
            Console.WriteLine("Type of customer \n 1: Household customer \n 2: Administrative agency, public services \n 3: Production units \n 4: Business services");
            int Toc = int.Parse(Console.ReadLine());
            Console.WriteLine("Last month’s water meter readings");
            int lastMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("This month’s water meter readings");
            int thisMonth = int.Parse(Console.ReadLine());
            double consumption = thisMonth - lastMonth;
            double price = 0;

            if (Toc == 1) 
            {
                Console.WriteLine("People");
                int people = int.Parse(Console.ReadLine());
                consumption = consumption / people;
                if (consumption <= 10)
                {
                    price = consumption * people * 5.973;
                }
                else if (consumption <= 20)
                {
                    price = consumption * people * 7.052;
                }
                else if (consumption <= 30)
                {
                    price = consumption * people * 7.052;
                }
                else if (consumption > 30)
                {
                    price = consumption * people * 15.929;
                }
            }
            else if (Toc == 2) 
            {
                price = consumption * 9.955;
            }
            else if (Toc == 3) 
            {
                price = consumption * 11.615;
            }
            else if (Toc == 4) 
            {
                price = consumption * 22.068;
            }
            else
            {
                Console.WriteLine("Error!");
            }

            double VAT = 0.1 * price;
            double EPF = 0.1 * price;
            double Total = VAT + EPF + price;
            
            bill(Name, thisMonth, lastMonth, price, VAT, EPF, consumption, Total);
            
            Console.Read();
        }
        static double bill(string Name, int thisMonth, int lastMonth, double price, double VAT, double EPF, double consumption, double Total)
        {

            Console.WriteLine("-------Bill-------");
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Thismonth:" + thisMonth + " m3 ");
            Console.WriteLine("Lastmonth:" + lastMonth + " m3 ");
            Console.WriteLine("Consumption:" + consumption + " m3 ");
            Console.WriteLine("Price:" + price + " VND ");
            Console.WriteLine("VAT:" + VAT + " VND ");
            Console.WriteLine("EPD:" + EPF + " VND ");
            Console.WriteLine("Total:" + Total + " VND ");
            Console.WriteLine("------------------");
            Console.Read();

            return Total;
        }
    }
    
}
