using System;


namespace tpmodul3_1302204002 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KodePos kp = new KodePos();

            Console.WriteLine(kp.getKodePos(Console.ReadLine()));
        }
    }
}