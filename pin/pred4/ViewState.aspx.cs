using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class ViewState : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnPromjeniBoju_Click(object sender, EventArgs e)
    {
        txtBezViewState.BackColor = Color.Yellow;
        txtSaViewState.BackColor = Color.Yellow;
    }
}