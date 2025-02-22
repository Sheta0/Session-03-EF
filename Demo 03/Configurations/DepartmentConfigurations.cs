using Demo_03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_03.Configurations
{
    class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            D.HasKey(d => d.Id);
            D.Property(d => d.Id).UseIdentityColumn(100,100);
            D.Property(d => d.Name).IsRequired()
                                   .HasColumnName("DeptName")
                                   .HasMaxLength(50)
                                   .HasColumnType("varchar");
            D.Property(d => d.CreatedAt).HasDefaultValueSql("GETDATE()");
        }
    }
}
