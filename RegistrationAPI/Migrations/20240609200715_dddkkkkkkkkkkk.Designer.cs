﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistrationAPI.DATA;

#nullable disable

namespace RegistrationAPI.Migrations
{
    [DbContext(typeof(LoginModelDBContext))]
    [Migration("20240609200715_dddkkkkkkkkkkk")]
    partial class dddkkkkkkkkkkk
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClassAPI.MODEL.LoginModel", b =>
                {
                    b.Property<int>("srno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SrNo");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("srno"));

                    b.Property<string>("custname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("custname");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Password");

                    b.Property<string>("userid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UserId");

                    b.HasKey("srno");

                    b.ToTable("UserInformation");
                });
#pragma warning restore 612, 618
        }
    }
}
