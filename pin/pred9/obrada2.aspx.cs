using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class obrada : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //lblRezultat.Text = Request.Form["ime"].ToString() + " " 
        //                 + Request.QueryString["id"].ToString();
        lblRezultat.Text = Request["ime"].ToString() + " " 
                         + Request["id"].ToString();
    }
}