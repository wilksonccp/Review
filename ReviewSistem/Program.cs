using System;
using System.Globalization;

namespace ReviewSistem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customers A = new Customers();
            Addresses End = new Addresses();

            //Solicita do usuário o seu nome
            Console.Write("Insira o nome do usuario A:");
            A.Name = Console.ReadLine();

            //solicita so usuário a sua idade
            Console.Write("Insira a idade do usuário A");
            A.Age = int.Parse(Console.ReadLine());

            //Solicita o endereço do susuário A
            Console.Write("Insira o endereço do usuário A, nesse formato (rua numero bairro)");
            string[] endereco = Console.ReadLine().Split(' ');
            End.Street = endereco[0];
            End.HouseNumber = int.Parse(endereco[1]);
            End.Neighborhood = endereco[2];

            string status = EhVelho(A.Age);
            

            Console.WriteLine($"Oi {A.Name}, você tem {A.Age} anos");
            Console.WriteLine($"{A.Name} você mora na Rua{End.Street}, nº {End.HouseNumber}, no bairro {End.Neighborhood}");
            Console.WriteLine($"{A.Name}, com base em nossa análise, decobrimos que você {status}.");

            static string EhVelho(int a)
            {
                if(a>=35)
                {
                    return "é velho";
                }
                else
                {
                    return "não é velho";

                }
            }

        }
    }
}
