namespace Gladiators.Gameplay.Gladiator;

public interface IGladiatorFactory
{
    GameEntity Create(GladiatorTypeId gladiatorTypeId, Vector3 at);
}