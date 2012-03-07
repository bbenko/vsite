using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BrojiPostBack : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            ViewState["broj"] = (int)ViewState["broj"] + 1;
        }
        else
        {
            ViewState["broj"] = 0;
        }
        lblBroj.Text = ViewState["broj"].ToString();
    }
}