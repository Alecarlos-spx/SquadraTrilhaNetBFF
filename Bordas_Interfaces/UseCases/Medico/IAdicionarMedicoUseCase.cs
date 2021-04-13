using ProjetoMedico.BFF.DTO.Medico.AdicionarMedico;


namespace ProjetoMedico.BFF.Bordas_Interfaces.UseCases
{
    public interface IAdicionarMedicoUseCase
    {
        AdicionarMedicoResponse Executar(AdicionarMedicoRequest request);
    }
}
