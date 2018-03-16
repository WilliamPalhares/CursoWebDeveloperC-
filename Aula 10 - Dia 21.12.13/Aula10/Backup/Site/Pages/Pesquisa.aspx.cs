using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Persistence;
using Microsoft.Reporting.WebForms;
using System.Data;

namespace Site.Pages
{
    public partial class Pesquisa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GerarRelatorio(object sender, EventArgs e)
        {
            try
            {
                //Obter o relatorio (caminho)
                string Path = HttpContext.Current.Server.MapPath("/Reports/RelatorioVendas.rdlc");

                //Resgatar as datas
                DateTime dtIni = Convert.ToDateTime(txtDataInicio.Text);
                DateTime dtFim = Convert.ToDateTime(txtDataTermino.Text);

                using(VendaDal d = new VendaDal()) //inicializar
                {
                    ReportDataSource dados = new ReportDataSource("DSRelatorio", d.ListarVendas(dtIni, dtFim));

                    //Mostrar o relatorio
                    ReportViewer.LocalReport.ReportPath = Path; //caminho do relatório
                    ReportViewer.LocalReport.DataSources.Add(dados); //passando os dados
                    ReportViewer.DataBind(); //Exibir

                } //dispose (destruir)
            }
            catch(Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}