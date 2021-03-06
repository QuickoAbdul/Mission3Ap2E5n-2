// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mission3Apsio2.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("Medicament", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Titre")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("informations")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("infos")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("prix")
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)");

                    b.HasKey("id");

                    b.ToTable("Medicaments");
                });
#pragma warning restore 612, 618
        }
    }
}
