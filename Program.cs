using System;

namespace BranchesApp.Example2
{
    class Program
    {
        static void Main()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            char Operation = (char)Console.Read();
            int result = 0;

            if(A == null || B == null)
            {
                Console.WriteLine("Error in A or B");
            }
            else
            {
                switch (Operation)
                {
                    case '+':
                        result = A + B;
                        Console.WriteLine(result);
                        break;
                    case '-':
                        result = A - B;
                        Console.WriteLine(result);
                        break;
                    case '*':
                        result = A * B;
                        Console.WriteLine(result);
                        break;
                    case '/':
                        result = A / B;
                        Console.WriteLine(result);
                        break;
                    default: throw new Exception();
                }
            }
        }
    }
}
