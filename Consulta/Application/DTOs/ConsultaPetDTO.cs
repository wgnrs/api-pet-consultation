using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consulta.Application.DTOs
{
    public class ConsultaPetDTO
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public int AnimalId { get; set; }
        public string Nome { get; set; }
    }
}