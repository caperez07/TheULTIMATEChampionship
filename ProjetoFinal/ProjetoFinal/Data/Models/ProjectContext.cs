using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System;
using ProjetoFinal.Data.Models;
using Microsoft.Data.SqlClient;

namespace ProjetoFinal.Data.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {

        }

        public DbSet<Characters> Characters { get; set; }

    }
}

