//! Exercício 1

// Console.WriteLine("Digite o nome de um produto");
// string? nomeProduto = Console.ReadLine();
// Console.WriteLine("Digite quanto você comprou");
// int quantidadeProduto = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Digite o valor unitário do produto");
// decimal precoUnitario = decimal.Parse(Console.ReadLine() ?? "0");

// decimal precoTotal = quantidadeProduto * precoUnitario;
// Console.WriteLine($"O valor a ser pago é a quantidade de Produtos que foi {quantidadeProduto}, multiplicado pelo valor unitário que é {precoUnitario}, resultando em {precoTotal}");

//! Exercício 2

// string? nome = "";
// int nota = 0;
// bool aprovado = true;
// bool recuperacao = false;


// Console.WriteLine("Digite seu nome: ");
// nome = Console.ReadLine();

// Console.WriteLine("Digite sua nota: ");
// nota = int.Parse(Console.ReadLine());

// if (nota < 0 || nota > 10)
// {
//     Console.WriteLine("Erro: A nota digitada é inválida! Digite um valor entre 0 e 10.");
// }

// if ( nota >= 7)
// {
//     aprovado = true;
//     Console.WriteLine("APROVADO");
// }
// else if (nota < 5)
// {
//     aprovado = false;
//     Console.WriteLine("REPROVADO");
// }
// else if (nota >= 5 || nota < 7 )
// {
//     aprovado = false;
//     recuperacao = true;
//     Console.WriteLine("RECUPERAÇÂO");
// }

// //Exercício 3

        int numeroSecreto = 42; 
        int tentativa = -1; 
        int quantidadeTentativas = 0;

        Console.WriteLine("=== JOGO DA ADIVINHAÇÃO  ===");
        Console.WriteLine("Tente adivinhar o número secreto!");

        while (tentativa != numeroSecreto)
        {
            Console.Write("Digite o seu palpite: ");
            tentativa = int.Parse(Console.ReadLine());
            quantidadeTentativas++; 

            if (tentativa < numeroSecreto)
            {
                Console.WriteLine("O número secreto é MAIOR.");
            }
            else if (tentativa > numeroSecreto)
            {
                Console.WriteLine("O número secreto é MENOR.");
            }
        }

        Console.WriteLine($"\nParabéns! Você acertou o número secreto {numeroSecreto}!");
        Console.WriteLine($"Total de tentativas realizadas: {quantidadeTentativas}");
    
