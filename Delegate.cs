using System;

public class Mathematics
{
    delegate int CalcDelegate(int x, int y);

    static int Add(int x, int y) { return x + y; }
    static int Substract(int x, int y) { return x - y; }
    static int Multiply(int x, int y) { return x * y; }
    static int Divide(int x, int y) { return x / y; }

    CalcDelegate[] methods;

    public Mathematics()
    {
        methods = new CalcDelegate[] { Mathematics.Add, Mathematics.Substract, Mathematics.Multiply, Mathematics.Divide };
    }

    public void Calculate(char opcode, int x, int y)
    {
        switch(opcode)
        {
            case '+':
                Console.WriteLine("+:" + methods[0](x,y));
                break;

            case '-':
                Console.WriteLine("-:" + methods[1](x,y));
                break;

            case '*':
                Console.WriteLine("*:" + methods[2](x,y));
                break;

            case '/':
                Console.WriteLine("/:" + methods[3](x,y));
                break;
        }
    }
}

namespace ConsoleApp1
{
    class Program
    {
        delegate void WorkDelegate(char arg1, int arg2, int arg3);

        static void Main(string[] args)
        {
            Mathematics math = new Mathematics();
            WorkDelegate work = math.Calculate;

            work('+', 10, 5);
            work('-', 10, 5);
            work('*', 10, 5);
            work('/', 10, 5);
        }
    }
}