// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VesterrCFDatabase.DAL;

namespace VesterrCFDatabase.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VesterrCFDatabase.Models.PortfolioCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PortfolioCards");
                });

            modelBuilder.Entity("VesterrCFDatabase.Models.PortfolioCardCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PortfolioCardId")
                        .HasColumnType("int");

                    b.Property<int>("PortfolioCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PortfolioCardId");

                    b.HasIndex("PortfolioCategoryId");

                    b.ToTable("PortfolioCardCategories");
                });

            modelBuilder.Entity("VesterrCFDatabase.Models.PortfolioCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PortfolioCategories");
                });

            modelBuilder.Entity("VesterrCFDatabase.Models.ServiceCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ServiceCards");
                });

            modelBuilder.Entity("VesterrCFDatabase.Models.ServiceIcon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServiceCardId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServiceCardId")
                        .IsUnique();

                    b.ToTable("ServiceIcons");
                });

            modelBuilder.Entity("VesterrCFDatabase.Models.SiteEntrance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GetStarted")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SiteEntrance");
                });

            modelBuilder.Entity("VesterrCFDatabase.Models.PortfolioCardCategory", b =>
                {
                    b.HasOne("VesterrCFDatabase.Models.PortfolioCard", "PortfolioCard")
                        .WithMany("PortfolioCardCategories")
                        .HasForeignKey("PortfolioCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VesterrCFDatabase.Models.PortfolioCategory", "PortfolioCategory")
                        .WithMany("PortfolioCardCategories")
                        .HasForeignKey("PortfolioCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VesterrCFDatabase.Models.ServiceIcon", b =>
                {
                    b.HasOne("VesterrCFDatabase.Models.ServiceCard", null)
                        .WithOne("ServiceIcon")
                        .HasForeignKey("VesterrCFDatabase.Models.ServiceIcon", "ServiceCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
