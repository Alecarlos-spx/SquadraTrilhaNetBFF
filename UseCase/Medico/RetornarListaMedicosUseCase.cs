using ProjetoMedico.BFF.Bordas___Interfaces.UseCases.Repositorio;
using ProjetoMedico.BFF.Bordas_Interfaces.Adapter;
using ProjetoMedico.BFF.Bordas_Interfaces.UseCases;
using ProjetoMedico.BFF.DTO.Medico.RetornaListaMedicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMedico.BFF.UseCase.Medico
{
    public class RetornarListaMedicosUseCase : IRetornarListaMedicosUseCase
    {
        private readonly IRepositorioMedicos _repositorioMedicos;

        public RetornarListaMedicosUseCase(IRepositorioMedicos repositorioMedicos)
        {
            _repositorioMedicos = repositorioMedicos;
        }

        public RetornarListaMedicosResponse Executar()
        {
            var response = new RetornarListaMedicosResponse();

            try
            {
                response = _repositorioMedicos.Get();
                //response.msg.Add("Lista de Médicos!");

                return response;
            }
            catch (Exception)
            {

                //response.msg.Add("Erro ao listar os médicos!");
                return response;
            }
        }
    }
}
