﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcFriendsSite.Data;

namespace MvcFriendsSite.Migrations
{
    [DbContext(typeof(MvcFriendsSiteContext))]
    [Migration("20201207055240_hardikMigration")]
    partial class hardikMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MvcFriendsSite.Models.BlogModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Headline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("MvcFriendsSite.Models.SocialModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("UserModelId")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("friendsEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("profilePicUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.HasIndex("UserModelId");

                    b.ToTable("SocialModel");
                });

            modelBuilder.Entity("MvcFriendsSite.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("BlogModelId")
                        .HasColumnType("int");

                    b.Property<string>("alias")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime>("dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("socialWebsite")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("website")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.HasIndex("BlogModelId");

                    b.ToTable("UserModel");
                });

            modelBuilder.Entity("MvcFriendsSite.Models.BlogModel", b =>
                {
                    b.HasOne("MvcFriendsSite.Models.UserModel", "Author")
                        .WithMany("Blogs")
                        .HasForeignKey("AuthorId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("MvcFriendsSite.Models.SocialModel", b =>
                {
                    b.HasOne("MvcFriendsSite.Models.UserModel", null)
                        .WithMany("userToSocialFK")
                        .HasForeignKey("UserModelId");
                });

            modelBuilder.Entity("MvcFriendsSite.Models.UserModel", b =>
                {
                    b.HasOne("MvcFriendsSite.Models.BlogModel", null)
                        .WithMany("blogToUserFK")
                        .HasForeignKey("BlogModelId");
                });

            modelBuilder.Entity("MvcFriendsSite.Models.BlogModel", b =>
                {
                    b.Navigation("blogToUserFK");
                });

            modelBuilder.Entity("MvcFriendsSite.Models.UserModel", b =>
                {
                    b.Navigation("Blogs");

                    b.Navigation("userToSocialFK");
                });
#pragma warning restore 612, 618
        }
    }
}
