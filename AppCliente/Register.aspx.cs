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
    public partial class Register : System.Web.UI.Page
    {
        ServiceUser UserList=new ServiceUser();
        protected void Page_Load(object sender, EventArgs e)
        {
            UserList = (ServiceUser)Session["userList"];
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            // User oUser = null;
            var result = false;
            string nombre = txtNombre.Value;
            string email = txtEmail.Value;
            string pass = txtPassword.Value;
            //oUser = UserList.GetUserByEmail(email, pass);

            // User user = new User(nombre, email, pass);
            result = UserList.AddUser(nombre, email, pass);
            if (result == false) { Response.Write("Ya existe el usuario"); }
               
            else
            {
                Response.Write("Se guardo con Exito");
                 Response.Redirect("Login.aspx");
            }
                
        }
    }
}