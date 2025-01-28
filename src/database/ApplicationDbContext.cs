using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gerenciadorViagens_windowsForm_csharp.src.model;

namespace gerenciadorViagens_windowsForm_csharp.src.database
{
    internal class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext() : base("name=DefaultConnection")
        {
        }

        public DbSet<Travel> Travels { get; set; }
        public DbSet<Activities> Activities { get; set; }
    }
}
