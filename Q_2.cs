using System;
namespace problem2{
    public class main
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the name of the product :");
            string product=Console.ReadLine();
            Console.WriteLine("Enter the price of the product :");
            int price=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("is product on SALE (yes/no) :");
            String sale=Console.ReadLine();
            Console.WriteLine("Enter number of product sold in day 1");
            int day1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of product sold in day 2");
            int day2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of product sold in day 3");
            int day3=Convert.ToInt32(Console.ReadLine());    
            Console.WriteLine(product);
            if(sale == "yes")
            {
                double actual_day1=price-(price*0.07);
                double actual_day2=actual_day1-(actual_day1*0.07);
                double actual_day3=actual_day2-(actual_day2*0.07);
                Console.WriteLine("Day 1 sales total :"+(actual_day1*day1));
                Console.WriteLine("Day 1 sales total :"+(actual_day2*day2));
                Console.WriteLine("Day 1 sales total :"+(actual_day3*day3));
            }
            else{
                Console.WriteLine("Day 1 sales total :"+day1*price);
                Console.WriteLine("Day 1 sales total :"+day2*price);
                Console.WriteLine("Day 1 sales total :"+day3*price);
            }
        }
    }
}
