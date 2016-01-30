using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.MVP.Model
{
    //quando falamos de padroes visuais,pardroes que foram feitos 
    //para aplicacoes que tem telas (UI)
    //Temos 3 que os principais e o que todos tem em ocmm é a View e Model
    //VIEW são as telas (Windows Forms, WPF, ASP.NET)
    //Model significa armazenamento de dados, regras de negocio e acesso a dados
    //model sozinho não é um padrao, e um termo arquitetural
    //para ser o padrao tem que ter a sigla completa MVC, MVP, MVVM

    //MVVP E MVP derivam do MVC (1979G)
    //MVC

    //MVVM

    //MVP
    //Não é um padrao GOF
    //É um padrão que existe desde 1990 e foi popularizado em 2006
    // pela Microsoft e Martin Fowler
    //A ideia do padrao é ter acesso individual em cada campo da tela
    //desmembramos a tela dos campos da tela
    //com esse padrao fica facil portar o codigo para outras tecnologias
   public sealed class ClienteModel
    {
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String Email { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
