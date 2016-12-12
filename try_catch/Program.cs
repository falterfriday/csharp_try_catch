using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            //try this code
            //if successful, jump to the end of the try/catch block
            //but if there are exceptions 
            //execute code in catch block
            try
            {
                string[] fruit = { "Apples", "Bananas", "Oranges" };
                for (int i = 0; i <= fruit.Length; i++)
                {
                    Console.WriteLine(fruit[i]);
                }
            }
            //name the exception and console it
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
