namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pool = new ObjectPool();

            // Borrow objects from the pool
            var obj1 = pool.GetObject();
            var obj2 = pool.GetObject();

            // Return objects to the pool
            pool.ReturnObject(obj1);
            pool.ReturnObject(obj2);

            // Reuse objects from the pool
            var obj3 = pool.GetObject(); // Will reuse obj1
        }
    }
}
