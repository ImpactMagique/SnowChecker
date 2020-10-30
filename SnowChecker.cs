using System;
using System.Collections.Generic;
using System.Windows;

    class SnowChecker
    {
        public static int threads = 50;
        public static string proxyType;
        public static List<string> proxiesList = new List<string>();
        
        static void Main(string[] args)
        {
            Console.Title = StaticUtils.NAME + " " + StaticUtils.VERSION;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to SnowChecker ! Please choose a number.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1 - Spotify Checker");
            Console.WriteLine("2 - Leave");

            int input = Convert.ToInt32(Console.ReadLine());

            switch(input)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("How many threads ? (default 50)");
                    SnowChecker.threads = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Select proxy type [HTTP, SOCKS4, SOCKS5]");
                    SnowChecker.proxyType = Console.ReadLine().ToUpper();
                    Console.WriteLine("Choose your proxies");
                    
                    break;
                case 2:  
                    SnowChecker.closeApplication();
                    break;
            }

            Console.Read();
        }

        private static void closeApplication()
        {
            for (int i = 5; i > 0; i--)
            {
                Console.Clear();
                Console.WriteLine("Closing in " + i + " seconds");
                System.Threading.Thread.Sleep(1000);
            }

            System.Environment.Exit(1);
        }

        
    }
