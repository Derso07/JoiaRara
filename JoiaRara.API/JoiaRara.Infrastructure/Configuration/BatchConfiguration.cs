using JoiaRara.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class BatchConfiguration : IEntityTypeConfiguration<Batch>
{
    public void Configure(EntityTypeBuilder<Batch> builder)
    {
        builder.ToTable("Batch");

        builder.HasKey(b => b.Id);
        builder.Property(b => b.Id).ValueGeneratedNever();

        builder.Property(b => b.BatchCode)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasIndex(b => b.BatchCode).IsUnique();

        builder.Property(b => b.DeliveryDate)
            .HasColumnType("datetime2");

        builder.Property(b => b.DueDate)
            .IsRequired()
            .HasColumnType("datetime2");

        builder.Property(b => b.StatusBatch)
            .IsRequired()
            .HasConversion<string>()
            .HasMaxLength(50);

        builder.HasOne(b => b.Supplier)
            .WithMany()
            .HasForeignKey(b => b.SupplierId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(b => b.Seller)
            .WithMany()
            .HasForeignKey(b => b.SellerId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasIndex(b => new { b.SupplierId, b.SellerId })
            .IsUnique();
        
        builder.HasIndex(b => b.SellerId);
    }
}