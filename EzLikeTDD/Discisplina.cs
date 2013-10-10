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
        public IEnumerable<Discisplina> PreRequisitos { get; set; }
        public IEnumerable<Discisplina> PreRequisitosParalelos { get; set; } 
    }
}
