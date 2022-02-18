﻿// <auto-generated />
using IntroToEF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IntroToEF.Data.Migrations
{
    [DbContext(typeof(SamuraiContext))]
    partial class SamuraiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BattleSamurai", b =>
                {
                    b.Property<int>("BattlesId")
                        .HasColumnType("int");

                    b.Property<int>("SamuraisId")
                        .HasColumnType("int");

                    b.HasKey("BattlesId", "SamuraisId");

                    b.HasIndex("SamuraisId");

                    b.ToTable("BattleSamurai");
                });

            modelBuilder.Entity("IntroToEF.Data.Entities.Battle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Battles");
                });

            modelBuilder.Entity("IntroToEF.Data.Entities.Horse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<bool>("IsWarHorse")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SamuraiId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SamuraiId");

                    b.ToTable("Horses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 3,
                            IsWarHorse = false,
                            Name = "Jolly Jumper",
                            SamuraiId = 1
                        },
                        new
                        {
                            Id = 2,
                            Age = 5,
                            IsWarHorse = true,
                            Name = "Jolly Jumper",
                            SamuraiId = 1
                        },
                        new
                        {
                            Id = 3,
                            Age = 1,
                            IsWarHorse = true,
                            Name = "Jolly Jumper",
                            SamuraiId = 2
                        },
                        new
                        {
                            Id = 4,
                            Age = 12,
                            IsWarHorse = false,
                            Name = "Jolly Jumper",
                            SamuraiId = 5
                        },
                        new
                        {
                            Id = 5,
                            Age = 3,
                            IsWarHorse = false,
                            Name = "Jolly Jumper",
                            SamuraiId = 12
                        });
                });

            modelBuilder.Entity("IntroToEF.Data.Entities.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SamuraiId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("SamuraiId");

                    b.ToTable("Quotes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            SamuraiId = 1,
                            Text = "Summer grasses, All that remains of soldiers' dreams"
                        },
                        new
                        {
                            Id = 2,
                            SamuraiId = 1,
                            Text = "New eras don't come about because of swords, they're created by the people who wield them"
                        },
                        new
                        {
                            Id = 3,
                            SamuraiId = 2,
                            Text = "A man who can't uphold his beliefs is pathetic dead or alive"
                        },
                        new
                        {
                            Id = 4,
                            SamuraiId = 2,
                            Text = "I dreamt of worldly success once"
                        },
                        new
                        {
                            Id = 5,
                            SamuraiId = 5,
                            Text = "Rehearse your death every morning and night. Only when you constantly live as though already a corpse will you be able to find freedom in the martial Way, and fulfill your duties without fault throughout your life"
                        },
                        new
                        {
                            Id = 6,
                            SamuraiId = 5,
                            Text = "The Way of the warrior (bushido) is to be found in dying."
                        },
                        new
                        {
                            Id = 7,
                            SamuraiId = 7,
                            Text = "It is the genius of life that demands of those who partake in it that they are not only the guardians of what was and is, but what will be"
                        },
                        new
                        {
                            Id = 8,
                            SamuraiId = 1,
                            Text = "Bushido is realized in the presence of death. This means choosing death whenever there is a choice between life and death. There is no other reasoning"
                        },
                        new
                        {
                            Id = 9,
                            SamuraiId = 7,
                            Text = "It is the genius of life that demands of those who partake in it that they are not only are guardians of what was and is, but what will be"
                        },
                        new
                        {
                            Id = 10,
                            SamuraiId = 10,
                            Text = "The katana has been the weapon of the samurai since time immemorial. Consider the inner meaning"
                        },
                        new
                        {
                            Id = 11,
                            SamuraiId = 12,
                            Text = "No matter how much you hate or how much you suffer, you can't bring the dead back to life"
                        });
                });

            modelBuilder.Entity("IntroToEF.Data.Entities.Samurai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Dynasty")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Samurais");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Dynasty = "Asuka",
                            Name = "Abe Masakatsu"
                        },
                        new
                        {
                            Id = 2,
                            Dynasty = "Kamakura",
                            Name = "Baba Nobufusa"
                        },
                        new
                        {
                            Id = 3,
                            Dynasty = "Kamakura",
                            Name = "Chosokabe Nobuchika"
                        },
                        new
                        {
                            Id = 4,
                            Dynasty = "Edo",
                            Name = "Date Masamune"
                        },
                        new
                        {
                            Id = 5,
                            Dynasty = "Meiji",
                            Name = "Eto Shinpei"
                        },
                        new
                        {
                            Id = 6,
                            Dynasty = "Meiji",
                            Name = "Fuma Kotaro"
                        },
                        new
                        {
                            Id = 7,
                            Dynasty = "Edo",
                            Name = "Gamo Ujisato"
                        },
                        new
                        {
                            Id = 8,
                            Dynasty = "Asuka",
                            Name = "Harada Nobutane"
                        },
                        new
                        {
                            Id = 9,
                            Dynasty = "Meiji",
                            Name = "Ii Naomasa"
                        },
                        new
                        {
                            Id = 10,
                            Dynasty = "Edo",
                            Name = "Kido Takayoshi"
                        },
                        new
                        {
                            Id = 11,
                            Dynasty = "Edo",
                            Name = "Maeda Toshiie"
                        },
                        new
                        {
                            Id = 12,
                            Dynasty = "Kamakura",
                            Name = "Mori Okimoto"
                        });
                });

            modelBuilder.Entity("BattleSamurai", b =>
                {
                    b.HasOne("IntroToEF.Data.Entities.Battle", null)
                        .WithMany()
                        .HasForeignKey("BattlesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IntroToEF.Data.Entities.Samurai", null)
                        .WithMany()
                        .HasForeignKey("SamuraisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IntroToEF.Data.Entities.Horse", b =>
                {
                    b.HasOne("IntroToEF.Data.Entities.Samurai", "Samurai")
                        .WithMany("Horses")
                        .HasForeignKey("SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Samurai");
                });

            modelBuilder.Entity("IntroToEF.Data.Entities.Quote", b =>
                {
                    b.HasOne("IntroToEF.Data.Entities.Samurai", "Samurai")
                        .WithMany("Quotes")
                        .HasForeignKey("SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Samurai");
                });

            modelBuilder.Entity("IntroToEF.Data.Entities.Samurai", b =>
                {
                    b.Navigation("Horses");

                    b.Navigation("Quotes");
                });
#pragma warning restore 612, 618
        }
    }
}
