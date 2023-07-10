using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloopsAndArrays
{
    internal class Program
    {

        static void RankedFilms() 
        {
            var favFilms = new string[4];
            

            Console.WriteLine("What are your favorite films? ");

            for (int i = 0; i < favFilms.Length; i++)
            {
                favFilms[i] = Console.ReadLine();
            }

            Console.WriteLine("\nDid you enter them in order of your favorite? (Y/N)");
            
            var ifRanked = Console.ReadLine();

            if (ifRanked != "Y")
            {
                Console.WriteLine("\nHow would you rank them based on how you entered them up top? ");

                for (int y = 0; y < favFilms.Length; y++)
                {
                    favFilms[y] = Console.ReadLine();
                    
                }
            }
            Console.WriteLine("\n Films Ranked:");
            for (int i = 0; i < favFilms.Length; i++)
            {
                int rank = i + 1;
                Console.WriteLine(rank + ". " + favFilms[i]);

            }
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            /*string[] movies = { "The Thing", "The Last Dragon", "Everything Everywhere All At Once", "Shaun of the Dead" };

            //the array.Length runs a loop of everything in the array
            for (int i = 0; i < movies.Length; i++)
            {
                int rank = i + 1;
                Console.WriteLine(rank + ". " + movies[i]);

            }
            Console.ReadLine();*/

            RankedFilms();
        }
    }
}
