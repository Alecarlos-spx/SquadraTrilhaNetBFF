using ProjetoMedico.BFF.Bordas_Interfaces.Adapter;
using ProjetoMedico.BFF.DTO.Medico.AtualizarMedico;
using ProjetoMedico.BFF.Entities;

namespace ProjetoMedico.BFF.Adapter
{
    public class AtualizarMedicoAdapter : IAtualizarMedicoAdapter
    {
        public Medico converterRequestParaMedico(AtualizarMedicoRequest request)
        {
            var novoMedico = new Medico();
            novoMedico.nome = request.nome;
            novoMedico.especialidade = request.especialidade;
            novoMedico.telefone = request.telefone;
            novoMedico.crm = request.crm;
            novoMedico.situacao = request.situacao;

            return novoMedico;

        }
    }
}

