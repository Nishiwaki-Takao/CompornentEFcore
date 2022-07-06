namespace CompornentEFcore
{
    public abstract class CompornentClass<DataType> where DataType : struct
    {
        public CompornentClass() { value = default(DataType); }
        public int iD { get; set; }
        public DataType value { get; set; }
    }
}
