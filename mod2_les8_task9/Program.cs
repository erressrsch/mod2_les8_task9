using System;
class Program
{
    static void Main()
    {
        int testValue = 25;
        int testValueToDisplay = testValue;
        string binarValueToReverse = string.Empty;
        string binarValue = string.Empty;

        for (int i = 0; testValue > 0; i++)
        {
            if (testValue %2 == 0)
            {
                binarValueToReverse += "0";
            }
            else
            {
                binarValueToReverse += "1";
            }
            testValue = testValue / 2;

        }
        for (int i = binarValueToReverse.Length - 1; i >= 0; i--)
        {
            binarValue += binarValueToReverse[i].ToString();
        }
        Console.WriteLine($"The binary notation of the number {testValueToDisplay} is as follows {binarValue} ");
    }
}
