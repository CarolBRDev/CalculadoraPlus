using System;
using System.ComponentModel.Design;

namespace CalculadoraPlus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc =  new Calculadora();

            Console.WriteLine("Digite o primeiro valor: ");
            double numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            double numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual operação vocÊ deseja fazer?");
            Console.WriteLine("1- Adição\n2- Subtração\n3- Divisao\n4- Multiplicação\n5- Raiz Quadrada\n");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {

                case 1:
                    Console.WriteLine($"O resultado da Adição do numero {numero1} e do número {numero2} é: {calc.Adicao(numero1, numero2)}");
                    break;

                case 2:
                    Console.WriteLine($"O resultado da Subtração do numero {numero1} e do número {numero2} é: {calc.Subtracao(numero1, numero2)}");
                    break;
                case 3:
                    Console.WriteLine($"O resultado da Divisão do numero {numero1} e do número {numero2} é: {calc.Divisao(numero1, numero2)}");
                    break;
                case 4:
                    Console.WriteLine($"O resultado da Multiplicação do numero {numero1} e do número {numero2} é: {calc.Multiplicacao(numero1, numero2)}");
                    break;
                case 5:                    
                    Console.WriteLine("Voce quer saber a raiz quadrada do primeiro ou segundo numero informados? (1 ou 2)");
                    int escolha = int.Parse(Console.ReadLine());

                    if (escolha == 1)
                    {
                        CalculadoraCientifica calcCientifica = new CalculadoraCientifica(numero1);
                        Console.WriteLine($"A raiz quadrada do número {numero1} é: {calcCientifica.RaizQuadrada(numero1)}");
                    }
                    else
                    {
                        CalculadoraCientifica calcCientifica = new CalculadoraCientifica(numero2);
                        Console.WriteLine($"A raiz quadrada do número {numero2} é: {calcCientifica.RaizQuadrada(numero2)}");                        
                    }
                    break;
            }
        }
    }
}
