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
    public partial class List : System.Web.UI.Page
    {
        string name;
        User oUser;
        ServiceClient ListClient;


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

                GridClientes.DataSource = ListClient.GetAll();
                GridClientes.DataBind();
       }
    }
}