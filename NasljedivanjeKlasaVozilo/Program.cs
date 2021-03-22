using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasljedivanjeKlasaVozilo
{
    class Vozilo
    {
        bool JeLiLeti, JeLiPlovi;

        public bool JeLiLeti1 { get => JeLiLeti; set => JeLiLeti = value; }
        public bool JeLiPlovi1 { get => JeLiPlovi; set => JeLiPlovi = value; }

        public void KudaVozi()
        {
            Console.WriteLine("Leti = " + JeLiLeti + "Plovi = " + JeLiPlovi);
        }

        public Vozilo(bool jeLiLeti, bool jeLiPlovi)
        {
            JeLiLeti = jeLiLeti;
            JeLiPlovi = jeLiPlovi;
        }
    }
    class Brod : Vozilo
    {

        public Brod() : base(false, true)
        {
        }
    }
    class Zrakoplov : Vozilo
    {
        public Zrakoplov() : base(true, false)
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Brod Barka = new Brod();
            Zrakoplov Avion = new Zrakoplov();
            Console.WriteLine("Leti barka = " + Barka.JeLiLeti1 + System.Environment.NewLine + "Plovi barka = " + Barka.JeLiPlovi1);
            Console.WriteLine("Leti avion = " + Avion.JeLiLeti1 + System.Environment.NewLine + "Plovi avion = " + Avion.JeLiPlovi1);
            Console.ReadKey();
        }
    }
}
