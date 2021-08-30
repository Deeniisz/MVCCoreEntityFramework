using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCProjCoreFinal.Models;

namespace MVCProjCoreFinal.Data
{
    public class MVCProjCoreFinalContext : DbContext
    {
        public MVCProjCoreFinalContext (DbContextOptions<MVCProjCoreFinalContext> options)
            : base(options)
        {
        }

        public DbSet<MVCProjCoreFinal.Models.Fornecedor> Fornecedor { get; set; }

        public DbSet<MVCProjCoreFinal.Models.Funcionario> Funcionario { get; set; }

        public DbSet<MVCProjCoreFinal.Models.Produto> Produto { get; set; }
    }
}
