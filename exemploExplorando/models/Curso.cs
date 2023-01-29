using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
qualquer método que ultilizar void precisa colocar um return da variavel
*/


namespace exemploExplorando.models
{
    public class Curso
    {
        public string Nome  { get; set; }
        public List<Pessoa> Alunos{get; set;}

        //método para adicionar os alunos
        public void AdicionarAlunos(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        //método para conta a quantidade de alunos matrículados 
        public int QuantidadeAlunosMatriculados()
        {
            int qt = Alunos.Count;
            return qt;
        }


        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListaAlunos()
        {
                Console.WriteLine($"Alunos do curso de {Nome}");
                 
                for (int count = 0; count < Alunos.Count; count++)
                {
                    //concatenação de string
                    //string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto;
                    //interpolação de string - $" {} " / é o sinal de dólar $
                    //{count + 1} só soma com 0 da para apenas demostrar o valor sem ser alterado na contagem da fila
                    string texto = $"Nº {count + 1} - {Alunos[count].NomeCompleto}";
                    Console.WriteLine(texto);
                }
        }
    }
}