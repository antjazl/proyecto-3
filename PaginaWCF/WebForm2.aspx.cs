using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaginaWCF
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Service_Taxa_WCF.ServiceWCFTaxaClient servicio = new Service_Taxa_WCF.ServiceWCFTaxaClient();
            Service_Taxa_WCF.taxa txaTaxa = servicio.seleccionarTaxaPorId(Convert.ToInt32(TextBox1.Text));
            Label1.Text = txaTaxa.IdTaxa.ToString();
            Label2.Text = txaTaxa.Nombre;
            Label3.Text = txaTaxa.NombreCorto;
            Label4.Text = txaTaxa.PublicarEnWeb.ToString();
            Label5.Text = txaTaxa.EnEcuador.ToString();
            Label6.Text = txaTaxa.Ano.ToString();
            servicio.Close();
        }
    }
}