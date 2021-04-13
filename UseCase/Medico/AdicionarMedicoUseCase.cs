using ProjetoMedico.BFF.Bordas___Interfaces.UseCases.Repositorio;
using ProjetoMedico.BFF.Bordas_Interfaces.Adapter;
using ProjetoMedico.BFF.Bordas_Interfaces.UseCases;
using ProjetoMedico.BFF.DTO.Medico.AdicionarMedico;
using ProjetoMedico.BFF.Validator.Medico;
using System;
using System.Collections.Generic;

namespace ProjetoMedico.BFF.UseCase.Medico
{
    public class AdicionarMedicoUseCase : IAdicionarMedicoUseCase
    {
        private readonly IRepositorioMedicos _repositorioMedicos;
        private readonly IAdicionarMedicoAdapter _adapter;

        public AdicionarMedicoUseCase(IRepositorioMedicos repositorioMedicos, IAdicionarMedicoAdapter adapter)
        {
            _repositorioMedicos = repositorioMedicos;
            _adapter = adapter;
        }

        public AdicionarMedicoResponse Executar(AdicionarMedicoRequest request)
        {
            var response = _repositorioMedicos.Add(request);
 
            return response;


        }
    }
}
