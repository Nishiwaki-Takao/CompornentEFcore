using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq.Expressions;
namespace CompornentEFcore
{
    public static partial class ContextUtility
    {
        public static EntityTypeBuilder<TEntity> ConfigureCopositeSide<TEntity, TRelated, DataType>(
                        this ModelBuilder modelBuilder,
            Expression<Func<TEntity, TRelated>> ConpositeSideProperty,
            TRelated CompornentClass
            )
                        where TEntity : class where TRelated : CompornentClass<TEntity, DataType> where DataType : struct
        {
            modelBuilder.Entity<TEntity>(e =>
            {
                e.Navigation(ConpositeSideProperty);
                e.HasOne(ConpositeSideProperty)
                .WithOne(CompornentClass => CompornentClass.CompornentSideNavigation);
            });
            return modelBuilder.Entity<TEntity>();
        }
        public static EntityTypeBuilder<TEntity> ConfigureCompornentSide<TEntity, TRelated, DataType>(
            this ModelBuilder modelBuilder,
            Expression<Func<TEntity, object>> ConpositeSideID,
            Expression<Func<TEntity, TRelated>> ConpositeSideProperty,
            TRelated CompornentClass)
            where TEntity : class where TRelated : CompornentClass<TEntity, DataType> where DataType : struct
        {
            modelBuilder.Entity<TRelated>(d =>
            {
                d.ToTable(typeof(TEntity).ToString() + '_' + ConpositeSideProperty.Type.ToString() + "_Values");
                d.HasKey(d => d.iD);
                d.Property(d => d.value).IsRequired();
                d.Navigation(d => d.CompornentSideNavigation);
                d.HasOne(d => d.CompornentSideNavigation)
                .WithOne(ConpositeSideProperty)
                   .HasForeignKey(ConpositeSideID);
            });
            return modelBuilder.Entity<TEntity>();
        }
    }
}
