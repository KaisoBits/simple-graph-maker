﻿using System;
using SFML.System;

namespace Graph.MathUtils
{
    public static class SpaceMath
    {
        public static float DistanceBetween(Vector2f start, Vector2f end)
        {
            float XlengthSquared = (float)Math.Pow(Math.Abs(end.X - start.X), 2);
            float YlengthSquared = (float)Math.Pow(Math.Abs(end.Y - start.Y), 2);

            float result = (float)Math.Sqrt(XlengthSquared + YlengthSquared);

            return result;
        }

        public static float AngleBetween(Vector2f start, Vector2f end) =>
            (float)(Math.Atan2(end.Y, end.X) - Math.Atan2(start.Y, start.X)) * Transformation.RAD_TO_DEG;
    }
}
