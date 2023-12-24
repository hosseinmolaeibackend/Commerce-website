﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test.Context;

#nullable disable

namespace Test.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20231201130632_add-catagory")]
    partial class addcatagory
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Test.Models.ArticleModel", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticleId"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeRead")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ArticleId");

                    b.HasIndex("UserId");

                    b.ToTable("ArticleModels");
                });

            modelBuilder.Entity("Test.Models.CommentArticleModel", b =>
                {
                    b.Property<int>("CommentArticleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentArticleId"));

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<string>("CommentArticleBody")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CommentArticleId");

                    b.HasIndex("ArticleId");

                    b.HasIndex("UserId");

                    b.ToTable("CommentArticleModels");
                });

            modelBuilder.Entity("Test.Models.CommentModel", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"));

                    b.Property<string>("CommentProductBody")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("CommentModels");
                });

            modelBuilder.Entity("Test.Models.ProductCatagoryModel", b =>
                {
                    b.Property<int>("CatagoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CatagoryId"));

                    b.Property<string>("CatagoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CatagoryId");

                    b.ToTable("ProductCatagoryModels");
                });

            modelBuilder.Entity("Test.Models.ProductCatagorySelectedModel", b =>
                {
                    b.Property<int>("ProductCatagorySelectedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductCatagorySelectedId"));

                    b.Property<int>("CatagoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ProductCatagorySelectedId");

                    b.HasIndex("CatagoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCatagorySelectedModels");
                });

            modelBuilder.Entity("Test.Models.ProductModel", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("ProductModels");
                });

            modelBuilder.Entity("Test.Models.UserModel", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profilimg")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserModels");
                });

            modelBuilder.Entity("Test.Models.ArticleModel", b =>
                {
                    b.HasOne("Test.Models.UserModel", "UserModel")
                        .WithMany("ArticleModels")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("UserModel");
                });

            modelBuilder.Entity("Test.Models.CommentArticleModel", b =>
                {
                    b.HasOne("Test.Models.ArticleModel", "ArticleModel")
                        .WithMany("CommentArticleModels")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Test.Models.UserModel", "UserModel")
                        .WithMany("CommentArticleModels")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ArticleModel");

                    b.Navigation("UserModel");
                });

            modelBuilder.Entity("Test.Models.CommentModel", b =>
                {
                    b.HasOne("Test.Models.ProductModel", "ProductModel")
                        .WithMany("commentModels")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Test.Models.UserModel", "UserModel")
                        .WithMany("CommentModels")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ProductModel");

                    b.Navigation("UserModel");
                });

            modelBuilder.Entity("Test.Models.ProductCatagorySelectedModel", b =>
                {
                    b.HasOne("Test.Models.ProductCatagoryModel", "ProductCatagoryModel")
                        .WithMany("ProductCatagorySelectedModels")
                        .HasForeignKey("CatagoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Test.Models.ProductModel", "ProductModel")
                        .WithMany("ProductCatagorySelectedModels")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ProductCatagoryModel");

                    b.Navigation("ProductModel");
                });

            modelBuilder.Entity("Test.Models.ProductModel", b =>
                {
                    b.HasOne("Test.Models.UserModel", "UserModel")
                        .WithMany("ProductModels")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("UserModel");
                });

            modelBuilder.Entity("Test.Models.ArticleModel", b =>
                {
                    b.Navigation("CommentArticleModels");
                });

            modelBuilder.Entity("Test.Models.ProductCatagoryModel", b =>
                {
                    b.Navigation("ProductCatagorySelectedModels");
                });

            modelBuilder.Entity("Test.Models.ProductModel", b =>
                {
                    b.Navigation("ProductCatagorySelectedModels");

                    b.Navigation("commentModels");
                });

            modelBuilder.Entity("Test.Models.UserModel", b =>
                {
                    b.Navigation("ArticleModels");

                    b.Navigation("CommentArticleModels");

                    b.Navigation("CommentModels");

                    b.Navigation("ProductModels");
                });
#pragma warning restore 612, 618
        }
    }
}
