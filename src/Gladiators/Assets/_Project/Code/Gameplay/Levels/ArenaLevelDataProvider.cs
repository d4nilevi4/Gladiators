namespace Gladiators.Gameplay.Levels;

public class ArenaLevelDataProvider : IArenaLevelDataProvider
{
    public Vector3 PlayerSpawnPosition { get; private set; }
    
    public void SetPlayerSpawnPosition(Vector3 playerSpawnPosition)
    {
        PlayerSpawnPosition = playerSpawnPosition;
    }
}