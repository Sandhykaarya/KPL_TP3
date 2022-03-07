using System;


namespace tpmodul3_1302204002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KodePos kp = new KodePos();
            DoorMachine dm = new DoorMachine();

            // Kode Pos
            // Console.WriteLine("Kode Pos: " + kp.getKodePos(Console.ReadLine()));

            // Door Machine
            // Ini infinite loop, tutup program saat sudah selesai digunakan
            // Command : BukaPintu, KunciPintu
            // dm.machine();
        }
    }
}