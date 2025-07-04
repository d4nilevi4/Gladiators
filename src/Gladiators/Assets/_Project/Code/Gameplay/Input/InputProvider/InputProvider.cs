using System;
using UnityEngine;
using Zenject;

namespace Gladiators.Gameplay.Input
{
    public class InputProvider : IInputProvider , IInitializable, IDisposable
    {
        private readonly PlayerInputActions _input = new();

        public bool HasAxisInput => GetInputAxis().magnitude >= 0.1f;
        
        public void Initialize() =>
            _input.Enable();

        public void Dispose() =>
            _input.Dispose();

        public Vector2 GetInputAxis() => 
            _input.Movement.InputAxis.ReadValue<Vector2>();
    }
}