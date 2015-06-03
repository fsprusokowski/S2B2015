using S2B2015.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace S2B2015
{
    public partial class DadosProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //StoreEntities _db = new StoreEntities();
            //Load_Data(_db);

            //gwDadosProd.DataSource = _db.Produtos.ToList();
            //gwDadosProd.DataBind();



            int id;
            string param =  Request.QueryString["ProdutoId"];

            if (!Int32.TryParse(param, out  id))
            {
                lblTitulo.Text = "Produto não encontrado!";
                btnComprar.Visible = false;
            }
            else
            {
                StoreEntities _db = new StoreEntities();
                Produto query = (Produto)(from a in _db.Produtos
                                where a.ProdutoId == id
                                select a).FirstOrDefault();

                

                if (query != null)
                {
                    ViewState["id"] = id;
                    lblTitulo.Text = query.strTitulo;
                    imgProduto.ImageUrl = query.strLink;
                    lblCategoria.Text = query.oCategoria.strTitulo;
                    lblPreco.Text = query.Preco.ToString();
                    
                    HtmlString o = new HtmlString(query.strDescrição);

                    string s = o.ToHtmlString();
                    string a = o.ToString();


                    String myEncodedString;
                    // Encode the string.
                    myEncodedString = HttpUtility.HtmlEncode(query.strDescrição);

                    myEncodedString = HttpUtility.HtmlDecode(query.strDescrição);

                    System.IO.StringWriter myWriter = new System.IO.StringWriter();

                    HttpUtility.HtmlDecode(myEncodedString, myWriter);
                    
                    HtmlGenericControl divControl = new HtmlGenericControl("div");
                    

                    divControl.Attributes.Add("id", "asssw");
                    divControl.Attributes.Add("innerHtml", "bob");
                    divControl.InnerHtml = myEncodedString;
                    divControl.Visible = true;
                    this.Controls.Add(divControl);


                    //txtDescricao.Text = query.strDescrição;
                    txtDescricao.Text = Server.HtmlDecode(myEncodedString);


                }
                else
                {
                    lblTitulo.Text = "Solicitação inválida";
                    btnComprar.Visible = false;
                }
            }
        




        }

        void Load_Data(StoreEntities db)
        {


            imgProduto.ImageUrl = "";

        }



    }
}