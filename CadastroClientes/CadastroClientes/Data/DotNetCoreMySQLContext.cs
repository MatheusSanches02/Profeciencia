using CadastroClientes.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroClientes.Data
{
    public class DotNetCoreMySQLContext : DbContext
    {
        public DotNetCoreMySQLContext(DbContextOptions<DotNetCoreMySQLContext> options) : base(options) { }
        public DbSet<Pessoa> PessoaFisica { get; set; }
    }
}
