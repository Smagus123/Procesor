using System;

namespace Zaliczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj zawartość rejestru AX");
            string AX = Console.ReadLine();

            Console.WriteLine("Podaj zawartość rejestru BX");
            string BX = Console.ReadLine();

            Console.WriteLine("Podaj zawartość rejestru CX");
            string CX = Console.ReadLine();

            Console.WriteLine("Podaj zawartość rejestru DX");
            string DX = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Podaj pierwszy rejestr rozkazu MOV");
                string pierwszy = Console.ReadLine();
                Console.WriteLine("Podaj drugi rejestr rozkazu MOV");
                string drugi = Console.ReadLine();

                if(pierwszy == "AX" && drugi == "AX")
                {
                    AX = AX;
                }
                else if (pierwszy == "AX" && drugi == "BX")
                {
                    AX = BX;
                }
                else if (pierwszy == "AX" && drugi == "CX")
                {
                    AX = CX;
                }
                else if (pierwszy == "AX" && drugi == "DX")
                {
                    AX = DX;
                }
                else if (pierwszy == "BX" && drugi == "AX")
                {
                    BX = AX;
                }
                else if (pierwszy == "BX" && drugi == "BX")
                {
                    BX = BX;
                }
                else if (pierwszy == "BX" && drugi == "CX")
                {
                    BX = CX;
                }
                else if (pierwszy == "BX" && drugi == "DX")
                {
                    BX = DX;
                }
                else if (pierwszy == "CX" && drugi == "AX")
                {
                    CX = AX;
                }
                else if (pierwszy == "CX" && drugi == "BX")
                {
                    CX = BX;
                }
                else if (pierwszy == "CX" && drugi == "CX")
                {
                    CX = CX;
                }
                else if (pierwszy == "CX" && drugi == "DX")
                {
                    CX = DX;
                }
                else if (pierwszy == "DX" && drugi == "AX")
                {
                    DX = AX;
                }
                else if (pierwszy == "DX" && drugi == "BX")
                {
                    DX = BX;
                }
                else if (pierwszy == "DX" && drugi == "CX")
                {
                    DX = CX;
                }
                else if (pierwszy == "DX" && drugi == "DX")
                {
                    DX = DX;
                }
                else
                {
                    Console.WriteLine("Błędne dane rejestrów procesora");
                }
                Console.WriteLine("Aktualny stan rejestrów procesora po wykonaniu rozkazu MOV:");
                Console.WriteLine("AX: " + AX);
                Console.WriteLine("BX: " + BX);
                Console.WriteLine("CX: " + CX);
                Console.WriteLine("DX: " + DX);
                Console.WriteLine("Naciśnij ENTER");
                Console.ReadKey();

            }
        }
    }
}
