﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoTravelCan.Models;

namespace ProyectoTravelCan.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20191117040933_Tarjeta")]
    partial class Tarjeta
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ProyectoTravelCan.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Celular")
                        .IsRequired();

                    b.Property<string>("Correo")
                        .IsRequired();

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("Nombres")
                        .IsRequired();

                    b.Property<int?>("PerroId");

                    b.HasKey("Id");

                    b.HasIndex("PerroId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ProyectoTravelCan.Models.Perro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CartillaSanitaria")
                        .IsRequired();

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.Property<int>("Edad");

                    b.Property<string>("Foto")
                        .IsRequired();

                    b.Property<string>("NombreMascota")
                        .IsRequired();

                    b.Property<string>("Raza")
                        .IsRequired();

                    b.Property<string>("Sexo")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Perros");
                });

            modelBuilder.Entity("ProyectoTravelCan.Models.ReservaViaje", b =>
                {
                    b.Property<int>("IdCliente");

                    b.Property<int>("IdViaje");

                    b.Property<DateTime>("Fecha");

                    b.Property<int?>("clientesId");

                    b.HasKey("IdCliente", "IdViaje");

                    b.HasIndex("clientesId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("ProyectoTravelCan.Models.Reseña", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CorreoUsuario");

                    b.Property<string>("Descripcion");

                    b.Property<string>("Foto");

                    b.HasKey("Id");

                    b.ToTable("Reseñas");
                });

            modelBuilder.Entity("ProyectoTravelCan.Models.Tarjeta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Año");

                    b.Property<int>("CVV");

                    b.Property<int>("Mes");

                    b.Property<string>("NombreEnTarjeta")
                        .IsRequired();

                    b.Property<int>("NumeroTarjeta");

                    b.HasKey("Id");

                    b.ToTable("Tarjetas");
                });

            modelBuilder.Entity("ProyectoTravelCan.Models.Viaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Costo");

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.Property<string>("DescripcionCompleta")
                        .IsRequired();

                    b.Property<DateTime>("Fecha");

                    b.Property<string>("Foto")
                        .IsRequired();

                    b.Property<string>("nombreDestino")
                        .IsRequired();

                    b.Property<string>("nombrePartida")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Viajes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProyectoTravelCan.Models.Cliente", b =>
                {
                    b.HasOne("ProyectoTravelCan.Models.Perro", "perro")
                        .WithMany()
                        .HasForeignKey("PerroId");
                });

            modelBuilder.Entity("ProyectoTravelCan.Models.ReservaViaje", b =>
                {
                    b.HasOne("ProyectoTravelCan.Models.Cliente", "clientes")
                        .WithMany()
                        .HasForeignKey("clientesId");
                });
#pragma warning restore 612, 618
        }
    }
}
