﻿// <auto-generated />
using System;
using Blog.PostgreSQL.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Blog.PostgreSQL.EF.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20190901135818_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Blog.Domain.BlogEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("blog_entry_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<DateTime>("BlogEntryDate")
                        .HasColumnName("blog_entry_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("BlogEntryName")
                        .IsRequired()
                        .HasColumnName("blog_entry_name")
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id")
                        .HasName("blog_entry_pk");

                    b.HasIndex("BlogEntryName")
                        .IsUnique()
                        .HasName("blog_entry_blog_name_uc");

                    b.ToTable("blog_entry");
                });

            modelBuilder.Entity("Blog.Domain.BlogPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("blog_post_id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<int>("BlogEntryId")
                        .HasColumnName("blog_entry_id");

                    b.Property<string>("BlogPostComment")
                        .IsRequired()
                        .HasColumnName("blog_post_comment")
                        .HasColumnType("text");

                    b.Property<DateTime>("BlogPostDate")
                        .HasColumnName("blog_post_date")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id")
                        .HasName("blog_post_pkey");

                    b.HasIndex("BlogEntryId");

                    b.ToTable("blog_post");
                });

            modelBuilder.Entity("Blog.Domain.BlogPost", b =>
                {
                    b.HasOne("Blog.Domain.BlogEntry", "BlogEntry")
                        .WithMany("BlogPosts")
                        .HasForeignKey("BlogEntryId")
                        .HasConstraintName("blog_post_blog_entry_blog_entry_id_fkey")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
