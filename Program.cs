using System;
using System.Globalization;
using tpmodul8_103022300009;

namespace tpmodul8_103022300009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CovidConfig covidConfig = new CovidConfig();

            string satuan = covidConfig.config.satuan_suhu;

            Console.Write($"Berapa suhu badan anda saat ini? Dalam nilai {satuan}: ");
            double suhu = double.Parse(Console.ReadLine());

            Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala deman? ");
            int hariDemam = int.Parse(Console.ReadLine());

            Console.WriteLine("");


            bool suhuNormal = false;

            if (satuan == "celcius")
            {
                suhuNormal = suhu >= 36.5 && suhu <= 37.5;
            }
            else if (satuan == "fahrenheit")
            {
                suhuNormal = suhu >= 97.7 && suhu <= 99.5;
            }

            bool hariAman = hariDemam < covidConfig.config.batas_hari_demam;

            if (suhuNormal && hariAman)
            {
                Console.WriteLine(covidConfig.config.pesan_diterima);
            }
            else
            {
                Console.WriteLine(covidConfig.config.pesan_ditolak);
            }


        }
    }
}
