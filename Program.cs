using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje2
{
    class Stablo
    {
        private bool otpadajuListovi;
        string vrstaStabla;

        public Stablo(bool otpadajuListovi)
        {
            OtpadajuListovi = otpadajuListovi;
        }

        public bool OtpadajuListovi { get => otpadajuListovi; set => otpadajuListovi = value; }
        public override string ToString()
        {
            if(OtpadajuListovi==true)
            { vrstaStabla = "bijelogoricno"; }
            else
            { vrstaStabla = "crnogoricno"; }
            return  ("Otpadaju listovi: "+ OtpadajuListovi+" Vrsta stabla: "+vrstaStabla);    
            
        }
    }
    internal class Program
    {
        /*
         * (26 bodova) Definirajte klasu Stablo sa sljedećim članicama:
varijabla tipa bool otpadajuListovi
varijabla tipa string vrstaStabla
svojstvo OtpadajuListovi (get() i set())
konstruktor Stablo(bool) koji će dodijeliti vrijednost proslijeđenog argumenta varijabli otpadajuListovi
override metode ToString()
Definirajte objekt stablo1 tipa Stablo pomoću konstruktora te proslijedite vrijednost false. Definirajte objekt stablo2 tipa
        Stablo pomoću konstruktora te proslijedite vrijednost true.
Ispišite podatke o objektima koristeći ToString() metodu, na način da ukoliko je vrijednost varijable otpadajuListovi true,
        vrijednost varijable vrstaStabla je bijelogorično, a ukoliko
        je vrijednost varijable otpadajuListovi false, vrijednost varijable vrstaStabla je crnogorično.
         * */
        static void Main(string[] args)
        {
            Stablo stablo1 = new Stablo(false);
            Stablo stablo2 = new Stablo(true);
Console.WriteLine(stablo1.ToString());
            Console.WriteLine(stablo2.ToString());
            Console.ReadKey();
        }
    }
}
