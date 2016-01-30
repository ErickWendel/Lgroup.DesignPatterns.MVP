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
    public partial class Listar : System.Web.UI.Page, IListarView
    {
        private ListarPresenter _listarPresenter;
        protected void Page_Load(object sender, EventArgs e)
        {
            _listarPresenter = new ListarPresenter(this);
            this.Carregar();
        }

        public ICollection<ClienteModel> Clientes
        {
            get
            {
                return (ICollection<ClienteModel>)grvClientes.DataSource;
            }
            set
            {
                grvClientes.DataSource = value;
                grvClientes.DataBind();
            }
        }

        public void Carregar()
        {
            _listarPresenter.Carregar();
        }
    }
}