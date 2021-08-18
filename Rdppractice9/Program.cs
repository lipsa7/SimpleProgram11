using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rdppractice9
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 1;
            int[] arr = new int[30];

            for(int i = 0; i <= l;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                l = arr[0];
            }

            Userprogramcode.findRepeatedIntegers(arr);
            Console.ReadKey();
        }
    }

    class Userprogramcode
    {
        public static void findRepeatedIntegers(int[] arr) 
        {
            ArrayList arr1 = new ArrayList();
            int flag = 0;

            for(int i = 1; i <= arr[0]; i++)
            {
                if (arr[i] >= 0)
                {
                    int c = 0;
                    for(int j = 1; j <= arr[0]; j++)
                    {
                        if (arr[i] == arr[j])
                            c++;
                    }

                    if(c>1)
                    {
                        if (!(arr1.Contains(arr[i])))
                            arr1.Add(arr[i]);
                    }
                }
                else
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                arr1.Sort();
                int c1 = 0;
                foreach(int i in arr1)
                {
                    c1++;
                }
                if (c1 == 0)
                    Console.WriteLine("No repeated numbers");
                else
                    foreach(int i in arr1)
                    {
                        Console.WriteLine(i);
                    }

            }
            else
            {
                Console.WriteLine("Array contains negative numbers");
            }

        }
        

    }
}
