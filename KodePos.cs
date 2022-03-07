using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302204002
{
    internal class KodePos
    {
        String[] klr = { "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura", "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja" };
        String[] kode = { "40266", "40287", "40267", "40256", "40287", "40286", "40286", "40286", "40272", "40274", "40273" };

        public string getKodePos(String klr)
        {
            for(int i = 0; i < this.klr.Length; i++)
            {
                if(this.klr[i] == klr)
                {
                    return this.kode[i];
                }
            }
            return "Kelurahan tidak ditemukan";
        }
    }
}
