using System;

namespace Insert_Elemenet
{
    class Program
    {
        static void Main(string[] args)
        {


            int index_number;
            int valuee;
            int[] arr1 = new int[5];
            int[] arr2 = new int[6];
                Console.WriteLine("Enter The Array Element");
            for (int i = 0; i <arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("=====================");
            Console.WriteLine("Enter Index Numnber");
            index_number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The value");
            valuee = int.Parse(Console.ReadLine());
            Console.WriteLine("=====================");
            for (int i = 0; i < arr2.Length; i++)
            {

                if(i < index_number)
                {
                    arr2[i] = arr1[i];
                }
                else if(i==index_number)
                {
                    arr2[i] = valuee;
                }
                else
                {
                    arr2[i] = arr1[i-1];
                }
            }


            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            

            Console.ReadLine();
        }
    }
}
