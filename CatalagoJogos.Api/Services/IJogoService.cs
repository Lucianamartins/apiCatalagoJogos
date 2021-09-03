using CatalagoJogos.Api.InputModel;
using CatalagoJogos.Api.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalagoJogos.Api.Services
{
    public  interface IJogoService
    {
        Task<List<JogoViewModel>> Obter(int pagina, int quantidade);
        Task<JogoViewModel> Obter(Guid id);
        Task<JogoViewModel> Inserir(JogoInputModel jogo);
        Task Atualizar(Guid id, JogoInputModel jogo);
        Task Atualizar(Guid id, double preco);
        Task Remover(Guid id);
    }
}
