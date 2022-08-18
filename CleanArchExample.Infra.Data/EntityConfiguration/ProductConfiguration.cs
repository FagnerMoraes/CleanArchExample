using CleanArchExample.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CleanArchExample.Infra.Data.EntityConfiguration
{
    public class ProductCondiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //Nome da tabela
            builder.ToTable("Product");

            //tamanho maximo 100, requerido
            builder.Property(p => p.Name)
                .HasMaxLength(100)
                .IsRequired();

            //tamanho maximo 300, requerido
            builder.Property(p => p.Description)
                .HasMaxLength(300)
                .IsRequired();

            // 10 digitos, 2 casa decimais
            builder.Property(p => p.Price)
                .HasPrecision(10, 2);

            builder.HasData(
                new Product(1,"Book","Book about DDD",123.30m),
                new Product(2, "Book2", "Book about Clean Code", 127.40m)
                );
        }
    }
}
