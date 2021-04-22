using System;
using System.Globalization;


namespace Funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios2 f1 = new Funcionarios2();
            Funcionarios2 f2 = new Funcionarios2();

            Console.WriteLine("Dados do Primeiro Funcionario:");
            Console.WriteLine("Nome do funcionario: ");
            f1.nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Segundo Funcionario:");
            Console.WriteLine("Nome do funcionario: ");
            f2.nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.salario + f2.salario) / 2.0;
            Console.WriteLine("Salario Medio = " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
