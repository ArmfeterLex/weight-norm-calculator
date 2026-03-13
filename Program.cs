using System;
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш рост (в см):");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш вес (в кг):");
            int weight = int.Parse(Console.ReadLine());

            int idealWeight = height - 100;
            int weightLowerLimit = (int)(idealWeight * 0.9);
            int weightUpperLimit = (int)(idealWeight * 1.1);

            string message;

            if (weight >= weightLowerLimit && weight <= weightUpperLimit)
            {
                message = "Норма";
            }
            else if (weight > weightUpperLimit)
            {
                message = "Нужно похудеть";
            }
            else
            {
                message = "Нужно поправиться";
            }

            Console.WriteLine($"Ваш вес: {weight} кг. {message}");
            Console.ReadKey();
        }
    }