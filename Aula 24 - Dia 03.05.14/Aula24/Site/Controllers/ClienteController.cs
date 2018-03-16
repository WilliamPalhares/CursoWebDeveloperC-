using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Correios.Net;
using DAL.Model;
using DAL.Persistence;
using Site.Models;

namespace Site.Controllers
{
    public class ClienteController : Controller
    {
        //URL => /Cliente/Cadastro
        public ActionResult Cadastro() //Nome da Página
        {
            return View(); //Page_Load
        }

        //Método para realizar a busca do endereço enviada por ajax
        //Json -> JavaScript Object Notation
        public JsonResult PesquisarEndereco(string cep)
        {
            string dados = string.Empty; //vazio

            try
            {
                Address endereco = BuscaCep.GetAddress(cep);
                dados = endereco.Street + ", " + endereco.District + ", " + endereco.City + ", " + endereco.State;
            }
            catch(Exception e)
            {
                dados = e.Message; //mensagem de erro
            }

            return Json(dados); //Hello World
        }


        public JsonResult CadastrarCliente(ClienteModel model) //Classe de Modelo
        {
            try
            {
                Cliente c = new Cliente(); //instanciando a Classe Cliente
                c.Residencia = new Endereco(); //instanciando o Enderedo do Cliente

                c.Nome  = model.Nome;
                c.Email = model.Email;
                c.DataCadastro = DateTime.Now; //data do sistema
                c.Residencia.Cep = model.Cep;
                c.Residencia.Logradouro = model.Endereco;
                
                ClienteDal d = new ClienteDal();
                d.Salvar(c); //gravando Cliente

                return Json("Cliente " + c.Nome + ", cadastrado com sucesso.");
            }
            catch(Exception e)
            {
                return Json(e.Message); //mensagem de erro
            }
        }

    }
}
