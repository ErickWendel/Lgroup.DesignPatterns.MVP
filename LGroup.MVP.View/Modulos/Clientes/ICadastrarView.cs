using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.MVP.View.Modulos.Clientes
{
    public interface ICadastrarView
    {
        String Nome { get; set; }
        String Email { get; set; }
        String Telefone { get; set; }
        DateTime DataNascimento { get; set; }
        //Nao precisamos recuperar o dado, entao é só set
        String Mensagem { set; }

    }
}
