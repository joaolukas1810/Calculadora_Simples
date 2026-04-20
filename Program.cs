namespace calculadora;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Esse é um teste de uma calculadora simples");
        Console.WriteLine("Qual operação gostaria de realizar?\n1 = ADIÇÃO; 2 = SUBTRAÇÃO; 3 = MULTIPLICAÇÃO; 4 = DIVISÃO");

        int operacao = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Digite dois números para a realização da operação desejada:");
        double n1 = double.Parse(Console.ReadLine());
        double n2 = double.Parse(Console.ReadLine());

        if (operacao == 1)
        {
            double soma = n1 + n2;
            Console.WriteLine($"O resultado da soma foi: {soma}");
        } else if (operacao == 2)
        {
            double subtracao = n1 - n2;
            Console.WriteLine($"O resultado da subtração foi de: {subtracao}");
        } else if (operacao == 3)
        {
            double multiplpicacao = n1 * n2;
            Console.WriteLine($"O resultado da multiplicação foi de: {multiplpicacao}");
        } else if (operacao == 4)
        {
            double divisao = n1 / n2;
            Console.WriteLine($"O resultado da divisão foi de: {divisao}");
        } else
        {
            Console.WriteLine("Você digitou um valor inválido");
        }

    }
}
