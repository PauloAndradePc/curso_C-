namespace Application;

class application
{
    static void Main(string[] args)
    {
        // Com operador de incremento no final.
        Basico t = new Basico();
        t.EstruturaWhile();

        Console.WriteLine();
        
        // Com operador de incremento no começo.
        Basico t2 = new Basico();
        t2.EstruturaWhile2();
    }
}