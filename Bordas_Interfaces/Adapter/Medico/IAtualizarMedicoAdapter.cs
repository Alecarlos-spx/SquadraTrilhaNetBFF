using ProjetoMedico.BFF.DTO.Medico.AtualizarMedico;
using ProjetoMedico.BFF.Entities;
namespace ProjetoMedico.BFF.Bordas_Interfaces.Adapter
{
    public interface IAtualizarMedicoAdapter
    {
        public Medico converterRequestParaMedico(AtualizarMedicoRequest request);
    }
}
