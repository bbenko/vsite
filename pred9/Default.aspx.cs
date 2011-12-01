using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            txtPrvi.BackColor = Color.Blue;
            txtDrugi.BackColor = Color.Blue;
            Session["ime"] = "Pero";


        }
    }
}