﻿// <auto-generated />
using System;
using CLESportsBlog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CLESportsBlog.Migrations
{
    [DbContext(typeof(TeamContext))]
    [Migration("20200626232656_ViewConnection")]
    partial class ViewConnection
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CLESportsBlog.Models.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Lebron",
                            Body = "Cavs Post",
                            PublishDate = new DateTime(2020, 6, 26, 19, 26, 55, 677, DateTimeKind.Local).AddTicks(8823),
                            TeamId = 1,
                            Title = "Cavs"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Lindor",
                            Body = "Indinas Post",
                            PublishDate = new DateTime(2020, 6, 26, 19, 26, 55, 682, DateTimeKind.Local).AddTicks(351),
                            TeamId = 2,
                            Title = "Indians"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Kosar",
                            Body = "Browns Post",
                            PublishDate = new DateTime(2020, 6, 26, 19, 26, 55, 682, DateTimeKind.Local).AddTicks(430),
                            TeamId = 3,
                            Title = "Browns"
                        });
                });

            modelBuilder.Entity("CLESportsBlog.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageLink = "./images/cavslogo.png",
                            Name = "Cavs"
                        },
                        new
                        {
                            Id = 2,
                            ImageLink = "./images/indianslogo.png",
                            Name = "Indians"
                        },
                        new
                        {
                            Id = 3,
                            ImageLink = "./images/brownslogo.png",
                            Name = "Browns"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
