﻿using System;

namespace teamcity
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.MyMethod();
            mc.MyMethod();
            Console.ReadKey();
        }
    }
}
