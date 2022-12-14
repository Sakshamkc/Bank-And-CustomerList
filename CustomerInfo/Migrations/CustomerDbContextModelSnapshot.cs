// <auto-generated />
using CustomerInfo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CustomerInfo.Migrations
{
    [DbContext(typeof(CustomerDbContext))]
    partial class CustomerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CustomerInfo.Models.Bank", b =>
                {
                    b.Property<int>("BankId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100");

                    b.Property<string>("Branch")
                        .IsRequired()
                        .HasColumnType("nvarchar(100");

                    b.HasKey("BankId");

                    b.ToTable("Bank");
                });

            modelBuilder.Entity("CustomerInfo.Models.Customers", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(100");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100");

                    b.HasKey("CustomerId");

                    b.ToTable("customers");
                });
#pragma warning restore 612, 618
        }
    }
}
