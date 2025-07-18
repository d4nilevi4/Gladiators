﻿namespace Gladiators.Gameplay.Movement;

[Game] public class MovementAvailable : IComponent { }
[Game] public class RigidbodyMovable : IComponent { }
[Game] public class Moving : IComponent { }
[Game] public class MovementSpeed : IComponent { public float Value; }
[Game] public class MovementDirection : IComponent { public Vector3 Value; }
