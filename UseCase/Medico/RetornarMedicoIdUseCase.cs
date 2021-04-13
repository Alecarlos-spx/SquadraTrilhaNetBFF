using ProjetoMedico.BFF.Bordas___Interfaces.UseCases.Repositorio;
using ProjetoMedico.BFF.Bordas_Interfaces.Adapter;
using ProjetoMedico.BFF.Bordas_Interfaces.UseCases;
using ProjetoMedico.BFF.DTO.Medico.RetornaMedicoId;
using System;

namespace ProjetoMedico.BFF.UseCase.Medico
{
    public class RetornarMedicoIdUseCase : IRetornarMedicoIdUseCase
    {
        private readonly IRepositorioMedicos _repositorioMedicos;
        private readonly IRetornarMedicoIdAdapter _adapter;

        public RetornarMedicoIdUseCase(IRepositorioMedicos repositorioMedicos, IRetornarMedicoIdAdapter adapter)
        {
            _repositorioMedicos = repositorioMedicos;
            _adapter = adapter;
        }

        public RetornarMedicoIdResponse Executar(RetornarMedicoIdRequest request)
        {
            var response = new RetornarMedicoIdResponse();

            try
            {
                var medico = _repositorioMedicos.GetId(request.id);
                if (medico == null)
                {
                    //response.msg.Add("Erro ao pesquisar o médico");
                    return response;
                }
                response = medico;
                //response.msg.Add("Pesquisa realizada com sucesso!");
                return response;
            }
            catch (Exception)
            {

                //response.msg.Add("Erro ao pesquisar o médico");
                return response;
            }
        }
    }
}
