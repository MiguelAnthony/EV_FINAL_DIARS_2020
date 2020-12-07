using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Ev_Final_DIARS_N00036571_.Models.Map
{
    public class EtiquetaMap : IEntityTypeConfiguration<Etiqueta>

    {
        public void Configure(EntityTypeBuilder<Etiqueta> builder)
        {
            builder.ToTable("Etiqueta");
            builder.HasKey(o => o.Id);

        }
    }
}
