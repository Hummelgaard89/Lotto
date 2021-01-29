using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Laver en brugerkupon
            int[] Brugertal = new int[7];
            Random ran = new Random();
            int Bi;
            //
            Console.WriteLine("Dine tal er følgende:\n");
            for (Bi = 0; Bi < Brugertal.Length; Bi++)
            {
                int Bj = 0;
                while (true)
                {
                    Bj = ran.Next(1, 20);
                    if (!Contains(Brugertal, Bj)) break;
                }
                Brugertal[Bi] = Bj;
                Console.WriteLine(Brugertal[Bi]);
            }
            //End brugerkupon
            //
            //Laver en vinder kupon(trækker de 7 vindertal)
            int[] Vindertal = new int[7];
            int Vi;
            //
            Console.WriteLine("\n\n\nVindertallene er følgende:\n");
            for (Vi = 0; Vi < Vindertal.Length; Vi++)
            {
                int Vj = 0;
                while (true)
                {
                    Vj = ran.Next(1, 20);
                    if (!Contains(Vindertal, Vj)) break;
                }
                Vindertal[Vi] = Vj;
                Console.WriteLine(Vindertal[Vi]);
            }
            //End Vinderkupon
            //
            //tjekker hvor mange brugeren har rigtige
            int Rigtige = 0;
            Console.WriteLine("\n\nAntal brugeren har rigtige\n");
            for (int BK = 0; BK < 7; BK++)
            {
                for (int VT = 0; VT < 7; VT++)
                {
                    if (Brugertal[BK] == Vindertal[VT])
                    {
                        Rigtige++;
                        BK++;
                    }
                    else if (Brugertal[BK] != Vindertal[VT])
                    {
                        VT++;
                    }
                }
            }//END RIGTIGE
            //
            //Fortæller hvad du vinder af præmie med x antal rigtige
            switch (Rigtige)
            {
                case 0:
                    Console.WriteLine("Du vandt desværre ikke noget denne gang, prøv igen næste uge.");
                    break;
                case 1:
                    Console.WriteLine("Du vandt desværre ikke noget denne gang, prøv igen næste uge.");
                    break;

                case 2:
                    Console.WriteLine("Du vandt 49 kr.");
                    break;

                case 3:
                    Console.WriteLine("Du vandt 171 kr.");
                    break;

                case 4:
                    Console.WriteLine("Du vandt 1.358 kr.");
                    break;

                case 5:
                    Console.WriteLine("Du vandt 15.556 kr.");
                    break;

                case 6:
                    Console.WriteLine("Du vandt 139.855 kr.");
                    break;
                case 7:
                    Console.WriteLine("TILLYKKE!!! Du vandt 20.271.035 kr.");
                    break;
            }//END PRÆMIE
            Console.WriteLine(Rigtige);
            Console.ReadLine();
        }//END MAIN
        static bool Contains(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value) return true;
            }
            return false;
        }//END CONTAINS


    }//END CLASS PROGRAM
}//END NAMESPACE LOTTO
