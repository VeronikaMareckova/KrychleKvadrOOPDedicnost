using System;
using System.Collections.Generic;
using System.Text;

namespace KrychleKvadrDedicnost
{
    public class Krychle
    {
        //atributy
        protected double a;
        
        //Konstruktor
        public Krychle(double a)
        {
            this.a = a;
        }

        //GET metody
        public double GetA()
        {
            return a;
        }

        //SET metody
        public void SetA(double value)
        {
            if (value > 0) 
               a = value; //kontrola kladne cislo
        }

        //Metoda pro vypocet Objemu
        public virtual double VypocetObjemu()
        {
            return a * a * a;
        }

        //Metoda pro vypocet Povrchu
        public virtual double VypocetPovrchu()
        {
            return 6 * a * a;
        }

        //Metoda kdo jsem
        public virtual void VypisNazevObrazce()
        {
            Console.WriteLine("Krychle");
        }

    }
}
