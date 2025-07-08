using System;
using System.Drawing;

namespace Figuras_3D
{
    public struct Vector3D
    {
        public float X, Y, Z;

        public Vector3D(float x, float y, float z)
        {
            X = x; Y = y; Z = z;
        }

        public void Rotate(float angleX, float angleY, float angleZ)
        {
            RotateX(angleX);
            RotateY(angleY);
            RotateZ(angleZ);
        }

        public void RotateX(float angle)
        {
            float cos = (float)Math.Cos(angle);
            float sin = (float)Math.Sin(angle);
            float y = Y * cos - Z * sin;
            float z = Y * sin + Z * cos;
            Y = y; Z = z;
        }

        public void RotateY(float angle)
        {
            float cos = (float)Math.Cos(angle);
            float sin = (float)Math.Sin(angle);
            float x = X * cos + Z * sin;
            float z = -X * sin + Z * cos;
            X = x; Z = z;
        }

        public void RotateZ(float angle)
        {
            float cos = (float)Math.Cos(angle);
            float sin = (float)Math.Sin(angle);
            float x = X * cos - Y * sin;
            float y = X * sin + Y * cos;
            X = x; Y = y;
        }

        public PointF Project(float centerX, float centerY)
        {
            return new PointF(centerX + X, centerY - Y);
        }

        public static Vector3D operator *(Vector3D v, float scale) =>
            new Vector3D(v.X * scale, v.Y * scale, v.Z * scale);
    }
}
