using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;

namespace Site.Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente c = new Cliente();

                c.Nome  = txtNome.Text;
                c.Email = txtEmail.Text;

                ClienteDal d = new ClienteDal();
                d.Salvar(c);

                lblMensagem.Text = "Cliente cadastrado com sucesso.";
            }
            catch(Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}