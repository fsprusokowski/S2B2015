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

        public DateTime dtPublicação;
        public string strTitulo { get; set; }
        public string strLink { get; set; }
        public string strDescrição { get; set; }

        public uint nValidade;
        public int CategoriaId { get; set; }
        public virtual Categoria oCategoria { get; set; }
        public uint Preco { get; set; }
        public int UsuarioId { get; set; }

        public virtual Usuario ousuario { get; set; }
        // perguntas feitas ao vendedor
        public List<Pergunta> lstperguntas;
        // se a oferta esta em atividade ou bloqueada
        public bool bAtivada { get; set; }

        public Produto(string titulo, string descrição, Categoria categoria, uint preço)
        {
            this.strTitulo = titulo;
            this.strDescrição = descrição;
            this.oCategoria = categoria;
            this.Preco = preço;
            this.strLink = "";
        }
    }
}
