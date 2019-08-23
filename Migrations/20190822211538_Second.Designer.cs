﻿// <auto-generated />
using System;
using GOT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GOT.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20190822211538_Second")]
    partial class Second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GOT.Models.Show", b =>
                {
                    b.Property<int>("ShowId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Genre")
                        .IsRequired();

                    b.Property<int?>("HostUserId");

                    b.Property<string>("Location");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("ShowId");

                    b.HasIndex("HostUserId");

                    b.ToTable("Shows");
                });

            modelBuilder.Entity("GOT.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GOT.Models.UserShow", b =>
                {
                    b.Property<int>("UserShowId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ShowId");

                    b.Property<int>("UserId");

                    b.HasKey("UserShowId");

                    b.HasIndex("ShowId");

                    b.HasIndex("UserId");

                    b.ToTable("UserShows");
                });

            modelBuilder.Entity("GOT.Models.Show", b =>
                {
                    b.HasOne("GOT.Models.User", "Host")
                        .WithMany()
                        .HasForeignKey("HostUserId");
                });

            modelBuilder.Entity("GOT.Models.UserShow", b =>
                {
                    b.HasOne("GOT.Models.Show", "Show")
                        .WithMany("UserShows")
                        .HasForeignKey("ShowId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GOT.Models.User", "User")
                        .WithMany("UserShows")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
