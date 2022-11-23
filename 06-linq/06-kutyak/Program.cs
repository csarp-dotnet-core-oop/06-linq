using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyák
{
    class Vizsgálat
    {
        string név;
        string fajta;
        DateTime utolsóVizsgálatIdeje;
        int életkor;

        public string Név
        {
            get
            {
                return this.név;
            }

            set
            {
                this.név = value;
            }
        }
        public string Fajta
        {
            get
            {
                return this.fajta;
            }

            set
            {
                this.fajta = value;
            }
        }
        public DateTime UtolsóVizsgálatIdeje
        {
            get
            {
                return this.utolsóVizsgálatIdeje;
            }

            set
            {
                this.utolsóVizsgálatIdeje = value;
            }
        }
        public int Életkor
        {
            get
            {
                return this.életkor;
            }

            set
            {
                this.életkor = value;
            }
        }

        public Vizsgálat(string sor, Dictionary<int, string> kutyafajták, Dictionary<int, string> kutyanevek)
        {
            string[] adatok = sor.Split(';');
            this.Fajta = kutyafajták[Convert.ToInt32(adatok[1])];
            this.Név = kutyanevek[Convert.ToInt32(adatok[2])];
            this.Életkor = Convert.ToInt32(adatok[3]);
            this.UtolsóVizsgálatIdeje = Convert.ToDateTime(adatok[4]);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kutyanevek = new Dictionary<int, string>();
            kutyanevek = File.ReadAllLines("../../../KutyaNevek.csv", Encoding.UTF8).Skip(1).ToDictionary(sor => Convert.ToInt32(sor.Split(';')[0]), sor => sor.Split(';')[1]);
            Dictionary<int, string> kutyafajták = new Dictionary<int, string>();
            kutyafajták = File.ReadAllLines("../../../KutyaFajták.csv", Encoding.UTF8).Skip(1).ToDictionary(sor => Convert.ToInt32(sor.Split(';')[0]), sor => sor.Split(';')[1]);

            List<Vizsgálat> vizsgálatok = File.ReadAllLines("../../../Kutyák.csv", Encoding.UTF8).Skip(1).Select(sor => new Vizsgálat(sor, kutyafajták, kutyanevek)).ToList();

            Console.WriteLine("3. feladat: Kutyanevek száma: {0}", kutyanevek.Count());



            Console.ReadLine();

        }
    }
}
