namespace ODataOrdersAPI.Data;


public class ProductConfig : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.ProductName)
            .HasColumnType("VARCHAR(256)")
            .IsRequired();

        builder.Property(e => e.Price)
            .HasColumnType("DECIMAL(12, 2)")
            .IsRequired();         
    }
}