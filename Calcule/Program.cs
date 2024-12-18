using System;

namespace Calcule
{
    public class QuadraticSolver
    {
        // Méthode pour résoudre l'équation ax² + bx + c = 0
        public static (double?, double?) Solve(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new ArgumentException("Coefficient 'a' ne peut pas être 0 pour une équation quadratique.");
            }

            double delta = (b * b) - (4 * a * c);

            if (delta > 0) // Deux solutions réelles
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return (x1, x2);
            }
            else if (delta == 0) // Une solution réelle
            {
                double x = -b / (2 * a);
                return (x, null);
            }
            else // Pas de solution réelle
            {
                return (null, null);
            }
        }

        // Interaction avec l'utilisateur
        public static void Main(string[] args)
        {
            Console.WriteLine("Résolution de l'équation ax² + bx + c = 0");

            Console.Write("Entrez le coefficient a : ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entrez le coefficient b : ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entrez le coefficient c : ");
            double c = Convert.ToDouble(Console.ReadLine());

            try
            {
                var solutions = Solve(a, b, c);

                if (solutions.Item1 == null && solutions.Item2 == null)
                {
                    Console.WriteLine("Pas de solution réelle.");
                }
                else if (solutions.Item2 == null)
                {
                    Console.WriteLine($"Une solution réelle : x = {solutions.Item1}");
                }
                else
                {
                    Console.WriteLine($"Deux solutions réelles : x1 = {solutions.Item1}, x2 = {solutions.Item2}");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
            }
        }
    }
}
