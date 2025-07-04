using UnityEngine;

namespace Gladiators.Gameplay.Input
{
    public interface IInputProvider
    {
        bool HasMovementInput { get; }
        Vector2 GetMovementInputAxis();
    }
}