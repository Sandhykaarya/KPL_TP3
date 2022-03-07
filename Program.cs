using System;


namespace tpmodul3_1302204002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KodePos kp = new KodePos();

            Console.WriteLine("Kode Pos: " + kp.getKodePos(Console.ReadLine()));
        }
    }
}