using S2B2015.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace S2B2015
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StoreEntities _db = new StoreEntities();

            GridView1.DataSource = _db.Categorias.ToList();
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}