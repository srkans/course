using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void list(int[] repo)
        {
            foreach(int piece in repo)
            {
                Console.WriteLine(piece);
            }
        }

        static void changeStock(int[] repo, int index, int value, bool add)
        {
            if (add)
            {
                repo[index] += value;
            }
            else
            {
                repo[index] -= value;
            }
        }

        static void Main(string[] args)
        {
            int[] repo1 = { 12, 25, 46 };
            int[] repo2 = { 20, 50, 66 };

            list(repo1);
            list(repo2);

            changeStock(repo1, 0, 12, true);
            changeStock(repo2, 2, 33, false);

            list(repo1);
            list(repo2);
        }
    }
}
