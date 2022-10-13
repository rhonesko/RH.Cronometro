// See https://aka.ms/new-console-template for more information

Menu();


static void Menu()
{
    Console.Clear();
    Console.WriteLine("CRONOMETRO");
    Console.WriteLine("S é para segundos");
    Console.WriteLine("M é para minutos");
    Console.WriteLine("0s ou 0m, é para sair");
    Console.WriteLine("Digito o tempo ?");

    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length -1, 1));
    int time = int.Parse(data.Substring(0, data.Length -1));
    int multiplier = 1;

    if(type == 'm')
        multiplier = 60;

    if(time == 0)
        System.Environment.Exit(0);

    PreStart(time * multiplier);
}


static void PreStart(int time)
{
    Console.Clear();
    Console.WriteLine("Preparar...");
    Thread.Sleep(1000);
    Console.WriteLine("Apontar...");
    Thread.Sleep(1000);
    Console.WriteLine("Já ....");
    Thread.Sleep(3000);

    Start(time);
}


static void Start(int time)
{
    int currentTime = 0;

    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }
    Console.Clear();
    Console.WriteLine("Stopwatch finalizdo...");
    Console.WriteLine("Obrigado por usar nosso Cronometro");
    Thread.Sleep(4500);

    Menu();
}