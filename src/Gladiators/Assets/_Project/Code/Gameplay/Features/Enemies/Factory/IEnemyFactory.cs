namespace Gladiators.Gameplay.Enemies;

public interface IEnemyFactory
{
    GameEntity Create(EnemyTypeId enemyTypeId, Vector3 at);
}