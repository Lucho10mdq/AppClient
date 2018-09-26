using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Repository;

namespace AppCliente
{
    public partial class TouristPackage : System.Web.UI.Page
    {
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
        }
    }
}