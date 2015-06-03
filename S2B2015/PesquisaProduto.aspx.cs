using S2B2015.Models;
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
            StoreEntities db = new StoreEntities();

            if (rdioPesquisa.SelectedItem.Text == "Nome do Produto")
            {
                var query = from p in db.Produtos
                            where p.strTitulo.Contains(TxtPesquisa.Text)
                            select p;     
            }
            else
            {

            }
        }

        protected void drplstCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            StoreEntities db = new StoreEntities();
            var query = from p in db.Produtos
                        where p.CategoriaId == (from c in db.Categorias 
                                                where c.strTitulo.Equals(drplstCategoria.Text) 
                                                select c.CategoriaId).First()
                        select p;
        }
    }
}