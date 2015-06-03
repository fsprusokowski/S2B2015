using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2B2015.Models
{
    public  class Produto
    {

        public int ProdutoId { get; set; }

        public DateTime dtPublicação {get;set;}
        public string strTitulo { get; set; }
        public string strLink { get; set; }
        public string strDescrição { get; set; }

        public int nValidade{get;set;}
        public int CategoriaId { get; set; }
        public virtual Categoria oCategoria { get; set; }
        public float Preco { get; set; }
        public int UsuarioId { get; set; }

        public virtual Usuario ousuario { get; set; }
        // perguntas feitas ao vendedor
        public List<Pergunta> lstperguntas {get;set;}
        // se a oferta esta em atividade ou bloqueada
        public bool bAtivada { get; set; }

        public Produto(string titulo, string descrição, Categoria categoria, float preco, int validade)
        {
            this.strTitulo = titulo;
            this.strDescrição = descrição;
            this.oCategoria = categoria;
            this.Preco = preco;
            this.nValidade = validade;
            this.strLink = "";
        }

        public Produto()
        {
            this.dtPublicação = DateTime.Now;
        }
    }
}
