using JoiaRara.Domain.Entities;
using JoiaRara.Domain.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JoiaRara.Infrastructure.Configuration;

public class JewelConfiguration : IEntityTypeConfiguration<Jewel>
{
    public void Configure(EntityTypeBuilder<Jewel> builder)
    {
        builder.ToTable("Jewel");
        
        builder.HasKey(j => j.Id);
        
        builder.Property(j => j.Id)
            .ValueGeneratedNever();
        
        builder.Property(j => j.Code)
            .IsRequired();
        
        builder.HasIndex(j => j.Code)
            .IsUnique()
            .HasDatabaseName("IX_Jewel_Code");
        
        builder.Property(j => j.Name)
            .IsRequired()
            .HasMaxLength(150);
        
        builder.Property(j => j.Description)
            .IsRequired()
            .HasMaxLength(1000);

        builder.Property(j => j.Price)
            .IsRequired()
            .HasPrecision(18, 2);

        builder.Property(j => j.PhotoURL)
            .IsRequired()
            .HasMaxLength(500)
            .HasColumnName("PhotoUrl"); // nome da coluna diferente da propriedade

        builder.Property(j => j.PhotoId)
            .IsRequired()
            .HasMaxLength(200);
    }
}