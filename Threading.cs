using System;
using System.Threading;

// 다중 스레드에서 단일 변수 사용
// namespace

class program
{
    int number = 0;

    static void Main(string[] args)
    {
        program pg = new program();

        Thread t1 = new Thread(threadFunc);
        Thread t2 = new Thread(threadFunc);

        t1.Start(pg);
        t2.Start(pg);

        t1.Join();
        t2.Join();

        Console.WriteLine(pg.number);
    }

    static void threadFunc(object inst)
    {
        program pg = inst as program;

        for(int i=0; i < 100000; i++) // Monitor 클래스를 사용하지 않으면, 루프 횟수를 늘릴때마다 숫자를 예측할 수 없음
        {
            //Monitor.Enter(pg); // 스레드 동기화, Enter로 진입하고 Exit으로 탈출한다.
            //try
            //{
            //    pg.number++;
            //}
            //finally
            //{ 
            //    Monitor.Exit(pg);
            //}

            lock(pg) // try/finally + Monitor.Enter/Exit 코드와 완전히 같은 역할을 하는 예약어
            {
                pg.number++;
            }
    
            
        }
    }
}
