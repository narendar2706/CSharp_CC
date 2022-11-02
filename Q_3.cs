using System;
namespace problem3
{
    class Q3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Total Students Placed in CS: ");
            int cs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total Students Placed in MECH: ");
            int mech = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total Students Placed in MET: ");
            int met = Convert.ToInt32(Console.ReadLine());
            if(cs>mech && cs!=met){
                if(cs>met){
                    Console.WriteLine("Highest Placement CS");
                }
            }
            else if(mech>met && mech!=cs){
                if(mech>cs){
                    Console.WriteLine("Highest Placement MECH");
                }    
            }
            else if(met>cs && met!=mech){
                if(met>mech){
                    Console.WriteLine("Highest Placement MET");
                }
            }
            else if(cs==mech && cs>met){
                Console.WriteLine("Highest Placement CS");
                Console.WriteLine("Highest Placement MECH");                
            }
            else if(cs==met && cs>mech){
                Console.WriteLine("Highest Placement CS");
                Console.WriteLine("Highest Placement MET");
            }
            else if(met==mech && met>cs){
                Console.WriteLine("Highest Placement MECH");
                Console.WriteLine("Highest Placement MET");
            }
            else{
                Console.WriteLine("Highest Placement CS");
                Console.WriteLine("Highest Placement MECH");
                Console.WriteLine("Highest Placement MET");
            }
        }

    }
}
