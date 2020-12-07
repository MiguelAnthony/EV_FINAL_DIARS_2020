using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ev_Final_DIARS_N00036571_.Models.Map
{
    public class EtiquetaNotaMap : IEntityTypeConfiguration<EtiquetaNota>
    {
        public void Configure(EntityTypeBuilder<EtiquetaNota> builder)
        {
            builder.ToTable("Detalle_Nota");
            builder.HasKey(o => o.Id);

            builder.HasOne(o => o.Etiqueta).
                WithMany().
                HasForeignKey(o => o.Id_etiqueta);

        }
    }
}
