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
    public partial class ListPackage : System.Web.UI.Page
    {
        ServicePackage PackageList;
        protected void Page_Load(object sender, EventArgs e)
        {
            PackageList = (ServicePackage)Session["packageList"];

            GvPackage.DataSource = PackageList.GetPackage();
            GvPackage.DataBind();
        }
    }
}