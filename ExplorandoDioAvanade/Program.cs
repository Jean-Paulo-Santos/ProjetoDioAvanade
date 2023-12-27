using ExplorandoDioAvanade;
using ExplorandoDioAvanade.Models;

Pessoa p1 = new Pessoa(nome:"Jean", sobrenome:"Paulo");
Pessoa p2 = new Pessoa(nome:"Eduardo", sobrenome:"Neves");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();