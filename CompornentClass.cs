namespace CompornentEFcore
{
    public abstract class CompornentClass<TEntity, DataType> where TEntity : class where DataType : struct
    {
        public CompornentClass() { value = default(DataType); }
        public CompornentClass(DataType value) { this.value = value; }
        public int iD { get; set; }
        public DataType value { get; set; }
        public TEntity CompornentSideNavigation { get; set; }
    }
}
