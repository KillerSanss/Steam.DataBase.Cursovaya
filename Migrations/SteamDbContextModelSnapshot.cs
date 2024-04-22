﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using steam.Infrastructure.Context;

#nullable disable

namespace steam.Migrations
{
    [DbContext(typeof(SteamDbContext))]
    partial class SteamDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("steam.Infrastructure.Entities.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nick_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("registration_date");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("steam.Infrastructure.Entities.Card", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<double>("Ballance")
                        .HasColumnType("double precision")
                        .HasColumnName("ballance");

                    b.Property<string>("CVV")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("cvv");

                    b.Property<DateTime>("ExperationDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("experaation_date");

                    b.Property<string>("NameOnCard")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name_on_card");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("number");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("steam.Infrastructure.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("order_date");

                    b.Property<double>("Price")
                        .HasColumnType("double precision")
                        .HasColumnName("price");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid")
                        .HasColumnName("product_id");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("steam.Infrastructure.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<int>("Category")
                        .HasColumnType("integer")
                        .HasColumnName("category");

                    b.Property<DateTime>("DateOfDevelopment")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_of_development");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<double>("Price")
                        .HasColumnType("double precision")
                        .HasColumnName("price");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("steam.Infrastructure.Entities.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid?>("AdminId")
                        .HasColumnType("uuid")
                        .HasColumnName("admin_id");

                    b.Property<string>("Answer")
                        .HasColumnType("text")
                        .HasColumnName("answer");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("creation_date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("UserId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("steam.Infrastructure.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<double>("Ballance")
                        .HasColumnType("double precision")
                        .HasColumnName("ballance");

                    b.Property<Guid?>("CardId")
                        .HasColumnType("uuid")
                        .HasColumnName("card_id");

                    b.Property<Guid?>("CardId1")
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nickname");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("registration_date");

                    b.Property<int>("Role")
                        .HasColumnType("integer")
                        .HasColumnName("role");

                    b.HasKey("Id");

                    b.HasIndex("CardId1");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("steam.Infrastructure.Entities.Order", b =>
                {
                    b.HasOne("steam.Infrastructure.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("steam.Infrastructure.Entities.Product", b =>
                {
                    b.HasOne("steam.Infrastructure.Entities.User", "User")
                        .WithMany("Products")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("steam.Infrastructure.Entities.Question", b =>
                {
                    b.HasOne("steam.Infrastructure.Entities.Admin", "Admin")
                        .WithMany("Questions")
                        .HasForeignKey("AdminId");

                    b.HasOne("steam.Infrastructure.Entities.User", "User")
                        .WithMany("Questions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("User");
                });

            modelBuilder.Entity("steam.Infrastructure.Entities.User", b =>
                {
                    b.HasOne("steam.Infrastructure.Entities.Card", "Card")
                        .WithMany()
                        .HasForeignKey("CardId1");

                    b.Navigation("Card");
                });

            modelBuilder.Entity("steam.Infrastructure.Entities.Admin", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("steam.Infrastructure.Entities.User", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Products");

                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
