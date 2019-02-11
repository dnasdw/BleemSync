﻿// <auto-generated />
using System;
using BleemSync.Central.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BleemSync.Central.Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190210091359_Seed")]
    partial class Seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BleemSync.Central.Data.Models.EsrbRatingDescriptor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("GameId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("EsrbRatingDescriptors");
                });

            modelBuilder.Entity("BleemSync.Central.Data.Models.GameGenre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("GameId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("BleemSync.Central.Data.Models.PegiRatingDescriptor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("GameId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("PegiRatingDescriptors");
                });

            modelBuilder.Entity("BleemSync.Central.Data.Models.PlayStation.Art", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DiscId");

                    b.Property<string>("File");

                    b.Property<int?>("GameId");

                    b.Property<bool>("IsGreatestHits");

                    b.Property<decimal>("Rating");

                    b.Property<int>("RatingVoteCount");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("DiscId");

                    b.HasIndex("GameId");

                    b.ToTable("PlayStation_Art");
                });

            modelBuilder.Entity("BleemSync.Central.Data.Models.PlayStation.Disc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DiscNumber");

                    b.Property<string>("Fingerprint");

                    b.Property<int?>("GameId");

                    b.Property<int>("TrackCount");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("PlayStation_Discs");
                });

            modelBuilder.Entity("BleemSync.Central.Data.Models.PlayStation.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AnalogCompatible");

                    b.Property<DateTime>("DateReleased");

                    b.Property<string>("Description");

                    b.Property<string>("Developer");

                    b.Property<bool>("DigitalCompatible");

                    b.Property<int>("EsrbRating");

                    b.Property<string>("Fingerprint");

                    b.Property<bool>("LightGunCompatible");

                    b.Property<bool>("LinkCableCompatible");

                    b.Property<int>("MemoryCardBlockCount");

                    b.Property<bool>("MultitapCompatible");

                    b.Property<bool>("OfficiallyLicensed");

                    b.Property<int>("PegiRating");

                    b.Property<string>("Players");

                    b.Property<string>("Publisher");

                    b.Property<int>("Region");

                    b.Property<string>("Title");

                    b.Property<string>("Version");

                    b.Property<bool>("VibrationCompatible");

                    b.HasKey("Id");

                    b.ToTable("PlayStation_Games");
                });

            modelBuilder.Entity("BleemSync.Central.Data.Models.EsrbRatingDescriptor", b =>
                {
                    b.HasOne("BleemSync.Central.Data.Models.PlayStation.Game")
                        .WithMany("EsrbRatingDescriptors")
                        .HasForeignKey("GameId");
                });

            modelBuilder.Entity("BleemSync.Central.Data.Models.GameGenre", b =>
                {
                    b.HasOne("BleemSync.Central.Data.Models.PlayStation.Game")
                        .WithMany("Genres")
                        .HasForeignKey("GameId");
                });

            modelBuilder.Entity("BleemSync.Central.Data.Models.PegiRatingDescriptor", b =>
                {
                    b.HasOne("BleemSync.Central.Data.Models.PlayStation.Game")
                        .WithMany("PegiDescriptors")
                        .HasForeignKey("GameId");
                });

            modelBuilder.Entity("BleemSync.Central.Data.Models.PlayStation.Art", b =>
                {
                    b.HasOne("BleemSync.Central.Data.Models.PlayStation.Disc", "Disc")
                        .WithMany("Art")
                        .HasForeignKey("DiscId");

                    b.HasOne("BleemSync.Central.Data.Models.PlayStation.Game", "Game")
                        .WithMany("Art")
                        .HasForeignKey("GameId");
                });

            modelBuilder.Entity("BleemSync.Central.Data.Models.PlayStation.Disc", b =>
                {
                    b.HasOne("BleemSync.Central.Data.Models.PlayStation.Game", "Game")
                        .WithMany("Discs")
                        .HasForeignKey("GameId");
                });
#pragma warning restore 612, 618
        }
    }
}
