using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int valeurADeviner = new Random().Next(1, 50);//random représente un générateur de nombres pseudo-aléatoires
            int nombreDeCoups = 0;
            bool devine = false;
            Console.WriteLine("TROUVE LE NOMBRE! Il est compris entre 1 et 50");
            while (!devine)
            {
                String saisie = Console.ReadLine();
                int valeurSaisie = 18;// nombre a trouvé
                if (int.TryParse(saisie, out valeurADeviner))
                {
                    if (valeurSaisie == valeurADeviner)// si le nombre a trouvé est bien tapé l'odi dira que c'est bon 
                        devine = true;
                    else
                    {
                        if (valeurSaisie > valeurADeviner)
                            Console.WriteLine("Le nombre à deviner est plus grand que 15");
                        else
                            Console.WriteLine("Le nombre est plus petit que 26");
                    }
                    nombreDeCoups++;
                }
                else
                    Console.WriteLine("La valeur saisie est incorrecte, RECOMMENCE!");
            }
            Console.Write("Vous avez trouvé en " + nombreDeCoups + " coup(s)");
        }
    }
}
