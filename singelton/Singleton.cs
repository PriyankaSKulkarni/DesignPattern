using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singelton
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static readonly object Instancelock = new object();
        private Singleton()
        {            
            Console.WriteLine("Singleton instance created...Counter Value " + counter.ToString());
        }

        ~Singleton() { }

        private static Singleton instance = null;

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (Instancelock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }
        public void PrintDetails()
        {
            counter++;
            
            Console.WriteLine("Counter Value " + counter.ToString());
            
        }
    }

}
