using Ev_Final_DIARS_N00036571_.Models.Map;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ev_Final_DIARS_N00036571_.Models
{
    public class ExamenContext :DbContext
    {
        public DbSet<Nota> Notas { get; set; }
        
        public DbSet<Etiqueta> Etiquetas { get; set; }

        public DbSet<EtiquetaNota> EtiquetaNota { get; set; }

        public ExamenContext(DbContextOptions<ExamenContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new NotaMap());

            modelBuilder.ApplyConfiguration(new EtiquetaMap());

            modelBuilder.ApplyConfiguration(new EtiquetaNotaMap());


        }

    }
}
