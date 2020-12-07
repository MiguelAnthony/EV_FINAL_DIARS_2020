using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Ev_Final_DIARS_N00036571_.Models.Map
{
    public class NotaMap : IEntityTypeConfiguration<Nota>

    {
        public void Configure(EntityTypeBuilder<Nota> builder)
        {
            builder.ToTable("Reg_Notas");
            builder.HasKey(o => o.Id);
        }
    }
}
