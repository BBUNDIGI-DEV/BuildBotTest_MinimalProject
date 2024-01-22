using System;

public static class HelloWorld
{
    static void Main()
    {
#if DebugConfig
        Console.WriteLine("WE ARE IN THE DEBUG CONFIGURATION");
#endif
        Console.WriteLine("Hello, world!");
    }


    public void TestMethod_Swap(ref int a, ref int b)
    {
        var temp = a;
        a = b;
        b = temp;
    }
}
