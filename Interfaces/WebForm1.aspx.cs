using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interfaces
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Int64 eEliminar;
        protected void Page_Load(object sender, EventArgs e)
        {
            fvwTaxa.ChangeMode(FormViewMode.Insert);

        }

        protected void odsTaxa_Deleting(object sender, ObjectDataSourceMethodEventArgs e)
        {
            serviciosTaxa.taxa txaTaxaEliminar = e.InputParameters[0] as serviciosTaxa.taxa;
            if (txaTaxaEliminar!=null)
            {
                txaTaxaEliminar.IdTaxa = eEliminar;
            }
        }

        protected void gvwTaxa_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            if(odsTaxa.DeleteParameters.Count>0)
            {
                odsTaxa.DeleteParameters[0].DefaultValue = e.Keys["IdTaxa"].ToString();
            }
            eEliminar = Convert.ToInt64(e.Keys["IdTaxa"]);

        }
    }
}