using ProjetoMedico.BFF.Bordas_Interfaces.Adapter;
using ProjetoMedico.BFF.DTO.Medico.AdicionarMedico;
using ProjetoMedico.BFF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMedico.BFF.Adapter
{
    public class AdicionarMedicoAdapter : IAdicionarMedicoAdapter
    {
        public Medico converterRequestParaMedico(AdicionarMedicoRequest request)
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

