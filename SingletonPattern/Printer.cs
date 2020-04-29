using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
   public sealed class Printer
    {
        private static int counter = 0;
        /*No Thread-Safe Singleton
         private static Printer instance = null;
        public static Printer GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Printer();
                return instance;
            }
        }
        
        private Printer()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
       */

        /* Thread -Safe
         private static readonly object Instancelock = new object();
         private Printer()
         {
             counter++;
             Console.WriteLine("Counter Value " + counter.ToString());
         }
         private static Printer instance = null;

         public static Printer GetInstance
         {
             get
             {
                 lock (Instancelock)
                 {
                     if (instance == null)
                     {
                         instance = new Printer();
                     }
                     return instance;
                 }
             }
         }
        */

        /* Double-checked locking
         private static readonly object Instancelock = new object();
          private Printer()
          {
              counter++;
              Console.WriteLine("Counter Value " + counter.ToString());
          }
          private static Printer instance = null;

          public static Printer GetInstance
          {
              get
              {
                  if (instance == null)
                  {
                      lock (Instancelock)
                      {
                          if (instance == null)
                          {
                              instance = new Printer();
                          }

                      }
                  }
                  return instance;
              }
          }
        */
        //Eager Loding
        private Printer()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static readonly Printer singleInstance = new Printer();

        public static Printer GetInstance
        {
            get
            {
                return singleInstance;
            }
        }
        public string PrintDetails(string message)
        {
            Console.WriteLine(message);
            return message;

        }
    }

}
