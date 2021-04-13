using ProjetoMedico.BFF.DTO.Medico.RetornaMedicoId;
using ProjetoMedico.BFF.Entities;
namespace ProjetoMedico.BFF.Bordas_Interfaces.Adapter
{
    public interface IRetornarMedicoIdAdapter
    {
        public Medico converterRequestParaMedico(RetornarMedicoIdRequest request);

        public RetornarMedicoIdResponse converterMedicoParaResponse(Medico medico);

    }
}
