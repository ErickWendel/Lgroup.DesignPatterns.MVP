using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using LGroup.MVP.View.Modulos.Clientes;
using LGroup.MVP.Model;
using LGroup.MVP.Presenter.Modulos.Clientes;
namespace LGroup.MVP.UI.Web.Modulos.Clientes
{
    public partial class Cadastrar : System.Web.UI.Page, ICadastrarView
    {
        //A tela adicona o presenter (cada tela tem seu proprio PST)
        private CadastrarPresenter _presenterCliente;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Inicializamos o Presenter, a programação da tela
            //aqui foi feito a MACUMBA (AMARRACAO )
            //DA TELA X PRESENTER Injetamos a VIEW
            _presenterCliente = new CadastrarPresenter(this);
        }
        

     
        
        public string Nome
        {
            get
            {
                return txtNome.Text;
            }
            set
            {
                txtNome.Text = value;
            }
        }

        public string Email
        {
            get
            {
                return txtEmail.Text;
            }
            set
            {
                txtEmail.Text = value;
            }
        }

        public string Telefone
        {
            get
            {
                return txtTelefone.Text;
            }
            set
            {
                txtTelefone.Text = value;
            }
        }

        public DateTime DataNascimento
        {
            get
            {
                return Convert.ToDateTime(txtData.Text);
            }
            set
            {
                txtData.Text = value.ToShortDateString();
            }
        }

        public string Mensagem
        {
            //A propria tela exibe a propria mensagem, pois se tiver que colocar
            //no presenter poluiria pelas dlls de web e windows
            set { Response.Write("<script>alert('" + value + "' );</script>"); }
        }
        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            _presenterCliente.Limpar();
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            _presenterCliente.Cadastrar();
            
        }


    }
}