﻿using ExplorandoDioAvanade;
using ExplorandoDioAvanade.Models;
using System.Data;
using System.Globalization;

// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// Console.WriteLine(estados["MG"]);

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// estados.Remove("BA");
// estados["SP"] = "São Paulo - valor alterado";

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }

// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }



















// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);    
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }





















Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
 fila.Enqueue(8);

 foreach(int item in fila)
 {
     Console.WriteLine(item);
 }

 Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
 fila.Enqueue(10);

 foreach(int item in fila)
 {
     Console.WriteLine(item);
 }
























// try
// {

//     string[] linhs = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linh in linhs)
//     {
//         Console.WriteLine(linh);
//     }

// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");  
// }



// string dataString = "2022-09-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);


// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso: Data: {data}");
// }
// else
// {

//     Console.WriteLine($"{dataString} não é uma data valida");
// }



// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("C1"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));[]

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));




// string numero1 = "10";
// string numero2 = "20";
// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);





// Pessoa p1 = new Pessoa(nome:"Jean", sobrenome:"Paulo");
// Pessoa p2 = new Pessoa(nome:"Eduardo", sobrenome:"Neves");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();