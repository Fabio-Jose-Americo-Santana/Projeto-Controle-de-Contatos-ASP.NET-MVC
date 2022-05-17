 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControledeContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControledeContatos.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : 
            base(options)

        {
        }

        public DbSet<ContatoModel> Contatos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
