using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Service;

namespace AppCliente
{
    public partial class AddPackage : System.Web.UI.Page
    {
        ServicePackage ListPackage;
        protected void Page_Load(object sender, EventArgs e)
        {
            string name;
            User oUser;
            if (Session["login"] == null)
                Response.Redirect("login.aspx");
            else
            {
                oUser = (User)Session["login"];
                lblUser.Text = oUser.Name;
            }
            ListPackage = (ServicePackage)Session["packageList"];
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Value;
            DateTime FechaSalida = Convert.ToDateTime(txtFechaSalida.Value);
            DateTime FechaLlegada = Convert.ToDateTime(txtFechaLlegada.Value);
            int Cantidad = Convert.ToInt32(txtCantidad.Value);
            double importe = Convert.ToDouble(txtImporte.Value);
            ListPackage.AddPackage(descripcion, FechaSalida, FechaLlegada, Cantidad, importe);



        }
    }
}