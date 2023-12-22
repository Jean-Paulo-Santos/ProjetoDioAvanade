using ProjetoDio.Models;


bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar");
}
else
{
    Console.WriteLine("Vou pedalar um outro dia");
}






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