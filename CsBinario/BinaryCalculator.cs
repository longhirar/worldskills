// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class BinaryCalculator
{
    public static string decimalToBin(int dec) 
    {
        int expo = 1;
        
        while (Math.Pow(2, expo) <= dec) {
            expo++;
        }
        expo--; // will be one above because it will increment and then break the loop
        
        string result = "";
        
        while (expo >= 0) {
            if (Math.Pow(2, expo) <= dec) {
                dec -= (int) Math.Pow(2, expo);
                result += "1";
            } else {
                result += "0";
            }
            expo--;
        }
        return result;
    }
    public static int binToDecimal(string bin) 
    {
        int i = 0;
        int result = 0;
        while (i < bin.Length)
        {
            int expo = bin.Length - i - 1;
            if (bin[i] == '1') {
                result += (int) Math.Pow(2, expo);
            }
            
            i++;
        }
        return result;
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("BinaryCalculator!");
        Console.WriteLine ("Test 1 : Decimal to Binary : 2007");
        Console.WriteLine (BinaryCalculator.decimalToBin(2007));
        Console.WriteLine ("Test 2 : Binary to Decimal : 11111010111");
        Console.WriteLine (BinaryCalculator.binToDecimal("11111010111"));
        
        int input;
        
        Console.WriteLine ("Custom Test : Decimal to Binary");
        input = Int32.Parse( Console.ReadLine() );
        Console.WriteLine (BinaryCalculator.decimalToBin(input));
        
        Console.WriteLine ("Custom Test : Binary to Decimal");
        Console.WriteLine (BinaryCalculator.binToDecimal(Console.ReadLine()));
    }
}