namespace Fundamentals.Core;

class CoreRunner
{
    public static void Init()
    {
        Console.WriteLine("Hello World");

        // Namespace
        Namespace.SubNamespace1.Program.Init();
        Namespace.SubNamespace2.Program.Init();
    }
}