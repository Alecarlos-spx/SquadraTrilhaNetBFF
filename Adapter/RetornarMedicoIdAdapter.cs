using ProjetoMedico.BFF.Bordas_Interfaces.Adapter;
using ProjetoMedico.BFF.DTO.Medico.AdicionarMedico;
using ProjetoMedico.BFF.DTO.Medico.RetornaMedicoId;
using ProjetoMedico.BFF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMedico.BFF.Adapter
{
    public class RetornarMedicoIdAdapter : IRetornarMedicoIdAdapter
    {
        public RetornarMedicoIdResponse converterMedicoParaResponse(Medico medico)
        {
            var response = new RetornarMedicoIdResponse();
            response.id = medico.id;
            response.nome = medico.nome;
            response.especialidade = medico.especialidade;
            response.telefone = medico.telefone;
            response.crm = medico.crm;
            response.situacao = medico.situacao;

            

            return response;
        }

        public Medico converterRequestParaMedico(RetornarMedicoIdRequest request)
        {
            var MedicoPorId = new Medico();
            MedicoPorId.id = request.id;
            MedicoPorId.nome = request.nome;
            MedicoPorId.especialidade = request.especialidade;
            MedicoPorId.telefone = request.telefone;
            MedicoPorId.crm = request.crm;
            MedicoPorId.situacao = request.situacao;

            return MedicoPorId;

        }
    }
}

