using System;  
namespace problem1
{
    public class main  
    {  
        public int[,] GetArray(int a){
            int size=a;
            int[,] arr=new int[size,size];//declaration of 2D array  
       
            for (int k=0;k<size;k++)
            {
                for (int l=0;l<size;l++)
                {
                    if(k==l){
                        arr[k,l]=0;
                    }
                    else if(k>l){
                        arr[k,l]=-1;
                    }
                    else{
                        arr[k,l]=1;
                    }
                }
            }
            return arr;
        
        }
        public static void Main(string[] args)  
        {  
            Console.WriteLine("enter the matrix size");
            int matrix_size=Convert.ToInt32(Console.ReadLine());
            main m=new main();
            int[,] matrix = new int[matrix_size,matrix_size];
            matrix=m.GetArray(matrix_size);
            for(int i=0;i<matrix_size;i++){  
                for(int j=0;j<matrix_size;j++){  
                    Console.Write(matrix[i,j]+" ");  
                }  
                Console.WriteLine(); 
            }  
        }  
    }
}
