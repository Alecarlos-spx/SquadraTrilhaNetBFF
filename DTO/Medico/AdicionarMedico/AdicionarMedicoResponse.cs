using System.Collections.Generic;

namespace ProjetoMedico.BFF.DTO.Medico.AdicionarMedico
{
    public class AdicionarMedicoResponse
    {
        public List<string> msg { get; set; } = new List<string>();

        public List<string> erros { get; set; } = new List<string>();
        public int id { get; set; }
    }
}
