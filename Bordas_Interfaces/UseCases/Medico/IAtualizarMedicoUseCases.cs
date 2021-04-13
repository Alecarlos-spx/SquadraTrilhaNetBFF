using ProjetoMedico.BFF.DTO.Medico.AtualizarMedico;

namespace ProjetoMedico.BFF.Bordas_Interfaces.UseCases
{
    public interface IAtualizarMedicoUseCases
    {
        AtualizarMedicoResponse Executar(AtualizarMedicoRequest request, int id);
    }
}
