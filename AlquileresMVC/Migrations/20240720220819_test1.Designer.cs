﻿// <auto-generated />
using System;
using AlquileresMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AlquileresMVC.Migrations
{
    [DbContext(typeof(AdminDbContext))]
    [Migration("20240720220819_test1")]
    partial class test1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AlquileresMVC.Models.Admin.Extras", b =>
                {
                    b.Property<int>("ExtraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExtraId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.HasKey("ExtraId");

                    b.ToTable("Extras");
                });

            modelBuilder.Entity("AlquileresMVC.Models.Admin.FormaDePago", b =>
                {
                    b.Property<int>("FormaDePagoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormaDePagoId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("reservaId")
                        .HasColumnType("int");

                    b.HasKey("FormaDePagoId");

                    b.HasIndex("reservaId");

                    b.ToTable("FormasDePago");
                });

            modelBuilder.Entity("AlquileresMVC.Models.Admin.Reserva", b =>
                {
                    b.Property<int>("ReservaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservaId"));

                    b.Property<int>("FKIdUsuario")
                        .HasColumnType("int");

                    b.Property<int>("FKIdVehiculo")
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaEntrada")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaSalida")
                        .HasColumnType("date");

                    b.HasKey("ReservaId");

                    b.HasIndex("FKIdUsuario");

                    b.HasIndex("FKIdVehiculo");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("AlquileresMVC.Models.Admin.ReservaExtras", b =>
                {
                    b.Property<int>("FKIdReserva")
                        .HasColumnType("int");

                    b.Property<int>("FKIdExtra")
                        .HasColumnType("int");

                    b.HasKey("FKIdReserva", "FKIdExtra");

                    b.HasIndex("FKIdExtra");

                    b.ToTable("ReservaExtras");
                });

            modelBuilder.Entity("AlquileresMVC.Models.Admin.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("Apellido1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Apellido2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("FechaNacimiento")
                        .HasColumnType("date");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("AlquileresMVC.Models.Admin.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("precioDia")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("AlquileresMVC.Models.Admin.FormaDePago", b =>
                {
                    b.HasOne("AlquileresMVC.Models.Admin.Reserva", null)
                        .WithMany()
                        .HasForeignKey("reservaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AlquileresMVC.Models.Admin.Reserva", b =>
                {
                    b.HasOne("AlquileresMVC.Models.Admin.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("FKIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AlquileresMVC.Models.Admin.Vehiculo", "vehiculo")
                        .WithMany()
                        .HasForeignKey("FKIdVehiculo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("usuario");

                    b.Navigation("vehiculo");
                });

            modelBuilder.Entity("AlquileresMVC.Models.Admin.ReservaExtras", b =>
                {
                    b.HasOne("AlquileresMVC.Models.Admin.Extras", "extra")
                        .WithMany("OrderExtras")
                        .HasForeignKey("FKIdExtra")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AlquileresMVC.Models.Admin.Reserva", "reserva")
                        .WithMany("ExtrasReserva")
                        .HasForeignKey("FKIdReserva")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("extra");

                    b.Navigation("reserva");
                });

            modelBuilder.Entity("AlquileresMVC.Models.Admin.Extras", b =>
                {
                    b.Navigation("OrderExtras");
                });

            modelBuilder.Entity("AlquileresMVC.Models.Admin.Reserva", b =>
                {
                    b.Navigation("ExtrasReserva");
                });
#pragma warning restore 612, 618
        }
    }
}