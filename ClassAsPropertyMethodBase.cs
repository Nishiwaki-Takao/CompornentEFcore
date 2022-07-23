namespace CompornentEFcore
{
    public static class ClassAsPropertyMethodBase
    {

        public static DataType? Getmethod<TSelf,TEntity, DataType>(this CompornentClass<TSelf, TEntity, DataType> TargetPoperty) where TSelf : CompornentClass<TSelf, TEntity, DataType> where TEntity : class where DataType : struct
        {
            return TargetPoperty?.value;
        }

        public static void Setmethod<TEntity, DataType, CompornentClass>(this CompornentClass<CompornentClass, TEntity, DataType> TargetProperty, DataType value)
            where TEntity : class
            where DataType : struct
            where CompornentClass : CompornentClass<CompornentClass, TEntity, DataType>, new()
        {
            if (TargetProperty is null)
            { TargetProperty = new CompornentClass(); }
            TargetProperty.value = value;
        }
    }
}
