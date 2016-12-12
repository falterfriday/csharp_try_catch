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
                string[] fruit = { "Apples", null, "Oranges" };
                for (int i = 0; i <= fruit.Length; i++)
                {
                    if (fruit[i] == null)
                    {
                        throw (new ArgumentNullException());
                    }
                    
                    Console.WriteLine(fruit[i]);
                }
            }
            //name the exception and console it
            //.Message prints out a more concise error message
            //similar to Ruby's getFullMessages method
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("- index problem");
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("- null problem");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally block has been reached");
            }
            
        }
    }
}
