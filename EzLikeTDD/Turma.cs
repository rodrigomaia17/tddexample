using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzLikeTDD
{
    public class Turma
    {
        public IList<Aluno> Alunos { get; set; }
        public int MaxAlunos { get; set; }
        public Discisplina Discisplina { get; set; }

        public Turma()
        {
            Alunos = new List<Aluno>();
        }

        public void Matricula(Aluno aluno)
        {
            foreach (var preRequisito in Discisplina.PreRequisitos)
            {
                if(!aluno.Cursadas.Contains(preRequisito))
                    throw new MatriculaSemPreRequisitoException();
            }
            Alunos.Add(aluno);
            
        }
    }
}
