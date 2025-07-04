namespace Factory.Infrastructure
{
    public interface IEntityComponentRegistrar
    {
        void RegisterComponents();
        void UnregisterComponents();
    }
}