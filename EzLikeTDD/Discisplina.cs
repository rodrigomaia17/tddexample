using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzLikeTDD
{
    public class Discisplina
    {
        public string Nome { get; set; }
        public IList<Discisplina> PreRequisitos { get; set; }
        public IList<Discisplina> PreRequisitosParalelos { get; set; }

        public Discisplina()
        {
            PreRequisitos = new List<Discisplina>();
            PreRequisitosParalelos = new List<Discisplina>();
        }
    }
}
