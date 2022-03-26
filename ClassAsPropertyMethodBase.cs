namespace CompornentEFcore
{
    public static class ClassAsPropertyMethodBase
    {

        public static DataType? Getmethod<TEntity, DataType>(this CompornentClass<TEntity, DataType> TargetPoperty) where TEntity : class where DataType : struct
        {
            return TargetPoperty?.value;
        }

        public static void Setmethod<TEntity, DataType, CompornentClass>(this CompornentClass<TEntity, DataType> TargetProperty, DataType value)
            where TEntity : class
            where DataType : struct
            where CompornentClass : CompornentClass<TEntity, DataType>, new()
        {
            if (TargetProperty is null)
            { TargetProperty = new CompornentClass(); }
            TargetProperty.value = value;
        }
    }
}
