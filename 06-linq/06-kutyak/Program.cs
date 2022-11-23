using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Kutyák
{
    class KutyaNev 
    {
        public int Id { get; set; }
        public string Nev { get; set; }

        public KutyaNev(string sor)
        {
            string[] adatok = sor.Split(';');
            this.Id = Convert.ToInt32(adatok[0]);
            this.Nev = adatok[1];
        }
    }

    class Fajta
    {
        public int Id { get; set; } 
        public string Nev { get; set; }
        public string EredetiNev { get; set; }

        public Fajta(string sor)
        {
            string[] adatok = sor.Split(';');
            this.Id = Convert.ToInt32(adatok[0]);
            this.Nev = adatok[1];
            this.EredetiNev = adatok[2];
        }
    }

    class Vizsgalat
    {
        public int Id { get; set; }
        public int FajtaId { get; set; }
        public int NevId { get; set; }
        public int Eletkor { get; set; }
        public DateTime VizsgalatIdo{ get; set; }

        public Vizsgalat(string sor)
        {
            string[] adatok = sor.Split(';');
            this.Id = Convert.ToInt32(adatok[0]);
            this.FajtaId = Convert.ToInt32(adatok[1]);
            this.NevId = Convert.ToInt32(adatok[2]);
            this.Eletkor = Convert.ToInt32(adatok[3]);
            this.VizsgalatIdo = Convert.ToDateTime(adatok[4]);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<KutyaNev> kutyanevek= File.ReadAllLines("../../../KutyaNevek.csv", Encoding.UTF8).Skip(1).Select(sor => new KutyaNev(sor)).ToList();
            List<Fajta> fajtak = File.ReadAllLines("../../../KutyaFajták.csv", Encoding.UTF8).Skip(1).Select(sor => new Fajta(sor)).ToList();
            List <Vizsgalat> vizsgalatok = File.ReadAllLines("../../../Kutyák.csv", Encoding.UTF8).Skip(1).Select(sor => new Vizsgalat(sor)).ToList();

            Console.WriteLine("3. feladat: Kutyafajták száma: {0}", fajtak.Count());
            Console.WriteLine("3. feladat: Vizsgaálatok száma: {0}", vizsgalatok.Count());
            Console.WriteLine("3. feladat: Kutyanevek száma: {0}", kutyanevek.Count());

            Console.ReadKey();

        }
    }
}
