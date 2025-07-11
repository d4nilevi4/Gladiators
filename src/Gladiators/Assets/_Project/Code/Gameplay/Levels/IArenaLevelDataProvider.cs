namespace Gladiators.Gameplay.Levels;

public interface IArenaLevelDataProvider
{
    Vector3 PlayerSpawnPosition { get; }
    void SetPlayerSpawnPosition(Vector3 playerSpawnPosition);
}