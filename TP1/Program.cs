using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            float P, T, IMC;//float pour indiquer que l'on va rentrer des nombres à virgule

            Console.WriteLine("Quel est votre poids?");
            P = float.Parse(Console.ReadLine());

            Console.WriteLine("Quel est votre taille?");
            T = float.Parse(Console.ReadLine());

            IMC = (P / (T*T)); //IMC = Poids divisé par la taille x 2 (Poids/Taille*2)

            if (IMC < 16.5)
            {
                Console.WriteLine("Vous êtes en Dénutrition");
            }
            else if ((IMC > 16.5) && (IMC < 18.5))
            {
                Console.WriteLine("Vous êtes en Maigreur");
            }
            else if ((IMC > 18.5) && (IMC < 25))
            {
                Console.WriteLine("Vous êtes en Corpulence normale");
            }
            else if ((IMC > 25)&&(IMC < 30))
            {
                Console.WriteLine("Vous êtes en Surpoids");
            }
            else if ((IMC > 30)&&(IMC < 35))
            {
                Console.WriteLine("Vous êtes en Obésité Modérée");
            }
            else if ((IMC > 35)&&(IMC < 40))
            {
                Console.WriteLine("Vous êtes en Obésité sévère");
            }
            else if (IMC > 40)
            {
                Console.WriteLine("Vous êtes en Obésité morbide ou massive");
            }
            Console.ReadKey();
        }
    }
}
