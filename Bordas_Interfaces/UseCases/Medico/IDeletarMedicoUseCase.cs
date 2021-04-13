using ProjetoMedico.BFF.DTO.Medico.DeletarMedico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMedico.BFF.Bordas_Interfaces.UseCases
{
    public interface IDeletarMedicoUseCase
    {
        DeletarMedicoResponse Executar(DeletarMedicoRequest request);
    }
}
