namespace Fundamentals.Core;

using Fundamentals.Types;

class CoreRunner
{
    public static void Init()
    {
        Console.WriteLine("Hello World");

        // Namespace
        Namespace.SubNamespace1.Program.Init();
        Namespace.SubNamespace2.Program.Init();

        // Types
        Types.Init();
    }
}