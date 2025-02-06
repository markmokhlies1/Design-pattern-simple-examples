namespace Interpreter.Ex
{
    public class DatabaseContext
    {
        public Dictionary<string, List<Dictionary<string, object>>> Data { get; private set; }

        public DatabaseContext()
        {
            Data = new Dictionary<string, List<Dictionary<string, object>>>
        {
            { "people", new List<Dictionary<string, object>> {
                new Dictionary<string, object>{{ "name", "John" }, { "age", 28 }},
                new Dictionary<string, object>{{ "name", "Jane" }, { "age", 35 }},
                new Dictionary<string, object>{{ "name", "Alice" }, { "age", 40 }},
                new Dictionary<string, object>{{ "name", "Bob" }, { "age", 50 }}
            }},
            { "users", new List<Dictionary<string, object>> {
                new Dictionary<string, object>{{ "name", "Mike" }, { "status", "active" }},
                new Dictionary<string, object>{{ "name", "Lucy" }, { "status", "inactive" }},
                new Dictionary<string, object>{{ "name", "Eve" }, { "status", "active" }}
            }}
        };
        }
    }
}
