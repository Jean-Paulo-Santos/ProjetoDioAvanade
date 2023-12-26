using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using ProjetoDioAvanade.Models;

string opcao;


while(true)
{
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de Cliente");
            break;

        case "2":
            Console.WriteLine("Busca de Cliente");
            break;
        
        case "3":
            Console.WriteLine("Apagar Cliente");
            break;
        
        case "4":
            Console.WriteLine("Encerrar");
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Opção invalida");
            break;
    }
}















// int soma = 0, numero = 0;


// do
// {
//     Console.WriteLine("Digite um numero:(0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;



// } while (numero != 0);

// Console.WriteLine($"Total da soma dos numeros digitados é: {soma}");


// int numero = 5;
// int contador = 1;


// while (contador <= 10)
// {
//      Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//      contador++;

//      if (contador == 5)
//      {
//         break;
//      }
// }

// Console.WriteLine("Digite um numero:");
// int numero = Convert.ToInt32(Console.ReadLine());


// for(int contador = 1; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }


// Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);

// int numero = 10;

// Console.WriteLine(numero);

// Console.WriteLine("Incrementando o 10");
// numero = numero + 1;

// int numeroDecremento = 20;
// Console.WriteLine("Decrementando o 20");
// numeroDecremento--;

// Console.WriteLine(numeroDecremento);

















// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar um outro dia");
// }


// bool possuiPresencaMinima = false;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else 
// {
//     Console.WriteLine("Reprovado");
// }




// bool ehMaiorDeIdade = false;
// bool possuiAutorizaçaoDoResponsavel = true;

// if (ehMaiorDeIdade || possuiAutorizaçaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada");
// }



// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();


// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }



// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")

// {
//     Console.WriteLine("vogal");
// }
// else{
//     Console.WriteLine("Não é uma vogal");
// }















// else if (letra == "e")
// {
//     Console.WriteLine("vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }











// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"quantidadeEmEstoque: {quantidadeEmEstoque}");
// Console.WriteLine($"quantidadeCompra: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda?{possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida");
// }

// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }

// else
// {
//     Console.WriteLine("Desculpe não temos a quantidade desejada no estoque");
// }


// string a = "15-";

// int b = 0;

// int.TryParse(a, out b);


// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");

// double a = 4 / (2 + 2);

// Console.WriteLine(a);

// int a = 5;
// double b = a;

// int a = int.MaxValue;
// long b = a;

// Console.WriteLine(b);

// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);



//int a = Convert.ToInt32(null);
//int a = int.Parse(null);



// int a = 10;
// int b = 20;

// int c = a + b;

// c += 5;

//Console.WriteLine(c);


// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));


// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;
// Console.WriteLine("Valor da variavel quantidade: " + quantidade);

// quantidade = 10;
//  Console.WriteLine("Valor da variavel quantidade: " + quantidade);

// double altura = 1.80;

// decimal preco = 1.80m;

// bool condicao = true;

//Console.WriteLine(apresentacao);
//Console.WriteLine("Valor da variavel quantidade: " + quantidade);
//Console.WriteLine("Valor da variavel altura: " + altura);
//Console.WriteLine("Valor da variavel preco: " + preco);
//Console.WriteLine("Valor da variavel condicao: " + condicao);


//Pessoa pessoa1 = new Pessoa();

//pessoa1.Name = "Jean";
//pessoa1.Age = 26;
//pessoa1.Apresentar();