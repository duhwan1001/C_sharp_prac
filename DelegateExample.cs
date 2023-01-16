using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C_Hash_prac.DelegateExample;

namespace C_Hash_prac
{
    class DelegateExample
    {
        //public delegate void Delegate(); // 인수와 반환값이 없는 Delegate
        //public delegate int Delegate(string s); // 인수와 반환값이 있는 Delegate
        public delegate void CallBack(); // 콜백함수


        static void Main()
        {
            //Delegate hoge = Hoge;
            //hoge();

            /////////////////////////

            //Delegate countString = CountString;
            //Console.WriteLine(countString("hoge"));

            /////////////////////////
            
            CallBack sayHowAreYou = SayHowAreYou;
            SaySomethingAfterHello(sayHowAreYou);

            /////////////////////////
            
            
        }

        static void Hoge()
        {
            Console.WriteLine("hoge");
        }

        static int CountString(string s)
        {
            return s.Length;
        }

        static void SayHowAreYou()
        {
            Console.WriteLine("How are you");
        }
        
        static void SaySomethingAfterHello(CallBack callback)
        {
            Console.WriteLine("hello");
            callback();
        }
    }

}
