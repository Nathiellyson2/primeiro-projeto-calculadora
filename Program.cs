// Calculadora de Linha de comando em c#!
// Primeiro vamos perguntar ao usuário se ele vai querer usar a calculadora.
Console.WriteLine("\t\tBEM VINDO A CALCULADORA DE CMD!!");
Console.Write("\t\tDESEJA ENTRAR NA CALCULADORAS (s (sim) ou N (não))? ");
var entradaDoUsuario = Console.ReadLine();
var entradaDoUsuarioMaiuscula = entradaDoUsuario.ToUpper();

// Se a respota for "S" (sim) vamos continuar.
if (entradaDoUsuarioMaiuscula == "S") {
    Console.Write("\t\tDIGITE UM NÚMERO PARA COMEÇAR: ");
    double numero = Convert.ToDouble(Console.ReadLine());
    double totalDaoperacao = numero;

    /* fiz um laço de repetição para fazer os calculos matemáticos,
     o usuário começa digitando o número da operação e o sistema vai fazendo os cálculos,
     optei por utilizar o "switch" para colocar em prática o novo conhecimento adquirido,
     quando o usuário coloca um número diferente de operação o while quebra */
    while (numero != 0) {
        Console.WriteLine("\t\tÓTIMO!, QUAL OPERAÇÃO VOCÊ DESEJA REALIZAR?");
        Console.WriteLine("\t\tDIGITE: 1 (Adição) \t 2 (Subtrair) \t\t 3 (Multiplicar) \t 4 (dividir) \t Outro (Parar)");
        Console.Write("\t\tSua Resposta: ");
        int respostaDoUsuario = Convert.ToInt32(Console.ReadLine());

        switch (respostaDoUsuario) {
        case 1:
            Console.Write("\t\tDigite um número para somar: ");
            double soma = Convert.ToDouble(Console.ReadLine());
            totalDaoperacao += soma;
            break;
        case 2:
            Console.Write("\t\tDigite um número para subtrair: ");
            double subtracao = Convert.ToDouble(Console.ReadLine());
            totalDaoperacao -= subtracao;
            break;
        case 3:
            Console.Write("\t\tDigite um número para multiplicar: ");
            double multiplicacao = Convert.ToDouble(Console.ReadLine());
            totalDaoperacao *= multiplicacao;
            break;
        case 4:
            Console.Write("\t\tDigite um número para dividir: ");
            double divisao = Convert.ToDouble(Console.ReadLine());
            totalDaoperacao /= divisao;
            break;
        default:
            Console.WriteLine(" ");
            numero = 0;
            break;
        }
    }
    // No fim o sistema exibe o resultado na saída.
    Console.WriteLine($"\t\tO total é {totalDaoperacao}");
    Console.WriteLine("\t\tOBRIGADO POR USAR A CALCULADORA! :)");
}


// se a resposta do usuário for "N" (não)...
else if (entradaDoUsuarioMaiuscula == "N") {
    Console.WriteLine("\t\tTUDO BEM OBRIGADO POR TESTAR A CALCULADORA! :)");
}

// se ele digitar outra resposta...
else {
    Console.WriteLine("\t\tDIGITE UMA RESPOSTA VÁLIDA, PROGRAMA ENCERRADO.");
}