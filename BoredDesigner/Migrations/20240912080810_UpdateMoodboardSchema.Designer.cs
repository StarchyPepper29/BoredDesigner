﻿// <auto-generated />
using BoredDesigner;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BoredDesigner.Migrations
{
    [DbContext(typeof(BoredDesignerContext))]
    [Migration("20240912080810_UpdateMoodboardSchema")]
    partial class UpdateMoodboardSchema
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BoredDesigner.Moodboard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color5")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryFontUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondaryFontUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TextureImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Moodboards", (string)null);
                });

            modelBuilder.Entity("BoredDesigner.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BoredDesigner.Moodboard", b =>
                {
                    b.HasOne("BoredDesigner.User", null)
                        .WithMany("Moodboards")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("BoredDesigner.User", b =>
                {
                    b.Navigation("Moodboards");
                });
#pragma warning restore 612, 618
        }
    }
}
