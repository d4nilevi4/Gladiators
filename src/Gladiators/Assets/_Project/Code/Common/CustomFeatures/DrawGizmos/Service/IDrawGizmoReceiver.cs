using System;

namespace Factory.Common
{
    public interface IDrawGizmoReceiver
    {
        event Action EventDrawGizmo;
    }
}