Random rnd = new Random();
int numeroSecreto = rnd.Next(1, 6);

Console.WriteLine(numeroSecreto);
do
{
    Console.WriteLine("Digite um número de 1 a 5)");
    int chute = int.Parse(Console.ReadLine()!);

    if (chute == numeroSecreto)
    {
        Console.WriteLine("Você acertou");
        break;
    }

    else if (chute < numeroSecreto)
    {
        Console.WriteLine("o número é maior");
    }

    else if(chute > numeroSecreto)
    {
        Console.WriteLine("o número é menor");
    }

} while (true);

