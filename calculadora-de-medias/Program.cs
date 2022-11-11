int j = 1;

Console.WriteLine("Seja bem-vindo à calculadora de médias!");

do
{
    int numNotas = 0;
    float somaTotal = 0;
    float notaParcial = 0;
    double mediaFinal = 0;
    string mediaWriteLine = "";

    Console.WriteLine("Digite a quantidade de notas a ser calculada");
    numNotas = int.Parse(Console.ReadLine());

    for (int i = 1; i <= numNotas; i++)
    {
        Console.WriteLine("Digite a nota " + i +":");
        notaParcial = float.Parse(Console.ReadLine());
        somaTotal = somaTotal + notaParcial;
    }
    
    mediaFinal = somaTotal/numNotas;
    mediaWriteLine = mediaFinal.ToString("0.00");

    Console.WriteLine("A média do aluno foi: "+mediaWriteLine);

    if(mediaFinal >= 6)
    {
        Console.WriteLine("Parabéns, você foi aprovado");
    }
    else
    {
        Console.WriteLine("Você está de recuperação, estude mais!");        
    }

    Console.WriteLine(@"Deseja calcular mais médias?
    Sim - Digite 1
    Não - Digite 0");
    j = int.Parse(Console.ReadLine());

} while (j == 1);

Console.WriteLine("Obrigado por utilizar a calculadora de médias!");
