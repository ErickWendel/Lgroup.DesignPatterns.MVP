using LGroup.MVP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.MVP.View.Modulos.Clientes
{
    //As telas (VISUAL) chamamos de APRESENTACAO
    //As interfaces chamamos de VIEW
    //Temos que criar 1 view para cada apresentaca
    //E para cada campo da tela temos que criar 1 propriedade

    //Nao tem como IMPLEMENTAR O PADRAO MVC NO WINDOWS ou FORMS
    //A ideias do MVC é acionarmos o CONTROLLER e o controller CARREGAR
    //a determinada view
    //quando usamos windows forms ele vai direto para a view, nao passa por uma controller

   public interface IListarView
    {
       ICollection<ClienteModel> Clientes { get; set; }
    }
}
