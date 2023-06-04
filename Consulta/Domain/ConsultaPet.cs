using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consulta.Domain
{
    public class ConsultaPet
    
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public int AnimalId { get; set; }
        public string Nome { get; set; }

        public Pessoa Pessoa { get; set; }
        public Animal Animal { get; set; }
    }
}