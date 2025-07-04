using System;
using UnityEngine;
using Zenject;

namespace Gladiators.Gameplay.Input
{
    public class InputProvider : IInputProvider , IInitializable, IDisposable
    {
        private readonly PlayerInputActions _input = new();

        public bool HasMovementInput => GetMovementInputAxis().sqrMagnitude >= 0.01f;
        
        public void Initialize() =>
            _input.Enable();

        public void Dispose() =>
            _input.Dispose();

        public Vector2 GetMovementInputAxis() => 
            _input.Locomotion.Movement.ReadValue<Vector2>();
    }
}