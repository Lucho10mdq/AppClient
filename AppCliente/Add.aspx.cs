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
    public partial class Add : System.Web.UI.Page
    {
        ServiceClient ListClient;
        string name;
        User oUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
                Response.Redirect("login.aspx");
            else
            {
                oUser = (User)Session["login"];
                lblUser.Text = oUser.Name;
            }
            ListClient = (ServiceClient)Session["clientList"];
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string name = txtNombre.Value;
            string lastName = txtApellido.Value;
            string dni = txtDni.Value;
            string address = txtDomicilio.Value;
            DateTime birthdate = Convert.ToDateTime(txtFecha.Value);
            ListClient.Add(name, lastName, dni, address, birthdate);
            txtNombre.Value = "";
            txtApellido.Value = "";
            txtDni.Value = "";
            txtDomicilio.Value = "";
            txtFecha.Value = "";
        }
    }
}