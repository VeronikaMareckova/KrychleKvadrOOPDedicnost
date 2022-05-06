using System;

namespace KrychleKvadrDedicnost
{
    class Program
    {
        static void Main(string[] args)
        {
            //OBJEKT 
            Krychle krychle1 = new Krychle(5);
            
                //vypis 2
            krychle1.VypisNazevObrazce();
            Console.WriteLine(krychle1.GetA());
            Console.WriteLine(krychle1.VypocetObjemu());
            Console.WriteLine(krychle1.VypocetPovrchu());

            //OBJEKT
            Kvadr kvadr1 = new Kvadr(5, 4, 8);
            kvadr1.VypisNazevObrazce();
            Console.WriteLine(kvadr1.GetA());
            Console.WriteLine(kvadr1.GetB());
            Console.WriteLine(kvadr1.GetC());
            Console.WriteLine(kvadr1.VypocetObjemu());
            Console.WriteLine(kvadr1.VypocetPovrchu());



            //kontrola
            //krychle1.SetA(-5);
            //Console.WriteLine(krychle1.GetA());


            //vypis1
            //zavolani funkce - ulozeni do promenne
            //double vysledek = krychle1.VypocetObjemu();
            //Console.WriteLine(vysledek);


        }
    }
}
