using System.Text;

namespace Kutyák
{
    class Vizsgalat
    {
        string nev;
        string fajta;
        DateTime utolsoVizsgalat;
        int eletkor;

        public string Nev
        {
            get
            {
                return this.nev;
            }

            set
            {
                this.nev = value;
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
        public DateTime UtolsoVizsgalat
        {
            get
            {
                return this.utolsoVizsgalat;
            }

            set
            {
                this.utolsoVizsgalat = value;
            }
        }
        public int Eletkor
        {
            get
            {
                return this.eletkor;
            }

            set
            {
                this.eletkor = value;
            }
        }

        public Vizsgalat(string sor, Dictionary<int, string> kutyafajták, Dictionary<int, string> kutyanevek)
        {
            string[] adatok = sor.Split(';');
            this.Fajta = kutyafajták[Convert.ToInt32(adatok[1])];
            this.Nev = kutyanevek[Convert.ToInt32(adatok[2])];
            this.Eletkor = Convert.ToInt32(adatok[3]);
            this.UtolsoVizsgalat = Convert.ToDateTime(adatok[4]);
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

            List<Vizsgalat> vizsgálatok = File.ReadAllLines("../../../Kutyák.csv", Encoding.UTF8).Skip(1).Select(sor => new Vizsgalat(sor, kutyafajták, kutyanevek)).ToList();

            
            Console.ReadKey();

        }
    }
}
