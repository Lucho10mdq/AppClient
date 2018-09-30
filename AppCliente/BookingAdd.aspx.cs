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
    public partial class BookingAdd : System.Web.UI.Page
    {
        ServiceClient ListClient;
        protected void Page_Load(object sender, EventArgs e)
        {
            ListClient = (ServiceClient)Session["clientList"];
            SelectCliente.DataSource = ListClient.GetAll();
            SelectCliente.DataTextField = "name";
            SelectCliente.DataBind();
        }
    }
}