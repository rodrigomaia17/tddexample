using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzLikeTDD
{
    public class Turma
    {
        public IEnumerable<ALuno> AlunosMatriculados { get; set; }
        public int MaxAlunos { get; set; }
    }
}
