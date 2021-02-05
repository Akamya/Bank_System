using System;

namespace BANQUE
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte C1 = new Compte(98726, "Philippe", 9000, 900);
            Compte C2 = new Compte(29515, "Patrick", 5819, 451);
            C1.transferer(1300, C2);
            Ecran.mainMenu();
            Console.ReadKey();
        }
    }
}
