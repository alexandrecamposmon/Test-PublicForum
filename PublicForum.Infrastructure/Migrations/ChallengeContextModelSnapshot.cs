using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using PublicForum.Infrastructure.Context;
using System;

namespace PublicForum.Infrastructure.Migrations
{
    [DbContext(typeof(ChallengeContext))]
    partial class ChallengeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PublicForum.ApplicationCore.Models.Topic", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Content")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("CriationDate")
                    .HasColumnType("datetime2");

                b.Property<string>("CriationUser")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Title")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Topic");
            });

            modelBuilder.Entity("PublicForum.ApplicationCore.Models.Login", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("User")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Pass")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.ToTable("Login");
            });
#pragma warning restore 612, 618
        }
    }
}
