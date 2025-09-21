namespace OOP.Understanding.Topics;

// Topic 13: Generics in OOP
// Definition: Generics let you write reusable types and methods with type parameters.
public static class GenericsOop
{
    public static void Run()
    {
        var repo = new Repository<Customer>();
        repo.Add(new Customer(1, "Ava"));
        Console.WriteLine(repo.FindById(1)?.Name);
        // Exercise: Create Repository<Order> and practice with constraints.
    }

    public interface IEntity
    {
        int Id { get; }
    }

    public class Repository<T> where T : class, IEntity
    {
        private readonly Dictionary<int, T> _store = new();
        public void Add(T entity) => _store[entity.Id] = entity;
        public T? FindById(int id) => _store.TryGetValue(id, out var value) ? value : null;
        public IEnumerable<T> All() => _store.Values;
    }

    public class Customer : IEntity
    {
        public int Id { get; }
        public string Name { get; }
        public Customer(int id, string name) { Id = id; Name = name; }
    }
}
