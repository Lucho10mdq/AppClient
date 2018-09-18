using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Repository;
using Service;

namespace AppCliente
{
    public partial class Login : System.Web.UI.Page
    {
        ServiceUser UserList;
        protected void Page_Load(object sender, EventArgs e)
        {
            UserList = (ServiceUser)Session["userList"];
            Session.Contents.Remove("login");
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Value;
            string password = txtPass.Value;
            User oUser = null;
            var result = false;
            oUser = UserList.GetUserByEmail(email, password);
            if (oUser != null)
            {
                Session["login"] = oUser;
                Response.Redirect("Main.aspx");
            }
            else
                Response.Write("El email y/o password no son correctos o no existe el usuario");
        }
    }
}