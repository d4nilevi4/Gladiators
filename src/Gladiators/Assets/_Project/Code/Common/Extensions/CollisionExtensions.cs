using System;

namespace Gladiators.Common
{
    [Flags]
    public enum CollisionLayer
    {
        Ground = 1 << 6,
        // Enemy = 1 << 9,
        // Hero = 1 << 10,
    }
    
    public static class CollisionExtensions
    {
        public static int AsMask(this CollisionLayer layer) =>
            (int)layer;
    }
}