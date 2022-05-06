using System;
using System.Collections.Generic;
using System.Text;

namespace KrychleKvadrDedicnost
{
    class Kvadr : Krychle
    {
        //atributy
        private double b;
        private double c;

        //zdedeny KONSTRUKTOR
        public Kvadr(double a, double b, double c) : base(a)
        {
            this.b = b;
            this.c = c;
        }
        
        //GET metody
        public double GetB()
        {
            return b;
        }

        public double GetC()
        {
            return c;
        }

        //SET metody
        public void SetB(double value)
        {
            if (value > 0)
                b = value;
        }

        public void SetC(double value)
        {
            if (value > 0)
                c = value;
        }

        //Metoda pro vypocet Objemu
        public override double VypocetObjemu()
        {
            return a*b*c;
        }

        //Metoda pro vypocet Povrchu
        public override double VypocetPovrchu()
        {
            return 2 * (a * b + a * c + b * c);
        }

        //Metoda kdo jsem
        public override void VypisNazevObrazce()
        {
            Console.WriteLine("Kvadr");
        }
    }
}
