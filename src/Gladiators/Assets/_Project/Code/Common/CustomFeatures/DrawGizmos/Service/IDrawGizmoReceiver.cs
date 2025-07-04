using System;

namespace Gladiators.Common
{
    public interface IDrawGizmoReceiver
    {
        event Action EventDrawGizmo;
    }
}