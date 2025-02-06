namespace Interpreter.Ex
{
    public class SelectExpression : Expression
    {
        private List<string> fields;
        private Expression condition;

        public SelectExpression(List<string> fields, Expression condition)
        {
            this.fields = fields;
            this.condition = condition;
        }

        public  void Interpret(Dictionary<string, List<Dictionary<string, object>>> data)
        {
            Console.WriteLine($"SELECT: {string.Join(", ", fields)}");
            condition.Interpret(data); // Apply condition on data
        }
    }
}
