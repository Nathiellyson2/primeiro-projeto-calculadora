// See https://aka.ms/new-console-template for more information
/*  tipos: byte, bool, char, string, int, long, float, double, decimal 
    type variableName = value;

    operadores: = , +, -, /, * , ++, --

    Existe o "const" (constante) não permite outra atribuição:
    const int numero = 5;
    numero = 6; // error

    int x, y, z;
    x = y = z = 50;
    Console.WriteLine(x + y + z);
    
    int x = 5, y = 6, z = 50;
    Console.WriteLine(x + y + z);

    int myInt = 10;
    double myDouble = 5.25;
    bool myBool = true;

    Console.WriteLine(Convert.ToString(myInt));    // convert int to string
    Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
    Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
    Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
    
    OPERADORES DE COMPARAÇÃO

    int x = 5;
    int y = 3;
Console.WriteLine(x > y);

    */

decimal horasLiquidas;
horasLiquidas = 5.45m;
string sobrenome = "Nathiellyson";

Console.WriteLine("Hello, World!");
Console.Write("Digite seu nome: ");
string meuNome = Console.ReadLine();

string nomeCompleto = $"{meuNome} {sobrenome}";

Console.Write("Digite sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Olá, {nomeCompleto}!");
Console.WriteLine($"Você tem {idade} anos.");
Console.WriteLine($"e já o total de {horasLiquidas} horas liquidas de programação");