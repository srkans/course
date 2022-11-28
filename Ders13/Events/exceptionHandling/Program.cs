using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 0, c = 0;
            int[] numbers = { 13, 3, 18 };

            try  //we will use try at possible root of the error
            {
                // File.Open("deneme.txt", FileMode.Open);
                c = a / b;
                numbers[3] = 11;
            }
            catch(IndexOutOfRangeException e) //catch the error
            {
                Console.WriteLine("Error! : Index");
            }

            catch(DivideByZeroException e) //use catch for every kind of error
            {
                Console.WriteLine("Error! : Divide by Zero");
            }

            catch(Exception e) //if you don't know what is the reason of error
            {
                Console.WriteLine(e.Message);
            }

            finally // this block will work on any condition
            {
                Console.WriteLine("this block will work on any condition");
            }



        }
    }
}
