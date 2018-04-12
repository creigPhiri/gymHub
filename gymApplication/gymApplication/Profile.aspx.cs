﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gymApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["loginValidation"] != null)
            {
                name.Text = Session["userName"].ToString();
                level.Text = Session["level"].ToString();
                Image1.ImageUrl = "pictures/" + Session["profilePicture"].ToString();
            }
            else
            {
                Response.Redirect("loginConfirmation.aspx?response=YouAreNotLoggedIn");
            }
             

        }
    }
}