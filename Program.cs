using System;

namespace CSHARP_Boucles_Exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int input0 = 0;
            string continuer = "o";
                        
            Console.WriteLine("Utilisateur, veuillez indiquer un nombre.");
            int input1 = int.Parse(Console.ReadLine());
            int result = input0 + input1;

            while (continuer == "o")
            {
                Console.WriteLine($"Le résultat est {result}. \n Souhaitez-vous y ajouter un autre nombre ? O/N");
                string reponse = Console.ReadLine().ToLower();

                if (reponse == "o")
                    {
                    Console.WriteLine("Alors veuillez indiquer un autre nombre.");
                    int input2 = int.Parse(Console.ReadLine());
                    result += input2;}
                else
                    {
                    continuer = "n";}
            }


        }
    }
}
