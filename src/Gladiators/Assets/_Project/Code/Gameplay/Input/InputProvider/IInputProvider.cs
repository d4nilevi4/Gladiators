using UnityEngine;

namespace Factory.Gameplay.Input
{
    public interface IInputProvider
    {
        bool HasAxisInput { get; }
        Vector2 GetInputAxis();
    }
}