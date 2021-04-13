using ProjetoMedico.BFF.Bordas___Interfaces.UseCases.Repositorio;
using ProjetoMedico.BFF.Bordas_Interfaces.Adapter;
using ProjetoMedico.BFF.Bordas_Interfaces.UseCases;
using ProjetoMedico.BFF.DTO.Medico.AtualizarMedico;
using ProjetoMedico.BFF.Validator.Medico;
using System;

namespace ProjetoMedico.BFF.UseCase.Medico
{
    public class AtualizarMedicoUseCases : IAtualizarMedicoUseCases
    {
        private readonly IRepositorioMedicos _repositorioMedicos;
        private readonly IAtualizarMedicoAdapter _adapter;

        public AtualizarMedicoUseCases(IRepositorioMedicos repositorioMedico, IAtualizarMedicoAdapter adapter)
        {
            _repositorioMedicos = repositorioMedico;
            _adapter = adapter;
        }

        public AtualizarMedicoResponse Executar(AtualizarMedicoRequest request, int id)
        {
            var response = new AtualizarMedicoResponse();
            var validacao = new AtualizarMedicoRequestValidator();

            try
            {
                var medico = _repositorioMedicos.GetId(id);
                if (medico == null || medico.id == 0)
                {
                    response.msg.Add("Erro ao atualizar o médico");
                    return response;
                }

                response = validacao.ValidarCamposAtualizarMedico(request);

                if (response.erros.Count > 0)
                {
                    response.msg.Add("Erro ao atualizar o médico");
                    return response;
                }


                var medicoAtualizar = _adapter.converterRequestParaMedico(request);

                medicoAtualizar.id = id;
                _repositorioMedicos.Update(medicoAtualizar);
                response.msg.Add("Atualizado com sucesso");
                response.id = medicoAtualizar.id;
                return response;

            }
            catch (Exception)
            {

                response.msg.Add("Erro ao atualizar o médico");
                return response;
            }

        }
    }
}
