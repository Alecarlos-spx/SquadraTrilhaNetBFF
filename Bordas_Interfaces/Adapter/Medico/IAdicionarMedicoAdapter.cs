using ProjetoMedico.BFF.DTO.Medico.AdicionarMedico;
using ProjetoMedico.BFF.Entities;
namespace ProjetoMedico.BFF.Bordas_Interfaces.Adapter
{
    public interface IAdicionarMedicoAdapter
    {
        public Medico converterRequestParaMedico(AdicionarMedicoRequest request);
    }
}
