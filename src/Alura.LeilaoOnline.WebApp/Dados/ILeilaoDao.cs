using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDao
    {
        public Leilao BuscarLeilaoPorId(int id);

        public IEnumerable<Leilao> BuscarTodosLeiloes();

        public IEnumerable<Categoria> BuscarTodasCategorias();

        public void IncluirLeilao(Leilao obj);

        public void AlterarLeilao(Leilao obj);

        public void ExcluirLeilao(Leilao leilao);
    }
}
