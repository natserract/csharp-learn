namespace Fundamentals.Types;

// C# is a strongly typed language. 
// Every variable and constant has a type, as does every expression that evaluates to a value.
class Types
{
    static void Variables()
    {
        var val = 5; // Inferred as int type
        int val2 = val + 10; // Manual declare
        Console.WriteLine("Variables " + val2);
    }

    static void Integer()
    {
        int a; // Declaration only
        a = 5; // Assigned to new value

        int b = 5;
        int c = a + b;
        Console.WriteLine("Integer " + c);
    }

    static void String()
    {
        string words = """
        Hello
        """;
        words += @" World";
        Console.WriteLine("String " + words);
    }

    static void Boolean()
    {
        bool boolVal = true;
        Console.WriteLine("Boolean " + boolVal);
    }

    static void Float()
    {
        float pi = 2.5f; // The f suffix is used to indicate that the literal value is of type float
        Console.WriteLine("Float " + pi);
    }

    static void Array()
    {
        string[] names = ["Alfin", "Surya",];
        /** 
        Similar like `names`
        
        new[] { "John", "Jane", "Bob" }:
        - This syntax is called an array initializer or implicitly typed array creation.
        - It allows you to declare and initialize an array without explicitly specifying its type.

        string[]:
        - This is an explicit declaration of an array of strings.
        - It explicitly specifies the type of the array elements as strings.
        **/
        var names2 = new[] { "Surya", "Alfin" };
        foreach (string name in names)
        {
            Console.WriteLine("Array " + name);
        }

        // Polymorphic (NOPE)
        // var polym = new [] { 1, "Alfin"};
        // polym[3] = 2;
    }

    static void Object()
    {
        // In C#, the object type is a special type that is the base type for all other types 
        // It is a reference type that can hold values of any other type, including value types and reference types.
        object obj = 1;
        obj = new[] { "Alfin" };
        if (obj is string[] stringArray)
        {
            Console.WriteLine("Object " + stringArray[0]);
        }
    }

    static void Tuple()
    {
        var person = (25, "John");
        Console.WriteLine("Tuple person 1" + person.Item1 + person.Item2);

        Tuple<int, string> person2 = new Tuple<int, string>(25, "John");
        Console.WriteLine("Tuple person 2" + person2.Item1 + person2.Item2);
    }

    public static void Init()
    {
        Variables();
        Integer();
        String();
        Boolean();
        Float();
        Object();
        Tuple();
    }
}