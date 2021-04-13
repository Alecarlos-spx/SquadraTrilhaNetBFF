
using ProjetoMedico.BFF.DTO.Medico.RetornaMedicoId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMedico.BFF.Bordas_Interfaces.UseCases
{
    public interface IRetornarMedicoIdUseCase
    {
        RetornarMedicoIdResponse Executar(RetornarMedicoIdRequest request);
    }
}
