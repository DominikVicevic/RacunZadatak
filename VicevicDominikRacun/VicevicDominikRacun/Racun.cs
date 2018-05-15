using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VicevicDominikRacun
{
    class Racun
    {
        public static int brojac = 0;
        Racun()
        {

        }

        double iznos, ukupanIznos, popust;

        public double GetIznos()
        {
            return iznos;
        }

        public void SetIznos(double value)
        {
            iznos = value;
        }

        public double GetUkupanIznos()
        {
            return ukupanIznos;
        }

        public void SetUkupanIznos(double value)
        {
            ukupanIznos = value;
        }

        public double GetPopust()
        {
            return popust;
        }

        public void SetPopust(double value)
        {
            popust = value;
        }

        public Racun(double iznos)
        {
            brojac++;
            this.iznos = iznos;
        }
    }
}
