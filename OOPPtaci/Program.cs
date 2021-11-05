using System;

namespace OOPPtaci
{
    class Program
    {
        static void Main(string[] args)
        {
            Ptak ptak = new Ptak(100, 50);
            AngryPtak angryPtak = new AngryPtak(100, 50, 50);
            ptak.VypisPtaka();
            ptak.Snez(20);
            ptak.VypisPtaka();
            angryPtak.VypisAngryPtaka();
            angryPtak.Provokuj(5);
            angryPtak.VypisAngryPtaka();
            angryPtak.Snez(100);
            angryPtak.Provokuj(5);
            angryPtak.VypisAngryPtaka();
            Console.ReadKey();
        }
    }
}
