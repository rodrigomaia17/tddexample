using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzLikeTDD
{
    public class Aluno
    {
        public IList<Discisplina> Cursadas { get; set; }

        public Aluno()
        {
            Cursadas = new List<Discisplina>();
        }
    }
}
