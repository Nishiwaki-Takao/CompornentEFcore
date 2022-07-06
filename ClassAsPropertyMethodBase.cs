namespace CompornentEFcore
{
    public static class ClassAsPropertyMethodBase
    {

        public static DataType? Getmethod<DataType>(this CompornentClass<DataType> TargetPoperty) where DataType : struct
        {
            return TargetPoperty?.value;
        }

        public static void Setmethod<DataType, CompornentClass>(this CompornentClass TargetProperty, DataType value)
            where DataType : struct
            where CompornentClass : CompornentClass<DataType>, new()
        {
            if (TargetProperty is null)
            { TargetProperty = new CompornentClass(); }
            TargetProperty.value = value;
        }
    }
}
