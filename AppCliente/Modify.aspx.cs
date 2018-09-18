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
    
    public partial class Modify : System.Web.UI.Page
    {
        string dni;
        ServiceClient ClientList;
        Client oClient = null;
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

            dni =(string)Session["dni"];
            ClientList = (ServiceClient)Session["clientList"];
            oClient = ClientList.GetByDni(dni);
            if (oClient == null)
            {
                Response.Redirect("Search.aspx");
                Response.Write("El cliente no existe");
            }
            else
            {
                txtName.Value = oClient.Name;
                txtSurname.Value = oClient.Lastname;
                txtDom.Value = oClient.Address;
                txtBirthdate.Value = Convert.ToString(oClient.FechaNacimiento);
                //Session.Contents.Remove("dni");
            } 
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime birthdate = Convert.ToDateTime(txtBirthdate.Value);
            string name = txtName.Value;
            ClientList.Modify(name, txtSurname.Value, dni, txtDom.Value, birthdate);
        }
    }
}