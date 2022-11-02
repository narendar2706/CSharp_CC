using System;

namespace problem5
{
    public class Q5{
        public static double GetGrossPay(int hours){
            double pay;
            if(hours<57){
                pay=hours*80;
            }
            else{
                pay=((hours-56)*120)+(56*80);
            }
            return pay;
        }
        public static double CalculateTax(double gpay){
            double taxAmount=gpay*0.02;
            return taxAmount;
        }
        public static double CalculateNetPay(int hours){
            double g_pay=GetGrossPay(hours);
            double net_pay=g_pay-CalculateTax(g_pay);
            return net_pay;
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("enter the number of hours worked :");
            int hours=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The calculated Net Pay is "+CalculateNetPay(hours));
        }
    }
}
