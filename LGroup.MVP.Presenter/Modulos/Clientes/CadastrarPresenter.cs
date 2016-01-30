using LGroup.MVP.Model;
using LGroup.MVP.View.Modulos.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.MVP.Presenter.Modulos.Clientes
{
    //A microsoft tem um gerador de codigos
    //para o padrao MVP é WEB CLIENT SOFTWARE FACTORY (WCSF)
    public sealed class CadastrarPresenter
    {
        private ICadastrarView _cadastrarView;
        public CadastrarPresenter(ICadastrarView cadastrarView_)
        {
            _cadastrarView = cadastrarView_;
        }
        public void Limpar()
        {
            //Aqui do presenter, nao acessamos diretamente os campos da tela
            //temos que manipular a VIEW (INTERFACE)
            // e a VIEW seta os dados da tela
            _cadastrarView.Nome = string.Empty;
            _cadastrarView.Email = string.Empty;
            _cadastrarView.Telefone = string.Empty;
            _cadastrarView.DataNascimento = DateTime.Now;
        }


        public void Cadastrar()
        {
            var novoCliente = new ClienteModel
            {
                Nome = _cadastrarView.Nome,
                Email = _cadastrarView.Email,
                DataNascimento = _cadastrarView.DataNascimento,
                Telefone = _cadastrarView.Telefone
            };
            _cadastrarView.Mensagem = "Cadastrado com sucesso"; 

        }
        //Neste momento fariamos o INSERT
        //DAO clienteDao.Cadastrar(clinete)
        //ACTIVE RECORD cliente.Cadastrar();

    }
}
