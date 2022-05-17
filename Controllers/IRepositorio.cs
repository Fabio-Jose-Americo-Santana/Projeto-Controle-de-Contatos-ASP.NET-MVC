using ControledeContatos.Models;
using System.Collections.Generic;

namespace ControledeContatos.Controllers
{
    public interface IRepositorio
    {
        ContatoModel ListarPorId(int id);
        List<ContatoModel> BuscarTodos();
        ContatoModel Adcionar(ContatoModel contato);
    }
}