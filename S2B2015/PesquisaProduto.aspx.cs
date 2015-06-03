using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace S2B2015
{
    public partial class PesquisaProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdioPesquisa.SelectedItem.Text == "Nome do Produto")
            {
                Response.Redirect("default");
            }
            else
            {

            }
        }

        protected void drplstCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}