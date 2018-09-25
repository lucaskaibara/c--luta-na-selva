using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Tempo
    {
        public int codTempo { get; set; }
        public String nomeJogador1 { get; set; }
        public String nomeJogador2 { get; set; }
        public int jogadorGanhador { get; set; }
        public TimeSpan tempoJogo { get; set; }
    }
}
