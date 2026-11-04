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

        // int numeroSecreto = 42; 
        // int tentativa = -1; 
        // int quantidadeTentativas = 0;

        // Console.WriteLine("=== JOGO DA ADIVINHAÇÃO  ===");
        // Console.WriteLine("Tente adivinhar o número secreto!");

        // while (tentativa != numeroSecreto)
        // {
        //     Console.Write("Digite o seu palpite: ");
        //     tentativa = int.Parse(Console.ReadLine());
        //     quantidadeTentativas++; 

        //     if (tentativa < numeroSecreto)
        //     {
        //         Console.WriteLine("O número secreto é MAIOR.");
        //     }
        //     else if (tentativa > numeroSecreto)
        //     {
        //         Console.WriteLine("O número secreto é MENOR.");
        //     }
        // }

        // Console.WriteLine($"\nParabéns! Você acertou o número secreto {numeroSecreto}!");
        // Console.WriteLine($"Total de tentativas realizadas: {quantidadeTentativas}");
    

//Exercício 4
        // static double Somar(double num1, double num2)
        // {
        //     return num1 + num2;
        // }

        // // 2. Método Multiplicar
        // static double Multiplicar(double num1, double num2)
        // {
        //     return num1 * num2;
        // }


        //     // 3. Solicitar dois números ao usuário
        //     Console.Write("Digite o primeiro número: ");
        //     double n1 = Convert.ToDouble(Console.ReadLine());

        //     Console.Write("Digite o segundo número: ");
        //     double n2 = Convert.ToDouble(Console.ReadLine());

        //     // 4. Chamar os métodos e exibir os resultados
        //     double resultadoSoma = Somar(n1, n2);
        //     double resultadoMultiplicacao = Multiplicar(n1, n2);

        //     Console.WriteLine($"\nResultado da Soma: {resultadoSoma}");
        //     Console.WriteLine($"Resultado da Multiplicação: {resultadoMultiplicacao}");
        

// Exercício 5

        
            // 1. Declarar um array capaz de armazenar 3 notas
            double[] notas = new double[3];

            // 2. Solicitar as 3 notas ao usuário e armazená-las no array
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Digite a {i + 1}ª nota: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("\n--- Notas Cadastradas ---");
            
            // 3. Percorrer o array utilizando for e exibir todas as notas
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Nota {i + 1}: {notas[i]}");
            }

            // 4. Percorrer novamente o array utilizando foreach e calcular a média
            double soma = 0;
            foreach (double nota in notas)
            {
                soma += nota;
            }
            double media = soma / notas.Length;

            // 5. Exibir a média calculada
            Console.WriteLine($"\nMédia do aluno: {media:F2}");
        
    
// //Exercício 6

//         {
           
//             List<string> produtos = new List<string>();

//             for (int i = 0; i < 3; i++)
//             {
//                 Console.Write($"Digite o nome do {i + 1}º produto para adicionar: ");
//                 string produto = Console.ReadLine();
//                 produtos.Add(produto);
//             }

//             Console.WriteLine("\n--- Produtos Cadastrados ---");
//             foreach (string p in produtos)
//             {
//                 Console.WriteLine($"- {p}");
//             }

//             Console.Write("\nDigite o nome de um produto para buscar na lista: ");
//             string busca = Console.ReadLine();
            
//             if (produtos.Contains(busca))
//             {
//                 Console.WriteLine($"O produto '{busca}' foi encontrado na lista.");
//             }
//             else
//             {
//                 Console.WriteLine($"O produto '{busca}' não está na lista.");
//             }

//             Console.Write("\nDigite o nome de um produto para remover da lista: ");
//             string remover = Console.ReadLine();
            
//             if (produtos.Remove(remover))
//             {
//                 Console.WriteLine("Produto removido com sucesso!");
//             }
//             else
//             {
//                 Console.WriteLine("Produto não encontrado para remoção.");
//             }

//             Console.WriteLine("\n--- Lista Atualizada ---");
//             if (produtos.Count > 0)
//             {
//                 foreach (string p in produtos)
//                 {
//                     Console.WriteLine($"- {p}");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("A lista está vazia.");
//             }
//         }
    
