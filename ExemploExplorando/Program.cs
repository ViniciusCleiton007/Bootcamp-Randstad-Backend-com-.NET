using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Vinicius", sobrenome: "Santos");

Pessoa p2 = new Pessoa(nome: "Laura", sobrenome: "Cruz");

Curso cursoDeIngles = new Curso();

cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.adicionarAluno(p1);
cursoDeIngles.adicionarAluno(p2);
cursoDeIngles.listarAlunos();








// Pessoa p1 = new Pessoa();
// p1.Nome = "Vinicius";
// p1.Sobrenome = "Santos";
// p1.Idade = 24;

// p1.Apresentar();