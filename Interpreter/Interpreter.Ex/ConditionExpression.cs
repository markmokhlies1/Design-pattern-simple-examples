namespace Interpreter.Ex
{
    public class ConditionExpression : Expression
    {
        private string field;
        private string operatorSymbol;
        private object value;

        public ConditionExpression(string field, string operatorSymbol, object value)
        {
            this.field = field;
            this.operatorSymbol = operatorSymbol;
            this.value = value;
        }

        public void Interpret(Dictionary<string, List<Dictionary<string, object>>> data)
        {
            var tableName = "people"; // Assume we're querying the "people" table
            var filteredData = data[tableName].Where(row =>
            {
                var fieldValue = row[field];

                return operatorSymbol switch
                {
                    ">" => (int)fieldValue > (int)value,
                    "=" => fieldValue.Equals(value),
                    "<" => (int)fieldValue < (int)value,
                    _ => false
                };
            }).ToList();

            Console.WriteLine($"Filtered data from '{tableName}' where {field} {operatorSymbol} {value}:");
            foreach (var row in filteredData)
            {
                Console.WriteLine($"- {string.Join(", ", row.Select(kv => $"{kv.Key}: {kv.Value}"))}");
            }
        }
    }
}
