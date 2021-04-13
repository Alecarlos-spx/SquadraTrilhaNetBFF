using ProjetoMedico.BFF.Bordas___Interfaces.UseCases.Repositorio;
using ProjetoMedico.BFF.Bordas_Interfaces.UseCases;
using ProjetoMedico.BFF.DTO.Medico.DeletarMedico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMedico.BFF.UseCase.Medico
{
    public class DeletarMedicoUseCase : IDeletarMedicoUseCase
    {
        private readonly IRepositorioMedicos _repositorioMedicos;

        public DeletarMedicoUseCase(IRepositorioMedicos repositorioMedicos)
        {
            _repositorioMedicos = repositorioMedicos;
        }

        public DeletarMedicoResponse Executar(DeletarMedicoRequest request)
        {
            var response = new DeletarMedicoResponse();

            try
            {
                var medico = _repositorioMedicos.GetId(request.id);
                if (medico == null || medico.id == 0)
                {
                    response.msg.Add("Erro ao excluir o médico!");
                    return response;
                }

                _repositorioMedicos.Delete(request.id);
                response.msg.Add("Excluido com sucesso!");
                return response;
            }
            catch (Exception)
            {

                response.msg.Add("Erro ao excluir o médico!");
                return response;

            }
        }
    }
}
