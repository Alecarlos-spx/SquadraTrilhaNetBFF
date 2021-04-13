using ProjetoMedico.BFF.DTO.Medico.AdicionarMedico;
using ProjetoMedico.BFF.DTO.Medico.AtualizarMedico;
using ProjetoMedico.BFF.DTO.Medico.RetornaListaMedicos;
using ProjetoMedico.BFF.DTO.Medico.RetornaMedicoId;
using ProjetoMedico.BFF.Entities;
using System.Collections.Generic;

namespace ProjetoMedico.BFF.Bordas___Interfaces.UseCases.Repositorio
{
    public interface IRepositorioMedicos
    {
        public AdicionarMedicoResponse Add(AdicionarMedicoRequest request);
        public int Update(Medico request);
        public void Delete(int request);
        public RetornarMedicoIdResponse GetId(int request);
        public RetornarListaMedicosResponse Get();





    }
}
