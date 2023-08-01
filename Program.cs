using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 1: Calculadora Simples
            Console.WriteLine("Exercício 1: Calculadora Simples");
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o operador (+, -, *, /): ");
            char operador = Convert.ToChar(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double resultado = CalculadoraSimples(num1, operador, num2);
            Console.WriteLine($"Resultado: {resultado}");

            // Exercício 2: Números Primos
            Console.WriteLine("\nExercício 2: Números Primos");

            Console.Write("Digite um número: ");
            int numprim = Convert.ToInt32(Console.ReadLine());
            bool isprimo = EhPrimo(numprim);
            Console.WriteLine($"O número \"{numprim}\" é um número primo? {isprimo}");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}º número primo: {ObterNumeroPrimo(i)}");
            }

            // Exercício 3: Fatorial
            Console.WriteLine("\nExercício 3: Fatorial");
            Console.Write("Digite um número para calcular o fatorial: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            long fatorial = CalcularFatorial(numero);
            Console.WriteLine($"Fatorial de {numero}: {fatorial}");

            // Exercício 4: Palíndromo
            Console.WriteLine("\nExercício 4: Palíndromo");
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();
            bool isPalindromo = VerificarPalindromo(palavra);
            Console.WriteLine($"A palavra \"{palavra}\" é um palíndromo? {isPalindromo}");

            // Exercício 5: Tabuada
            Console.WriteLine("\nExercício 5: Tabuada");
            Console.Write("Digite um número para exibir a tabuada: ");
            int numTabuada = Convert.ToInt32(Console.ReadLine());
            ExibirTabuada(numTabuada);

            // Exercício 6: Contador de Vogais
            Console.WriteLine("\nExercício 6: Contador de Vogais");
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            int numVogais = ContarVogais(frase);
            Console.WriteLine($"A frase contém {numVogais} vogais.");

            // Exercício 7: Média das Notas
            Console.WriteLine("\nExercício 7: Média das Notas");
            double[] notas = new double[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Digite a nota {i + 1}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }
            double media = CalcularMediaNotas(notas);
            Console.WriteLine($"Média das notas: {media}");

            // Exercício 8: Cálculo de Juros
            Console.WriteLine("\nExercício 8: Cálculo de Juros");
            Console.Write("Digite o capital inicial: ");
            double capitalInicial = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a taxa de juros (em decimal): ");
            double taxaJuros = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o tempo de investimento (em meses): ");
            int tempoInvestimento = Convert.ToInt32(Console.ReadLine());
            double valorFinal = CalcularValorFinalInvestimento(capitalInicial, taxaJuros, tempoInvestimento);
            Console.WriteLine($"Valor final do investimento: {valorFinal}");
        }

        // Função para o Exercício 1: Calculadora Simples
        static double CalculadoraSimples(double num1, char operador, double num2)
        {
            double resultado = 0;
            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        resultado = num1 / num2;
                    else
                        Console.WriteLine("Erro: Divisão por zero.");
                    break;
                default:
                    Console.WriteLine("Erro: Operador inválido.");
                    break;
            }
            return resultado;
        }

        // Função para o Exercício 2: Números Primos
        static bool EhPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }

        static int ObterNumeroPrimo(int posicao)
        {
            int count = 0;
            int num = 1;
            while (count < posicao)
            {
                num++;
                if (EhPrimo(num))
                    count++;
            }
            return num;
        }

        // Função para o Exercício 3: Fatorial
        static long CalcularFatorial(int numero)
        {
            if (numero == 0)
                return 1;

            long resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        // Função para o Exercício 4: Palíndromo
        static bool VerificarPalindromo(string palavra)
        {
            palavra = palavra.ToLower();
            int i = 0;
            int j = palavra.Length - 1;
            while (i < j)
            {
                if (palavra[i] != palavra[j])
                    return false;
                i++;
                j--;
            }
            return true;
        }

        // Função para o Exercício 5: Tabuada
        static void ExibirTabuada(int numero)
        {
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }

        // Função para o Exercício 6: Contador de Vogais
        static int ContarVogais(string frase)
        {
            int contador = 0;
            foreach (char c in frase.ToLower())
            {
                if ("aeiou".Contains(c))
                    contador++;
            }
            return contador;
        }

        // Função para o Exercício 7: Média das Notas
        static double CalcularMediaNotas(double[] notas)
        {
            double soma = 0;
            foreach (double nota in notas)
            {
                soma += nota;
            }
            return soma / notas.Length;
        }

        // Função para o Exercício 8: Cálculo de Juros
        static double CalcularValorFinalInvestimento(double capitalInicial, double taxaJuros, int tempoInvestimento)
        {
            return capitalInicial * Math.Pow((1 + taxaJuros), tempoInvestimento);
        }
    }
}
