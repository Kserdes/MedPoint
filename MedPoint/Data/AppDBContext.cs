using MedPoint.Areas.Identity.Data;
using MedPoint.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MedPoint.Data;

public class AppDBContext : IdentityDbContext<IdentityAccount>
{
    public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfiguration(new AppUserConfiguration());
        builder.Entity<DoctorVisit>().HasOne(m => m.Doctor).WithMany(am => am.DoctorVisit).HasForeignKey(m => m.DoctorID);
        builder.Entity<DoctorVisit>().HasOne(m => m.Visit).WithMany(am => am.DoctorVisit).HasForeignKey(m => m.VisitID);
    }

    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Visit> Visits { get; set; }
    public DbSet<DoctorVisit> DoctorVisit { get; set; }
}

