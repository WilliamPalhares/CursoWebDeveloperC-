using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Correios.Net;

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
    
    }
}
