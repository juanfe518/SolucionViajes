// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SolucionNewShore.Contexto;

#nullable disable

namespace SolucionNewShore.Migrations
{
    [DbContext(typeof(DbContexto))]
    partial class DbContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SolucionNewShore.Modelos.Transporte", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("companiaAerea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numeroDeVuelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Transportes");
                });

            modelBuilder.Entity("SolucionNewShore.Modelos.Viaje", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("destino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("origen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("precio")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("Viajes");
                });

            modelBuilder.Entity("SolucionNewShore.Modelos.ViajeVuelo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("Viajeid")
                        .HasColumnType("int");

                    b.Property<int>("Vueloid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Viajeid");

                    b.HasIndex("Vueloid");

                    b.ToTable("Factura");
                });

            modelBuilder.Entity("SolucionNewShore.Modelos.Vuelo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("Viajeid")
                        .HasColumnType("int");

                    b.Property<string>("destino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("origen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("precio")
                        .HasColumnType("float");

                    b.Property<int>("transporteid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Viajeid");

                    b.HasIndex("transporteid");

                    b.ToTable("Vuelos");
                });

            modelBuilder.Entity("SolucionNewShore.Modelos.ViajeVuelo", b =>
                {
                    b.HasOne("SolucionNewShore.Modelos.Viaje", "Viaje")
                        .WithMany()
                        .HasForeignKey("Viajeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SolucionNewShore.Modelos.Vuelo", "Vuelo")
                        .WithMany()
                        .HasForeignKey("Vueloid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Viaje");

                    b.Navigation("Vuelo");
                });

            modelBuilder.Entity("SolucionNewShore.Modelos.Vuelo", b =>
                {
                    b.HasOne("SolucionNewShore.Modelos.Viaje", null)
                        .WithMany("vuelos")
                        .HasForeignKey("Viajeid");

                    b.HasOne("SolucionNewShore.Modelos.Transporte", "transporte")
                        .WithMany()
                        .HasForeignKey("transporteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("transporte");
                });

            modelBuilder.Entity("SolucionNewShore.Modelos.Viaje", b =>
                {
                    b.Navigation("vuelos");
                });
#pragma warning restore 612, 618
        }
    }
}
