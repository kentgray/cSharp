using System;


public delegate void HelloFunctionDelegate(string Message);

class Program
    {
        public static void Main()
        {
        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
        del("Hello from Delegate");
        }

       public static void Hello(string strMessage)
        {
        Console.WriteLine(strMessage);
        }
    }





