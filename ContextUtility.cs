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
            Expression<Func<TEntity, CompornentClass<TRelated, TEntity, DataType>>> ConpositeSideProperty
            )
                        where TEntity : class where TRelated : CompornentClass<TRelated,TEntity, DataType> where DataType : struct
        {
            EntityTypeBuilder.Navigation(ConpositeSideProperty);
            EntityTypeBuilder.HasOne(ConpositeSideProperty)
                .WithOne(CompornentClass => CompornentClass.CompornentSideNavigation);
            return EntityTypeBuilder;
        }
        public static void ConfigureCompornentSide<TEntity, DataType, TRelated>(
            this EntityTypeBuilder<CompornentClass<TRelated, TEntity, DataType>> EntityTypeBuilder,
            Expression<Func<TEntity, TRelated>> ConpositeSideProperty,
            Expression<Func<TEntity, object>> ConpositeSideID)
            where TEntity : class where TRelated : CompornentClass<TRelated,TEntity, DataType> where DataType : struct
        {
            EntityTypeBuilder.ToTable(typeof(TEntity).ToString() + '_' + ConpositeSideProperty.Type.ToString() + "_Values");
            EntityTypeBuilder.HasKey(d => d.iD);
            EntityTypeBuilder.Property(d => d.value).IsRequired();
            EntityTypeBuilder.Navigation(d => d.CompornentSideNavigation);
            EntityTypeBuilder.HasOne(d => d.CompornentSideNavigation)
                .WithOne(ConpositeSideProperty.ToString())
                .HasForeignKey(ConpositeSideID);
        }
    }
}
