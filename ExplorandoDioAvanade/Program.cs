﻿using ExplorandoDioAvanade;
using ExplorandoDioAvanade.Models;
using System.Data;
using System.Globalization;


string dataString = "2022-09-17 18:00";

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);


if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso: Data: {data}");
}
else
{

    Console.WriteLine($"{dataString} não é uma data valida");
}















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("C1"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

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