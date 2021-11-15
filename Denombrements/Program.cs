using System;


namespace Denombrements
{
    class Program
    {
        static string initChoix()
        {
            return "";
        }
        //Fonction qui retourne un bool, vérifie que le choix est valide;
        static bool InvalidChoice(string arg)
        {
            if(arg != "0" && arg != "1" && arg != "2" && arg != "3") return true;
            else  return false; 
            
        }
        //Fonction utilisée pour le menu, retourne un string choix;
        static string menu(string choix = "")
        {
            while(InvalidChoice(choix)) {
                
                    Console.WriteLine("Permutation ...................... 1");
                    Console.WriteLine("Arrangement ...................... 2");
                    Console.WriteLine("Combinaison ...................... 3");
                    Console.WriteLine("Quitter .......................... 0");
                    Console.Write("Choix :                            ");
                    choix = Console.ReadLine();
                if (InvalidChoice(choix))
                {
                    Console.WriteLine("saissez un choix valide !");
                }
            }
            return choix;
            

        }
      
        static void Main(string[] args)
        {
            //Initialisation du choix
            string choix = initChoix();
            while (choix != "0")
            {
                choix = menu(choix);

                if (choix == "0") Environment.Exit(0);

                Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                int nombre = int.Parse(Console.ReadLine()); // saisir le nombre

                if (choix == "1")
                {                                                                             
                    long r = 1;
                    for (int k = 1; k <= nombre; k++)
                    {
                        r *= k;
                    }
                    Console.WriteLine(nombre + "! = " + r);
                    choix = initChoix();
                }
                else
                {
                   
                    Console.Write("nombre d'éléments dans le sous ensemble = "); //saisir le sous ensemble
                    int sousEnsemble = int.Parse(Console.ReadLine()); 
                   
                    if (choix == "2")
                    {
                       // calcul de r
                        long resultat = 1;
                        for (int i = (nombre - sousEnsemble + 1); i <= nombre; i++)
                            resultat *= i;
                       //Calcul du resultat final
                        Console.WriteLine("A(" + nombre + "/" + sousEnsemble + ") = " + resultat);
                        choix = initChoix();
                    }
                    if (choix == "3")
                    {
                        // calcul de resulat1
                        long resultat1 = 1;
                        for (int i = (nombre - sousEnsemble + 1); i <= nombre; i++)
                            resultat1 *= i;

                        // calcul de resultat2
                        long resultat2 = 1;
                        for (int i = 1; i <= sousEnsemble; i++)
                            resultat2 *= i;
                        
                        //Calcul du resultat final
                        Console.WriteLine("C(" + nombre + "/" + sousEnsemble + ") = " + (resultat1 / resultat2));
                        choix = initChoix();
                    }
                    
                }
            }
            Console.ReadLine();
        }
    }
}
