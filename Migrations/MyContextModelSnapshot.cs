// <auto-generated />
using System;
using ActivityCenter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ActivityCenter.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ActivityCenter.Models.Shindig", b =>
                {
                    b.Property<int>("shindigId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("duration")
                        .HasColumnType("int");

                    b.Property<string>("durationAmt")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("startTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("shindigId");

                    b.HasIndex("userId");

                    b.ToTable("Shindigs");
                });

            modelBuilder.Entity("ActivityCenter.Models.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("userId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ActivityCenter.Models.User_Shindig", b =>
                {
                    b.Property<int>("user_ShindigId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("shindigId")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("user_ShindigId");

                    b.HasIndex("shindigId");

                    b.HasIndex("userId");

                    b.ToTable("User_Shindigs");
                });

            modelBuilder.Entity("ActivityCenter.Models.Shindig", b =>
                {
                    b.HasOne("ActivityCenter.Models.User", "UserRef")
                        .WithMany("myShindig")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ActivityCenter.Models.User_Shindig", b =>
                {
                    b.HasOne("ActivityCenter.Models.Shindig", "Shindig")
                        .WithMany("connections")
                        .HasForeignKey("shindigId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ActivityCenter.Models.User", "User")
                        .WithMany("connections")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
