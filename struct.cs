using System;

namespace ConsoleApp1
{
    struct vector
    {
        public int x;
        public int y;

        public vector(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "X: " + x + "y:" + y;
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            vector v1 = new vector();      // new 사용 가능
            vector v2;                     // new 사용 안해도 가능
            vector v3 = new vector(5, 10); // 명시적 생성자 가능

            Console.WriteLine(v3);
        }
    }
}