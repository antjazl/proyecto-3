using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaginaWCF
{
    public partial class WebFormPractica10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ObjectDataSource2.Select();
        }

        protected void ObjectDataSource2_Selected(object sender, ObjectDataSourceStatusEventArgs e)
        {
            Image imgFoto = (Image)FormView1.FindControl("Image1");
            Label lblFoto = (Label)FormView1.FindControl("Label1");

            //Utilice DTO en el servicio subido al IIS - la clase que utilice fue taxacatalogo que 
            // en la capa de datos hago una consulta linq que relaciona taxa multimedia y catalogo
            Service_Taxa_WCF.taxacatalogo txaMul = e.ReturnValue as Service_Taxa_WCF.taxacatalogo;

            if (txaMul != null)
            {
                if (imgFoto != null)
                    imgFoto.ImageUrl = "~" + txaMul.Descripcion + txaMul.NombreArchivo;
                if (lblFoto != null)
                    lblFoto.Text = "Foto realizada por: " + txaMul.DescrpcionC;

            }
        }
    }
}