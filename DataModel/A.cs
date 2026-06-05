namespace DataModel
{
    public abstract class A
    {
        public int Id { get; set; }

        public static int nextId = 1;

        public virtual int X { get; set; }

        public A()
        {
            Id = nextId++;
        }

    }
}
