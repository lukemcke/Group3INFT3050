﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BeerStore
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Product p = new Product();
                productName.Text = Session["Name"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Add to Cart
        }

        protected void searchbutton_Click(object sender, EventArgs e)
        {
            //Search for products
        }
    }
}