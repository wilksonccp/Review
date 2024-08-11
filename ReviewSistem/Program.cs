using System;
using System.Globalization;
using System.Net.NetworkInformation;

namespace ReviewSistem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contSimil = 0;
            Customers A = new Customers();
            Addresses End = new Addresses();

            //Asks the user for their name
            Console.Write("Insira o nome do usuario A:");
            A.Name = Console.ReadLine();

            //Asks the user for their age
            Console.Write("Insira a idade do usuário A");
            A.Age = int.Parse(Console.ReadLine());

            //Check if the entered age is correct.
            while (!CheckAge(A))
            {
                Console.Write("Por gentileza, insira uma idade válida entre 0 e 150");
                A.Age = int.Parse(Console.ReadLine());
            }

            //Asks the user for their address
            Console.Write("Insira o endereço do usuário A, nesse formato (rua numero bairro)");
            string[] endereco = Console.ReadLine().Split(' ');
            End.Street = endereco[0];
            End.HouseNumber = int.Parse(endereco[1]);
            End.Neighborhood = endereco[2];

            string status = BeAncient(A.Age);


            Console.WriteLine($"Oi {A.Name}, você tem {A.Age} anos");
            Console.WriteLine($"{A.Name} você mora na Rua {End.Street}, nº {End.HouseNumber}, no bairro {End.Neighborhood}");
            Console.WriteLine($"{A.Name}, com base em nossa análise, decobrimos que você {status}.");

            int yearBorn = 2024 - A.Age;

            int yearCont = yearBorn;
            for (int i = A.Age; i > 0; i--)
            {

                if ((yearCont - 2000) == A.Age)
                {
                    contSimil += 1;
                }
                yearCont++;
            }
            if (contSimil == 0)
            {
                Console.WriteLine($"Notamos que sua idade atual n/ não é semlhante a nenhum dos anos que você viveu");
            }
            else
            {
                yearCont = yearBorn;
                for (int i = A.Age; i > 0; i--)
                {
                    if ((yearCont - 2000) == A.Age)
                    {
                        Console.WriteLine($"o ano de {yearCont} é semelhante a sua idade");
                    }
                    yearCont++;
                }
            }

            //checks if user is old based on age
            static string BeAncient(int a)
            {
                if (a >= 35)
                {
                    return "é velho";
                }
                else
                {
                    return "não é velho";

                }
            }
            // Checks if the entered age is between 0 and 150
            static bool CheckAge(Customers a)
            {
                if (a.Age >= 0 && a.Age <= 150)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }
}
