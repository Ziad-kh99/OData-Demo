namespace ODataOrdersAPI.Data;



public class CustomerConfig : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.FirstName)
            .HasColumnType("VARCHAR(50)")
            .IsRequired();
            
        builder.Property(e => e.LastName)
            .HasColumnType("VARCHAR(50)")
            .IsRequired();

        
        builder.Property(e => e.Address)
            .HasColumnType("VARCHAR(256)")
            .IsRequired();
    }
}