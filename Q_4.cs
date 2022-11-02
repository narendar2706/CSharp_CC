using System;

namespace problem4
{
    public class Q4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the eompany name");
            string company_name = Console.ReadLine();
            Console.WriteLine("enter the employee name");
            string employee_name = Console.ReadLine();
            Console.WriteLine("enter the project name");
            string project_name = Console.ReadLine();
            Console.WriteLine("enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
            entireMessage(company_name, employee_name, project_name, year);

        }
        public static void entireMessage(string comp_name, string emp_name, string proj_name , int year)
        {
            headerMessage(comp_name);
            Console.WriteLine(emp_name);
            Console.WriteLine(proj_name);
            footerMessage(year);

        }
        public static void headerMessage(string com_name1)
        {
            Console.WriteLine(com_name1 + " Employee Information");
        }
        public static void footerMessage(int year1)
        {
            Console.WriteLine("CopyRight " + year1);
            Console.WriteLine("All Rights Reserved.");
        }
        

    }

}
