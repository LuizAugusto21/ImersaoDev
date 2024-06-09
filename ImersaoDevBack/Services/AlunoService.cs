
using ImersaoDev.models;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace ImersaoDev.Services
{
    public class AlunoService
    {
        private static List<Aluno> alunos = new List<Aluno>();


        public List<Aluno> GetAlunos()
        {

            return alunos;
        }

        public void addAluno(Aluno aluno)
        {
            aluno.media = (
                aluno.NotaUnidade1 + 
                aluno.NotaUnidade2 +
                aluno.NotaUnidade3)/3;

            if (aluno.media>=9 && aluno.media<=10) aluno.conceito = 'A';
            if (aluno.media>=7 && aluno.media<=8.9) aluno.conceito = 'B';
            if (aluno.media>=5 && aluno.media<=6.9) aluno.conceito = 'C';
            if (aluno.media>=3 && aluno.media<=4.9) aluno.conceito = 'D';
            if (aluno.media>=0 && aluno.media<=2.9) aluno.conceito = 'E';
            alunos.Add(aluno);
        }


        // public void addAluno(string Name, string materia, double nota1, double nota2, double nota3){
        //     Aluno a = new Aluno();

        //     a.Name = Name;
        //     a.Materia = materia;
        //     a.NotaUnidade1 = nota1;
        //     a.NotaUnidade2 = nota2;
        //     a.NotaUnidade3 = nota3;

        //     a.media = (nota1+nota2+nota3)/3;

        //     if (a.media>=9 && a.media<=10) a.conceito = 'A';
        //     if (a.media>=7 && a.media<=8.9) a.conceito = 'B';
        //     if (a.media>=5 && a.media<=6.9) a.conceito = 'C';
        //     if (a.media>=3 && a.media<=4.9) a.conceito = 'D';
        //     if (a.media>=0 && a.media<=2.9) a.conceito = 'E';

        //     alunos.Add(a);
        // }


    }
}