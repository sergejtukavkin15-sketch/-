using System;

class StringComparisonDemo
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = "hello";
        string str3 = "Hello";
        string str4 = "World";
        string text = "C# Programming Language";

        Console.WriteLine("=== Демонстрация сравнения строк ===\n");


        Console.WriteLine($"1. Compare(\"{str1}\", \"{str2}\"): {string.Compare(str1, str2)}");
        Console.WriteLine($"   Compare(\"{str1}\", \"{str3}\"): {string.Compare(str1, str3)}");
        Console.WriteLine($"   Compare(\"{str1}\", \"{str4}\"): {string.Compare(str1, str4)}");


        Console.WriteLine($"\n2. CompareOrdinal(\"{str1}\", \"{str2}\"): {string.CompareOrdinal(str1, str2)}");
        Console.WriteLine($"   CompareOrdinal(\"{str1}\", \"{str1}\"): {string.CompareOrdinal(str1, str1)}");


        Console.WriteLine($"\n3. Equals(\"{str1}\", \"{str2}\"): {str1.Equals(str2)}");
        Console.WriteLine($"   Equals(\"{str1}\", \"{str3}\"): {str1.Equals(str3)}");
        Console.WriteLine($"   string.Equals(\"{str1}\", \"{str3}\"): {string.Equals(str1, str3)}");


        Console.WriteLine($"\n4. \"{str1}\" == \"{str2}\": {str1 == str2}");
        Console.WriteLine($"   \"{str1}\" == \"{str3}\": {str1 == str3}");
        Console.WriteLine($"   \"{str1}\" != \"{str4}\": {str1 != str4}");


        Console.WriteLine($"\n5. IndexOf в \"{text}\":");
        Console.WriteLine($"   IndexOf('P'): {text.IndexOf('P')}");
        Console.WriteLine($"   IndexOf(\"Prog\"): {text.IndexOf("Prog")}");
        Console.WriteLine($"   IndexOf('z'): {text.IndexOf('z')}");


        Console.WriteLine($"\n6. Contains в \"{text}\":");
        Console.WriteLine($"   Contains(\"Programming\"): {text.Contains("Programming")}");
        Console.WriteLine($"   Contains(\"Java\"): {text.Contains("Java")}");
    }

       
}
