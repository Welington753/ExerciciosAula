using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ExerciciosAulas
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Cliente[] quantidade = new Cliente[10];

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Rent #" + (i + 1) + ":");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                quantidade[room] = new Cliente { Name = name, Email = email, Room = room };

                Console.WriteLine("Cliente registrado: " + quantidade[room].Name + ", " + quantidade[room].Email + ", Room: " + quantidade[room].Room);
                Console.WriteLine();

            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < quantidade.Length; i++)
            {
                if (quantidade[i] != null)
                {
                    Console.WriteLine("Room " + i + ": " + quantidade[i].Name + ", " + quantidade[i].Email);
                }
            }
        }
    }
}