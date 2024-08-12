using System;
using System.Globalization;

namespace ReviewScholl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student();

            //asks the user the name of student
            Console.Write("Insira o nome do aluno: ");
            a.Name = Console.ReadLine();

            // asks the user for the student's grades
            Console.Write("Insira as três notas do aluno: ");
            a.Na =double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nb =double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nc =double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // show the enswers demanded
            Console.WriteLine($"NOTA FINAL {a.Finish().ToString("f2", CultureInfo.InvariantCulture)}");
            double fait = (a.Finish() - 60.00) *(-1);
            if (a.Result() == true)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {fait.ToString("f2", CultureInfo.InvariantCulture)} PONTOS");
            }
        }
    }
}
