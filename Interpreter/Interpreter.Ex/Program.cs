namespace Interpreter.Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new DatabaseContext();

            // Query: SELECT name FROM people WHERE age > 30
            var condition = new ConditionExpression("age", ">", 30);
            var select = new SelectExpression(new List<string> { "name" }, condition);
            select.Interpret(context.Data); // Execute query

            Console.WriteLine();

            // Query: SELECT name FROM users WHERE status = 'active'
            var condition2 = new ConditionExpression("status", "=", "active");
            var select2 = new SelectExpression(new List<string> { "name" }, condition2);
            select2.Interpret(context.Data); // Execute query



            Console.ReadKey();
        }
    }
}
