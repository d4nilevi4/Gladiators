﻿namespace Gladiators.Gameplay.Input;

[Input] public class Input : IComponent { }
[Input] public class WorldInput : IComponent { }
[Input] public class CameraRelativeInput : IComponent { }
[Input] public class InteractionInputComponent : IComponent { }
[Input] public class InputAxis : IComponent { public Vector2 Value; }
[Input] public class MouseScreenPosition : IComponent { public Vector2 Value; }
[Input] public class InteractedColliderId : IComponent { public int Value; }