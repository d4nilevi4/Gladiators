using Entitas;

namespace Gladiators.Common.Entity
{
    public interface INamedEntity : IEntity
    {
        string EntityName(IComponent[] components);
        string BaseToString();
    }
}