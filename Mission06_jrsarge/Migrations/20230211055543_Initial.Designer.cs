﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_jrsarge.Models;

namespace Mission06_jrsarge.Migrations
{
    [DbContext(typeof(MovieSubmissionContext))]
    [Migration("20230211055543_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission06_jrsarge.Models.MovieSubmission", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<short>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            Category = "Family",
                            Director = "Chris Buck",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "G",
                            Title = "Tarzan",
                            Year = (short)1999
                        },
                        new
                        {
                            MovieID = 2,
                            Category = "Family",
                            Director = "Rob Minkoff",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG",
                            Title = "Stuart Little",
                            Year = (short)1999
                        },
                        new
                        {
                            MovieID = 3,
                            Category = "Family",
                            Director = "Chris Buck",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG",
                            Title = "Frozen",
                            Year = (short)2013
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
