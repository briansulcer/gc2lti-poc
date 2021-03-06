﻿// <auto-generated />

using gc2lti_outcomes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace gc2lti_outcomes.Migrations
{
    [DbContext(typeof(Gc2LtiDbContext))]
    partial class Gc2LtiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("catalog_outcomes.Models.GoogleUser", b =>
                {
                    b.Property<string>("GoogleId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(22);

                    b.Property<string>("UserId")
                        .HasMaxLength(36);

                    b.HasKey("GoogleId");

                    b.ToTable("GoogleUsers");
                });

            modelBuilder.Entity("catalog_outcomes.Models.Item", b =>
                {
                    b.Property<string>("Key")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100);

                    b.Property<string>("Value")
                        .HasMaxLength(500);

                    b.HasKey("Key");

                    b.ToTable("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
