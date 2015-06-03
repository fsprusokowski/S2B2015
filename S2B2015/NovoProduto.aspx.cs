using S2B2015.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace S2B2015
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                ShowData();
            
        }

        void ShowData()
        {
            StoreEntities _db = new StoreEntities();
            FillData(_db);
        }

        private void FillData(StoreEntities db)
        {
            var Query = from c in db.Categorias
                        select new
                        {
                            GenreID = c.CategoriaId,
                            GenreName = c.strTitulo
                        };

            cboCategorias.DataSource = Query.ToList();
            cboCategorias.DataValueField = "GenreID";
            cboCategorias.DataTextField = "GenreName";
            cboCategorias.DataBind();
        }

        protected void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnImage_Click(object sender, EventArgs e)
        {
            imgProduto.ImageUrl = txtImage.Text;
        }

        protected void txtImage_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {

        }

    }
}