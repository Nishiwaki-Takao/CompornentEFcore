using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq.Expressions;
namespace CompornentEFcore
{
    public static partial class ContextUtility
    {
        public static EntityTypeBuilder<TEntity> ConfigureCopositeSide<TEntity, TRelated, DataType>(
                        this EntityTypeBuilder<TEntity> EntityTypeBuilder,
                        Expression<Func<TEntity, object>> ConpositeSideID,
            Expression<Func<TEntity, TRelated>> ConpositeSideProperty)
                        where TEntity : class where TRelated : CompornentClass<DataType> where DataType : struct
        {
            EntityTypeBuilder.Navigation(ConpositeSideProperty);
            EntityTypeBuilder.HasOne(ConpositeSideProperty)
                .WithOne()
                .HasForeignKey(ConpositeSideID);
                
            return EntityTypeBuilder;
        }
        public static EntityTypeBuilder<TRelated> ConfigureCompornentSide<TEntity, TRelated, DataType>(
            this EntityTypeBuilder<TRelated> EntityTypeBuilder,
            Expression<Func<TEntity, object>> ConpositeSideID,
            Expression<Func<TEntity, TRelated>> ConpositeSideProperty)
            where TEntity : class where TRelated : CompornentClass<DataType> where DataType : struct
        {
            EntityTypeBuilder.ToTable(typeof(TEntity).ToString() + '_' + ConpositeSideProperty.Type.ToString() + "_Values");
            EntityTypeBuilder.HasKey(d => d.iD);
            EntityTypeBuilder.Property(d => d.value).IsRequired();
            EntityTypeBuilder.HasOne<TEntity>().WithOne().HasForeignKey(ConpositeSideID);
            return EntityTypeBuilder;
        }
    }
}
