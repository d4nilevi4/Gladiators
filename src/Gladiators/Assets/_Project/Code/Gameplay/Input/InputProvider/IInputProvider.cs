using UnityEngine;

namespace Gladiators.Gameplay.Input
{
    public interface IInputProvider
    {
        bool HasAxisInput { get; }
        Vector2 GetInputAxis();
    }
}