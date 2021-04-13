using System.Collections.Generic;
using MedicoEntidade = ProjetoMedico.BFF.Entities.Medico;

namespace ProjetoMedico.BFF.DTO.Medico.RetornaListaMedicos
{
    public class RetornarListaMedicosResponse
    {
        public List<MedicoEntidade> medicos { get; set; } = new List<MedicoEntidade>();
        public List<string> msg { get; set; } = new List<string>();
    }
}
