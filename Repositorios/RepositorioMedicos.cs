using ProjetoMedico.BFF.Bordas___Interfaces.UseCases.Repositorio;
using System.Collections.Generic;
using ProjetoMedico.BFF.DTO.Medico.AdicionarMedico;
using ProjetoMedico.BFF.DTO.Medico.AtualizarMedico;
using RestSharp;
using Newtonsoft.Json;
using ProjetoMedico.BFF.DTO.Medico.RetornaMedicoId;
using ProjetoMedico.BFF.DTO.Medico.RetornaListaMedicos;
using ProjetoMedico.BFF.DTO.Medico.DeletarMedico;
using ProjetoMedico.BFF.Entities;
using Microsoft.Extensions.Configuration;

namespace ProjetoMedico.BFF.Repositorios
{
    public class RepositorioMedicos : IRepositorioMedicos
    {
        private readonly IConfiguration _configuration;

        private readonly string _apiMedico;
        

        public RepositorioMedicos(IConfiguration configuration)
        {
            _configuration = configuration;
            _apiMedico = _configuration.GetValue<string>("apiMedicos");
        }

        public AdicionarMedicoResponse Add(AdicionarMedicoRequest request)
        {
            var responseMedico = new AdicionarMedicoResponse();
            try
            {
                
                var client = new RestClient(_apiMedico);
                client.Timeout = -1;
                var requestClient = new RestRequest(Method.POST);

                requestClient.AddHeader("Content-Type", "application/json");
                requestClient.AddParameter("application/json", JsonConvert.SerializeObject(request), ParameterType.RequestBody);
                IRestResponse response = client.Execute(requestClient);

                responseMedico = JsonConvert.DeserializeObject<AdicionarMedicoResponse>(response.Content);
                return responseMedico;


            }
            catch (System.Exception)
            {

                responseMedico.msg.Add("Erro ao adicionar o medico!");
                return responseMedico;
            }


        }

        public void Delete(int request)
        {
            try
            {
                var client = new RestClient(_apiMedico + request);
                client.Timeout = -1;
                var requestClient = new RestRequest(Method.DELETE);

                requestClient.AddHeader("Content-Type", "application/json");
                IRestResponse response = client.Execute(requestClient);

                var responseMedico = JsonConvert.DeserializeObject<DeletarMedicoResponse>(response.Content);

            }
            catch (System.Exception)
            {

                throw new System.Exception("Erro ao excluir o medico!");
            }
        }

        public RetornarListaMedicosResponse Get()
        {
            var responseMedico = new RetornarListaMedicosResponse();
            try
            {
                var client = new RestClient(_apiMedico);
                client.Timeout = -1;
                var requestClient = new RestRequest(Method.GET);

                requestClient.AddHeader("Content-Type", "application/json");
            
                IRestResponse response = client.Execute(requestClient);

                 responseMedico = JsonConvert.DeserializeObject<RetornarListaMedicosResponse>(response.Content);
            
                return responseMedico;

            }
            catch (System.Exception)
            {

                responseMedico.msg.Add("Erro ao pesquisar o médico!");
                return responseMedico;
            }
        }

        public RetornarMedicoIdResponse GetId(int request)
        {
            var responseMedico = new RetornarMedicoIdResponse();
            try
            {
                var client = new RestClient(_apiMedico+request);
                client.Timeout = -1;
                var requestClient = new RestRequest(Method.GET);

                requestClient.AddHeader("Content-Type", "application/json");
                IRestResponse response = client.Execute(requestClient);

                responseMedico = JsonConvert.DeserializeObject<RetornarMedicoIdResponse>(response.Content);



                return responseMedico;

            }
            catch (System.Exception)
            {
                responseMedico.msg.Add("Erro ao listar os médicos!");
                return responseMedico;

            }
        }

        public int Update(Medico request)
        {
            var responseMedico = new AtualizarMedicoResponse();
            try
            {
                var client = new RestClient(_apiMedico + request.id);
                client.Timeout = -1;
                var requestClient = new RestRequest(Method.PUT);

                requestClient.AddHeader("Content-Type", "application/json");
                requestClient.AddParameter("application/json", JsonConvert.SerializeObject(request), ParameterType.RequestBody);
                IRestResponse response = client.Execute(requestClient);

                responseMedico = JsonConvert.DeserializeObject<AtualizarMedicoResponse>(response.Content);



                return responseMedico.id;

            }
            catch (System.Exception)
            {
                responseMedico.msg.Add("Erro ao listar os médicos!");
                return responseMedico.id;
            }
        }



        
    }
}
