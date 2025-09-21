namespace OOP.Understanding.Topics;

// Topic 08: Constructors & Destructors (Finalizers)
// Definition: Constructors initialize objects; destructors (finalizers) run during GC for cleanup (rarely needed in C#).
public static class CtorsDestructors
{
    public static void Run()
    {
        using var r = new ResourceUser("demo");
        r.DoWork();
        Console.WriteLine("Disposed will be called automatically due to 'using'.");
        // Exercise: Remove using and call Dispose manually.
    }

    public class ResourceUser : IDisposable
    {
        private readonly string _name;
        private bool _disposed;
        public ResourceUser(string name)
        {
            _name = name;
            Console.WriteLine($"ResourceUser({_name}) constructed");
        }

        public void DoWork()
        {
            if (_disposed) throw new ObjectDisposedException(nameof(ResourceUser));
            Console.WriteLine($"ResourceUser({_name}) working...");
        }

        public void Dispose()
        {
            if (_disposed) return;
            _disposed = true;
            Console.WriteLine($"ResourceUser({_name}) disposed");
            GC.SuppressFinalize(this);
        }

        ~ResourceUser()
        {
            // finalizer as safety net (generally avoid heavy work here)
            if (!_disposed)
            {
                Console.WriteLine($"ResourceUser({_name}) finalized");
            }
        }
    }
}
