using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.ObjectModel;

namespace MetalappsAutomation    //DO NOT change the namespace name
{
	public class SalesDetails   //DO NOT change the class name
    {
        //Implement the fields and properties as per description
        private int salesId;
        private string customerName;
        private int noOfUnits;
        private double netAmount;

        public int SalesId{
            get{return salesId;}
            set{salesId=value;}
        }
        public string CustomerName{
            get{return customerName;}
            set{customerName=value;}
        }
        public int NoOfUnits{
            get{return noOfUnits;}
            set{noOfUnits=value;}
        }
        public double NetAmount{
            get{return netAmount;}
            set{netAmount=value;}
        }

    }
}

namespace MetalappsAutomation //DO NOT change the namespace name
{
	public  class Metalapps            //DO NOT change the class name
	{
		//Implement the property as per the description
		//Implement the methods as per the description
        public void CalculateNetAmount(SalesDetails details){
            details.NetAmount=0;            
            if(details.NoOfUnits>5 && details.NoOfUnits<=10){
                details.NetAmount=(details.NoOfUnits*75350-((details.NoOfUnits*75350)*0.02));
            }
            else if(details.NoOfUnits>10 && details.NoOfUnits<=15){
                details.NetAmount=(details.NoOfUnits*75350-((details.NoOfUnits*75350)*0.05));
            }
            else if(details.NoOfUnits>15 && details.NoOfUnits<=20){
                details.NetAmount=(details.NoOfUnits*75350-((details.NoOfUnits*75350)*0.08));
            }
            else if(details.NoOfUnits>20){
                details.NetAmount=(details.NoOfUnits*75350-((details.NoOfUnits*75350)*0.1));
            }                
        }
	}
    
}



namespace MetalappsAutomation  //DO NOT change the namespace name
{
    class DBHandler  //DO NOT change the class name
    {

       //Implement the methods as per the description
        List<SalesDetails> myColl = new List<SalesDetails>();
        public void add_details(SalesDetails sd2){
            myColl.Add(sd2);
        }
        public void whole_details(){
            for (int i=0;i<myColl.Count;i++){
                Console.WriteLine("Sales Id :"+myColl[i].SalesId);
                Console.WriteLine("Customer name :"+myColl[i].CustomerName);
                Console.WriteLine("Net Amount :"+myColl[i].NetAmount);
                Console.WriteLine("**********");
            }
       }
    }
}

namespace MetalappsAutomation     //DO NOT change the namespace name
{
    public class Program          //DO NOT change the class name
    {
        static void Main(string[] args)         //DO NOT change the 'Main' method signature
        {
            Boolean add_another=true;
            DBHandler db=new DBHandler();
            do
            {
                SalesDetails sd=new SalesDetails();
                Metalapps ma=new Metalapps();
                Console.WriteLine("Enter the sales Id :");
                sd.SalesId=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Customer Name :");
                sd.CustomerName=Console.ReadLine();
                Console.WriteLine("Enter the No of units sold :");
                sd.NoOfUnits=Convert.ToInt32(Console.ReadLine());           
                try{
                    if(sd.NoOfUnits<=5){
                        throw new System.ArgumentOutOfRangeException();
                    }
                    else{
                        ma.CalculateNetAmount(sd);
                        Console.WriteLine("Sales sample bill");
                        Console.WriteLine("************");
                        Console.WriteLine("Sales Id :"+sd.SalesId);
                        Console.WriteLine("Customer Name :"+sd.CustomerName);
                        Console.WriteLine("Number of Units Sold :"+sd.NoOfUnits);
                        Console.WriteLine("Net Amount :"+sd.NetAmount);
                        db.add_details(sd);
                    }
                }
                catch(ArgumentOutOfRangeException)
                {
                    Console.WriteLine("No Sales For units below 5");
                }
                Console.WriteLine("do you wish to add another bill(y/n)");
                String s=Console.ReadLine();
                if(s=="y"){
                    add_another=true;
                }
                else{
                    add_another=false;
                }

            }while(add_another==true); 
            Console.WriteLine("total entry of details");
            Console.WriteLine("*********");
            db.whole_details();

        }
    }

}
