namespace Crônometro;
using System.Threading;

public class cronometro
{
    
    public static void Start(int time/*Estamos adicionando um parâmetro*/)
    {
        int currentTime = 0; // Minuto Atual
        
        while (currentTime != time )
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            // Vamos fazer com que nosso programa espere um segundo antes de continuar usando :
            Thread.Sleep(1000); // Estou pedindo para dormir, ela pergunta quanto tempo nosso programa ira dormir.
        }
        Console.Clear(); 
        Console.WriteLine("StopWatch finalizado");
        Thread.Sleep(2500);// Escolhemos o tempo que o projeto ira fechar apos a mensagem de finalizado.
    }

    public void PreStart(int time)
    {
        Console.Clear();
        Console.WriteLine("Ready...");
        Thread.Sleep(1000);
        Console.WriteLine("Set...");
        Thread.Sleep(1000);
        Console.WriteLine("Go... ");
        Thread.Sleep(2500);
        Start(time);
        
    }
    
    public void Menu()
    {
        Console.WriteLine("S = Segundo => 10s = 10 segundos");
        Console.WriteLine("M = Minuto => 1m = 1 minuto");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("Digite quanto tempo deseja contar?");
        
        String data = Console.ReadLine(). ToLower(); // Pegar dado do usuario.E adicionamos uma função.

        //Agora queremos pegar somente o valor do final. Exemplo "S" e "M".
        char type = char.Parse(data.Substring(data.Length -1, 1)); // Aqui estamos pegando o ultimo carctere da nossa String.
        int time = int.Parse(data.Substring(0, data.Length - 1));
        int multiplier = 1; // Para multiplicar os ( minutos )

        if (type == 'm')
            multiplier = 60; // Para multiplicar os ( minutos )
        
        if (time == 0)
        System.Environment.Exit(0); // Modo para sair.
        
        PreStart(time * multiplier); // Chamando a função (Start).
        Menu(); // Chamando o ( Menu ) novamente, apos o programa ser encerrado.
    }
    
}