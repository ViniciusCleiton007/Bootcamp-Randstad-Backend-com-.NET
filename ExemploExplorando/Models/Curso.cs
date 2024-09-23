using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }

        public List<Pessoa> Alunos { get; set; }

        public void adicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }

        public int obterQuantidadeDeAlunosMatriculados() {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool removerAluno(Pessoa aluno){
            return Alunos.Remove(aluno);         
        }

        public void listarAlunos(){
            Console.WriteLine($"Alunos do curso de: {Nome}");
            foreach(Pessoa aluno in Alunos){
                Console.WriteLine(aluno.nomeCompleto);
            }
        }
    }
}