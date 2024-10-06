using System;
class Program
{
    public static void Main()
    {
        // Salesmans  Initials Array
        char[] initials = { 'D', 'E', 'F' };
        double[] sales = new double[3];
        double totalSales = 0;

        while (true)
        {
            Console.WriteLine("Enter the salesman's initial. Z to quit: ");
            char salesman = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

            if (salesman == 'Z')
            {
                break;
            }

            // Valid Entry?
            int index = Array.IndexOf(initials, salesman);
            if (index == -1)
            {
                Console.WriteLine("Invalid salesman initial. Enter a different initial.");
                continue;
            }

            // Sales Amount
            Console.WriteLine("Enter the salesman's sales: $ ");
            double saleAmount = Convert.ToDouble(Console.ReadLine());

            // Combined Sales Amount
            sales[index] += saleAmount;
            totalSales += saleAmount;

            // Output Total Sales
            Console.WriteLine("Total sales: $" + totalSales);

            // Highest Seller
            double highestSale = sales[0];
            int highestIndex = 0;
            for (int i = 1; i < sales.Length; i++)
            {
                if (sales[i] > highestSale)
                {
                    highestSale = sales[i];
                    highestIndex = i;
                }
            }

            switch (initials[highestIndex])
            {
                case 'D':
                    Console.WriteLine("Danielle is the highest seller");
                    break;
                case 'E':
                    Console.WriteLine("Edward is the highest seller");
                    break;
                case 'F':
                    Console.WriteLine("Francis is the highest seller");
                    break;
            }
        }
    }
}
