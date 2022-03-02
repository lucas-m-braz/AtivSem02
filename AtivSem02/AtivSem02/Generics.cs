using System.Collections.Generic;

namespace AtivSem02
{
    class Generics
    {
        public class Alunos
        {
            public string nome { get; set; }
            public string matricula { get; set; }
            public byte idade { get; set; }
        }
        public static List<T> RetornaLista<T>(params T[] a)
        {
            //Alunos a1 = new Alunos() {nome = "Jose", matricula = "a001", idade = 15}
            List<T> lista = new List<T>();
            foreach (T aluno in a){
                lista.Add(aluno);
            }
            //lista.Add(a1);

            return lista ;
        }

        public static Alunos RetornaAlunosPMatricula(List<Alunos> lista, string matricula)
        { 
            return lista.Find(r => r.matricula == matricula); ;
        }

    }
}
