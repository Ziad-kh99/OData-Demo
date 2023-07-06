namespace ODataOrdersAPI.Data;


public class OrderConfig : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.OrderDate)
            .HasColumnType("DATE");

        builder.HasOne(e => e.Customer)
            .WithMany(e => e.Orders);

        builder.HasOne(e => e.Product)
            .WithMany(e => e.Orders);
            
    }
}