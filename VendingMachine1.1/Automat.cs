using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace VendingMachine1._1
{
    public class Kasa
    {
        private int novac;
        private int[] novcanice;
        private static int[] velicinaNovcanica = { 5, 10, 20, 50, 100, 200 };
        public Kasa()
        {
            novac = 0;
            novcanice = new int[6];
            for (int i = 0; i < 6; i++)
            {
                novcanice[i] = 0;
            }
        }
        public Kasa(int novac, int[] novcanice)
        {
            this.novac = novac;
            this.novcanice = novcanice;
        }
        public bool dodajNovac(int novac)
        {
            int[] novcanice = { 5, 10, 20, 50, 100, 200 };
            for (int i = 0; i < 6; i++)
            {
                if (novcanice[i] == novac)
                {
                    this.novac += novac;
                    this.novcanice[i]++;
                    return true;
                }
            }
            return false;

        }
        public void oduzmiNovac(int novac)
        {
            int i = novcanice.Length - 1;
            while (i >= 0)
            {
                if (novcanice[i] > 0)
                {
                    if (velicinaNovcanica[i] <= novac)
                    {
                        novac -= velicinaNovcanica[i];
                        novcanice[i]--;
                    }
                }
                if (novcanice[i] == 0 || velicinaNovcanica[i] > novac) i--;
            }

        }

        public int Novac { get { return novac; } }
        public void Kusur()
        {
            MessageBox.Show($"Vaš kusur je \n 5 : {novcanice[0]}, 10 : {novcanice[1]}, 20 : {novcanice[2]}, 50 : {novcanice[3]}, 100 : {novcanice[4]}, 200 : {novcanice[5]}");
        }
        public int dajNovcanice(int i) { return novcanice[i]; }
    }
    public class Artikal
    {
        public int id;
        string naziv;
        string slikaUrl;
        int rokTrajanja;
        int cena;
        DateTime datumDodavanja;
        public Artikal(int id)
        {
            this.id = id;
            StreamReader citac = new StreamReader(@"..\..\tabelaArtikala.txt");
            for (int i = 0; i < id - 1; i++) { citac.ReadLine(); }
            string temp = citac.ReadLine();
            string[] strs = temp.Split(' ');
            naziv = strs[0];
            slikaUrl = strs[1];
            cena = int.Parse(strs[2]);
            rokTrajanja = int.Parse(strs[3]);
            citac.Close();
            citac.Dispose();
            datumDodavanja = DateTime.Today;
        }
        public string Ime
        {
            get { return Ime; }
        }
        public string SlikaUrl
        {
            get { return slikaUrl; }
        }
        public bool Pokvareno()
        {
            return (DateTime.Today >= datumDodavanja.AddDays(rokTrajanja));
        }


    }
    public class Automat
    {
        
        private Kasa kasa;
        private List<Artikal> artikli;
        private string naziv;
        public Automat(string ime)
        {
            naziv = ime;
            if (!Directory.Exists(@"Automati"))
            {
                Directory.CreateDirectory(@"Automati");
            }
            if (File.Exists(@"Automati\" + ime + ".txt"))
            {
                StreamReader citac = new StreamReader(@"Automati\" + ime + ".txt");
                string[] nln = citac.ReadLine().Split(' ');
                int[] novcanice = new int[6];
                int suma = 0;
                int[] velicinaNovcanica = { 5, 10, 20, 50, 100, 200 };
                for (int i = 0; i < 6; i++) { novcanice[i] = int.Parse(nln[i]); suma += novcanice[i]*velicinaNovcanica[i]; }
                kasa = new Kasa(suma, novcanice);
                string nl = citac.ReadLine();
                artikli = new List<Artikal>();
                while (nl != null)
                {
                    artikli.Add(new Artikal(int.Parse(nl)));
                    nl = citac.ReadLine();
                }
                citac.Close();
                citac.Dispose();
            }
            else
            {
                kasa = new Kasa();
                artikli = new List<Artikal>();
            }
        }
        public void dodajArtikal(int id)
        {
            artikli.Add(new Artikal(id));
        }
        public void dodajNovac(int novac)
        {
            kasa.dodajNovac(novac);
        }
        public void oduzmiNovac(int novac)
        {
            kasa.oduzmiNovac(novac);
        }
        public int Novac()
        {
            return kasa.Novac;
        }
        public Artikal DajArtikal(int i)
        {
            return artikli[i];
        }
        public int Duzina()
        {
            return artikli.Count();
        }
        public string getUrl(int i)
        {
            return artikli[i].SlikaUrl;
        }
        public void Save()
        {
            StreamWriter pisac = new StreamWriter(@"Automati\" + naziv + ".txt");
            string nln = $"{kasa.dajNovcanice(0)} {kasa.dajNovcanice(1)} {kasa.dajNovcanice(2)} {kasa.dajNovcanice(3)} {kasa.dajNovcanice(4)} {kasa.dajNovcanice(5)}";
            pisac.WriteLine(nln);
            foreach(var i in artikli)
            {
                pisac.WriteLine(i.id);
            }
            pisac.Close();
            pisac.Dispose();
        }
    }
}
