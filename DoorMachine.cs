using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302204002
{
    internal class DoorMachine
    {
        enum Door {Terkunci, Terbuka};

        public void machine()
        {
            Door door = Door.Terkunci;
            String[] kondisi = { "Terkunci", "Terbuka" };
            while(true)
            {
                Console.WriteLine(kondisi[(int)door]);
                Console.Write("Masukkan instruksi : ");
                string command = Console.ReadLine();
                switch(door)
                {
                    case Door.Terkunci:
                        if(command == "BukaPintu")
                        {
                            door = Door.Terbuka;
                            Console.WriteLine("Pintu tidak terkunci");
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            door = Door.Terkunci;
                            break;
                        }
                    case Door.Terbuka:
                        if (command == "KunciPintu")
                        {
                            door = Door.Terkunci;
                            Console.WriteLine("Pintu terkunci");
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            door = Door.Terbuka;
                            break;
                        }
                }
            }
        }
    }
}
