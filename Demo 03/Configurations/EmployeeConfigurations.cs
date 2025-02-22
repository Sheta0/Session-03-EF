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
    class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> E)
        {
            E.HasKey(e => e.Id);
            E.Property(e => e.Id).UseIdentityColumn(10, 10);
            E.Property(e => e.Name).HasColumnName("EmpName")
                                   .IsRequired()
                                   .HasMaxLength(50)
                                   .HasColumnType("varchar");

            E.Property(e => e.Salary).HasColumnType("money");

            E.Property(e => e.Address).HasColumnType("varchar").HasMaxLength(100);

            E.Property(e => e.HiringDate).HasDefaultValueSql("GETDATE()");

            E.HasOne(e => e.WorkFor)
             .WithMany(d => d.Employees)
             .HasForeignKey(e => e.DeptId);
        }
    }
}
