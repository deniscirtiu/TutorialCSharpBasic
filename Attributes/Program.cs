﻿#undef DEBUG
using System;
using System.Diagnostics;

public class Myclass
{
    [Conditional("DEBUG")]

    public static void Message(string msg)
    {
        Console.WriteLine(msg);
    }
}

public class MyClass
{
    [Obsolete("Don't use OldMethod, use NewMethod instead", true)]

    static void OldMethod()
    {
        Console.WriteLine("It is the old method");
    }
    static void NewMethod()
    {
        Console.WriteLine("It is the new method");
    }

    class Test
    {
        static void function1()
        {
            Myclass.Message("In Function 1.");
            function2();
        }
        static void function2()
        {
            Myclass.Message("In Function 2.");
        }
        public static void Main()
        {
            Myclass.Message("In Main function.");
            function1();
            Console.ReadKey();
        }
    }
}