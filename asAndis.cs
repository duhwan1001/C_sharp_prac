using System;
using System.Net.NetworkInformation;

public class computer
{
    bool powerOn;
    public void Boot() { }
    public void Shutdown() { }
    public void Reset() { }

}

public class Notebook : computer
{
    bool fingerScan;
    public bool HasFingerScanDevice() { return fingerScan; }
}

public class asAndis
{
    static void Main(String[] args) 
    {
        computer pc = new computer();
        Notebook nb = pc as Notebook;

        if (nb != null)
        {
            Console.WriteLine("if문 진입");
            nb.HasFingerScanDevice();
        }

        int n = 5;
        if(n is string)
        {
            Console.WriteLine("변수 n은 String");
        }

        if (n is int)
        {
            Console.WriteLine("변수 n은 int");
        }
    }
    
        
}
