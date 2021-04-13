using ProjetoMedico.BFF.DTO.Medico.RetornaListaMedicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMedico.BFF.Bordas_Interfaces.UseCases
{
    public interface IRetornarListaMedicosUseCase
    {
        RetornarListaMedicosResponse Executar();
    }
}
