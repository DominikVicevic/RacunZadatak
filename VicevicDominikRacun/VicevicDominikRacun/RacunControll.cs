using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VicevicDominikRacun
{
    class RacunControll
    {
        List<Racun> popisRacuna = new List<Racun>();

        public Racun kreirajRacun(double iznos)
        {
            Racun racun = new Racun(iznos);
            popisRacuna.Add(racun);
            return racun;
        }

        public Racun izracunajPopust(Racun racun)
        {
            double popust = 0;
            double iznos = racun.GetIznos();
            if (iznos > 1000)
            {
                popust = 0.15;
            }
            else if (iznos > 500)
            {
                popust = 0.1;
            }
            else if(iznos > 100)
            {
                popust = 0.05;
            }
            racun.SetPopust(popust);
            return racun;
        }

        public Racun izracunajUkupanIznos(Racun racun)
        {
            double iznos = racun.GetIznos();
            double ukupanIznos = iznos - (iznos * racun.GetPopust());
            racun.SetUkupanIznos(ukupanIznos);
            return racun;
        }

        public String ispisiPodatke(Racun racun)
        {
            string ispis = "Podaci o računu: \n";
            ispis = ispis + Racun.brojac + "\nIznos računa: " + racun.GetIznos() + "\nPopust: " + racun.GetPopust() * 100 + " %"
                + "\nUkupan Iznos: " + racun.GetUkupanIznos()+"\n";
            return ispis;
        }

        public String ispisiSvePodatke()
        {
            string ispis = "";
            foreach(Racun racun in popisRacuna)
            {
                ispis = ispis + "Podaci o računu: \n";
                ispis = ispis + Racun.brojac + "\nIznos računa: " + racun.GetIznos() + "\nPopust: " + racun.GetPopust() * 100 + " %"
                    + "\nUkupan Iznos: " + racun.GetUkupanIznos() + "\n";
            }
            return ispis;
        }
    }
}
