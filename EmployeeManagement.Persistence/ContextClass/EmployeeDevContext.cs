using EmployeeManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Persistence.ContextClass
{
    public partial class EmployeeDevContext : DbContext
    {
        public EmployeeDevContext()
        {
        }

        public EmployeeDevContext(DbContextOptions<EmployeeDevContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressType> AddressType { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<Manager> Manager { get; set; }
        public virtual DbSet<ManagerDepartment> ManagerDepartment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EmployeeDev;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeId");

                entity.Property(e => e.Line1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Line2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.AddressTypeId)
                    .HasConstraintName("FK__Address__Address__45F365D3");
            });

            modelBuilder.Entity<AddressType>(entity =>
            {
                entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeId");

                entity.Property(e => e.AddressDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Employee__Addres__4D94879B");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Employee__Depart__4CA06362");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Employee__Gender__49C3F6B7");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Employee__JobID__4BAC3F29");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Employee__Manage__4AB81AF0");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.GenderDescription)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.ManagerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Manager)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__Manager__Departm__3B75D760");
            });

            modelBuilder.Entity<ManagerDepartment>(entity =>
            {
                entity.Property(e => e.ManagerDepartmentId).HasColumnName("ManagerDepartmentID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.ManagerDepartment)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ManagerDe__Depar__3F466844");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.ManagerDepartment)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ManagerDe__Manag__3E52440B");
            });
        }
    }
}