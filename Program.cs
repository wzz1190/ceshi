﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace picacomic
{
    struct Account
    {
        public string username;
        public string password;
    }
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Log(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            Log(Environment.CurrentDirectory);
            Log(AppDomain.CurrentDomain.BaseDirectory);
            File.WriteAllText(@"3.md", "32222");
        }

        private static void Log(object o)
        {
            
            Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}]{o.ToString()}");

        }


    }
}
