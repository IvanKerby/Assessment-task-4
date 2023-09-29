using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I am your GST Calculator. Press 'Enter' to continue!");
            Console.WriteLine("Enter Product Name: ");
            string item = Console.ReadLine();

            
            Console.WriteLine("Enter Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Item cost:$ ");
            double itemCost = double.Parse(Console.ReadLine());

            Console.WriteLine("Select option (1 for adding GST, 2 for Removing GST): ");
            int option = int.Parse(Console.ReadLine());

            double gstRate = 0.15;

            double originalPrice;
            double newPrice;

            if (option == 1)
            {
                //Adiing GST
                originalPrice = itemCost * quantity;
                newPrice = originalPrice + (originalPrice * gstRate);
            }
            else if (option == 2)
            {
                //Removing GST
                originalPrice = (itemCost * 3) / 23 * quantity;
                newPrice = itemCost * quantity;
            }
            else
            {
                //Write invalid if user inputs neither 1 or 2
                Console.WriteLine("Invalid option");
                return;
            }
            //Print results
            Console.WriteLine("Item: " + item);
            Console.WriteLine("Original price: " + originalPrice);
            Console.WriteLine("New Price with GST: " + newPrice);

            Console.ReadKey();
        }
    }
}
