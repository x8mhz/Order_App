using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderApp.Models;

namespace OrderApp.Mappings
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName)
                .IsRequired();

            builder.Property(x => x.LastName)
                .IsRequired();

            builder.Property(x => x.Document)
                .IsRequired();

            builder.Property(x => x.Phone)
                .IsRequired();

            builder.HasOne(x => x.User)
                .WithOne(x => x.Customer)
                .HasForeignKey<User>("FK_Customer_User");
        }
    }
}
