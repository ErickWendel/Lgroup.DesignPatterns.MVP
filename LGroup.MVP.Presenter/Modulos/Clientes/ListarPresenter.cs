using LGroup.MVP.Model;
using LGroup.MVP.View.Modulos.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.MVP.Presenter.Modulos.Clientes
{

    //Para caada tela criamos 1 VIEW e 1 PRESENTER
    //VIEW -> São os campos da tela
    //PRESENTER -> São os comandos a programação da tela
    //A grosso modo é tipo um CONTROLLER

   public sealed  class ListarPresenter
    {
       private IListarView _listarView;
       public ListarPresenter(IListarView listarView_)
       {
           _listarView = listarView_;
       }

       public void Carregar()
       {
           //simulamos uma lista de dados
           //finge que que veio do banco
           var listaClientes = new List<ClienteModel> {
               new ClienteModel { Nome = "Erick", Telefone = "123123123", DataNascimento = new DateTime(2000,10,10)  },
               new ClienteModel { Nome = "Erick2", Telefone = "1231231233", DataNascimento = new DateTime(2000,10,3)  },
               new ClienteModel { Nome = "Erick3", Telefone = "1231231232", DataNascimento = new DateTime(2000,10,2)  },

           };
           _listarView.Clientes = listaClientes;
       }
    }
}
