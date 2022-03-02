using System;
using System.Collections.Generic;
using static AtivSem02.Generics;
using static AtivSem02.InjDep;

namespace AtivSem02
{
    class Program
    {
        static void Main(string[] args)
        {
            Alunos a1 = new Alunos() { nome = "Lucas", matricula = "a001", idade = 23 };
            Alunos a2 = new Alunos() { nome = "Lais", matricula = "a002", idade = 19 };
            Alunos a3 = new Alunos() { nome = "Iza", matricula = "a003", idade = 17 };
            Alunos a4 = new Alunos() { nome = "Theo", matricula = "a004", idade = 17 };
            Alunos a5 = new Alunos() { nome = "Caua", matricula = "a005", idade = 21 };
            Alunos a6 = new Alunos() { nome = "Bernardo", matricula = "a006", idade = 20 };
            Alunos a7 = new Alunos() { nome = "Maria", matricula = "a007", idade = 20 };
            Alunos a8 = new Alunos() { nome = "Jorge", matricula = "a008", idade = 17 };
            Alunos a9 = new Alunos() { nome = "Vitor", matricula = "a009", idade = 23 };
            Alunos a10 = new Alunos() { nome = "Mariana", matricula = "a010", idade = 23 };
            List<Alunos> lista = Generics.RetornaLista<Alunos>(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10);
            Alunos response = Generics.RetornaAlunosPMatricula(lista, "a002");
            Console.WriteLine($"Aluno: {response.nome}\nMatricula: {response.matricula}\nIdade: {response.idade}");
            Nubank banco1 = new Nubank();
            Itau banco2 = new Itau();
            TransferenciasBancarias transferencia = new TransferenciasBancarias(banco1, banco2);
            Console.WriteLine($"Banco 1 saldo anterior:{banco1.Metodo1()}\nBanco 2 saldo anterior: {banco2.Metodo1()}");
            transferencia.Transferir(1000000.10);
            Console.WriteLine($"Banco 1 saldo após:{banco1.Metodo1()}\nBanco 2 saldo após: {banco2.Metodo1()}");
            Console.ReadKey();
        }
    }
}
