using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transactions");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Amount).HasConversion(
                a => decimal.ToDouble(a),
                a => Convert.ToDecimal(a)
                );
            builder.Property(x => x.Fee).HasConversion(
                f => decimal.ToDouble(f),
                f => Convert.ToDecimal(f)
                );
        }
    }
}