using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singelton
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintUser1Details(),
                () => PrintUser2details(),
                () => PrintUser3details()
               
                );
            Console.ReadLine();
        }
        private static void PrintUser1Details()
        {
            Singleton user1 = Singleton.GetInstance;
            user1.PrintDetails();
        }
        private static void PrintUser2details()
        {
            Singleton user2 = Singleton.GetInstance;
            user2.PrintDetails();
        }
        private static void PrintUser3details()
        {
            Singleton user3 = Singleton.GetInstance;
            user3.PrintDetails();
        }
        

    }
}
