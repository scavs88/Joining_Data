using System;
using System.Collections.Generic;
using System.Linq;

namespace Joining_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            exercise3();
           

        }



        static void exercise12()
        {

            List<CustomerOrder> orders = new List<CustomerOrder>
            {
                new CustomerOrder("Acme Hardware", "Mouse", 25, 3),
                new CustomerOrder("Acme Hardware", "Keyboard", 45, 2),
                new CustomerOrder("Falls Realty", "Macbook", 800, 2),
                new CustomerOrder("Julie's Morning Diner", "iPad", 525, 1),
                new CustomerOrder("Julie's Morning Diner", "Credit Card Reader", 45, 1)
            };

            var distinctOrders = orders.GroupBy(o => o.CustomerName).Select(o => o.First());
            foreach (CustomerOrder name in distinctOrders)
            {

                Console.WriteLine(name.CustomerName);
                Console.WriteLine(string.Format("\t{0, -20} {1, -20} {2, -20} {3,0}", "Item", "Price", "Quantity", "Total"));
                decimal total = 0;
                for (int i = 0; i < orders.Count; i++)
                {
                    if (name.CustomerName == orders[i].CustomerName)
                    {
                        Console.WriteLine(orders[i].ToString());
                        total += orders[i].Quantity * orders[i].Price;
                    }
                }
                Console.WriteLine($"\tTotal \t\t\t\t\t {total}");
            }



        }





        static void exercise3()
        {


            List<CustomerOrder> orders = new List<CustomerOrder>
            {
                new CustomerOrder("Acme Hardware", "Mouse", 25, 3),
                new CustomerOrder("Acme Hardware", "Keyboard", 45, 2),
                new CustomerOrder("Falls Realty", "Macbook", 800, 2),
                new CustomerOrder("Julie's Morning Diner", "iPad", 525, 1),
                new CustomerOrder("Julie's Morning Diner", "Credit Card Reader", 45, 1)
            };




            Console.WriteLine(string.Format("{0, -25}{1, -20}{2, -20}{3, -20}{4, 0}", "Customer", "Item", "Price", "Quantity", "Total"));
            foreach (CustomerOrder groupByName in orders)
            {
                Console.Write(string.Format("{0, -25}", groupByName.CustomerName));
                for (int i = 0; i < orders.Count; i++)
                {
                    if (groupByName.CustomerName == orders[i].CustomerName)
                    {
                        if (i == 1 || i == 4) // This will check for empty spaces when the duplicate is taking care of.
                        {
                            string addSpace = string.Format("{0, -25}", "");
                            Console.WriteLine(string.Format("{0, 0}{1, -20}{2, -20}{3, -20}{4, 0}", addSpace, orders[i].Item, orders[i].Price, orders[i].Quantity, orders[i].Price * orders[i].Quantity));
                        }
                        else
                        {
                            Console.WriteLine(string.Format("{0, 0}{1, -20}{2, -20}{3, -20}{4, 0}", "", orders[i].Item, orders[i].Price, orders[i].Quantity, orders[i].Price * orders[i].Quantity));
                        }
                    }
                }
            }



        }


    }

    
}
