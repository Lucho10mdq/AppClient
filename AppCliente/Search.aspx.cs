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
    public partial class Search : System.Web.UI.Page
    {
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
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Session["dni"] = txtDni.Value;
            Response.Redirect("Modify.aspx");
        }
    }
}