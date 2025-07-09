using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Figuras_3D
{
    internal class CFigurem
    {
        private float mSize = 3.0f;
        private int mSides = 3;
        private const float SF = 10;
        private float mPosX = 0f;
        private float mPosY = 0f;
        private float mAngleX = 0f;
        private float mAngleY = 0f;
        private float mAngleZ = 0f;

        public float GetPosX()
        {
            return this.mPosX;

        }
        public void SetPosX(float mPosx) {
            this.mPosX = mPosx;


        }
        public float GetPosY() {
            return this.mPosY;

        }
        public void SetPosY(float mPosY)
        {
            this.mPosY = mPosY;

        }
        public void SetSide(float newSide)
        {
            mSides = (int)newSide;
        }
        public void SetSize(float newSize)
        {
            mSize = newSize;  // Almacena el tamaño como un número flotante
        }

        public void PlotShape(PictureBox canvas)
        {
            if (mSides < 3) return;
            canvas.Refresh();

            float centerX = canvas.Width / 2f + mPosX;
            float centerY = canvas.Height / 2f + mPosY;
            float scale = mSize;

            var (vertices, faces) = CreatePrism(mSides, mSize, mSize); // base, radio, altura

            PointF[] projected = new PointF[vertices.Count];
            for (int i = 0; i < vertices.Count; i++)
            {
                Vector3D v = vertices[i] * scale;
                v.Rotate(mAngleX, mAngleY, mAngleZ);
                projected[i] = v.Project(centerX, centerY);
            }

            using (Graphics g = canvas.CreateGraphics())
            using (Pen pen = new Pen(Color.SteelBlue, 2))
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(100, Color.LightSkyBlue)))
            {
                foreach (var face in faces)
                {
                    PointF[] poly = face.Select(idx => projected[idx]).ToArray();
                    g.FillPolygon(brush, poly);
                    g.DrawPolygon(pen, poly);
                }
            }
        }


        public void DrawPolygon3D(PictureBox canvas, int nSides, float radius, string plane = "XY")
        {
            float centerX = canvas.Width / 2f + mPosX;
            float centerY = canvas.Height / 2f + mPosY;
            float scale = radius * SF;

            List<Vector3D> vertices = Polygon3D(new Vector3D(0, 0, 0), nSides, radius, plane);

            PointF[] projected = new PointF[vertices.Count];
            for (int i = 0; i < vertices.Count; i++)
            {
                Vector3D v = vertices[i] * scale;
                v.Rotate(mAngleX, mAngleY, mAngleZ);
                projected[i] = v.Project(centerX, centerY);
            }

            using (Graphics g = canvas.CreateGraphics())
            using (Pen pen = new Pen(Color.DeepSkyBlue, 2))
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(100, Color.CornflowerBlue)))
            {
                g.FillPolygon(brush, projected);
                g.DrawPolygon(pen, projected);
            }
        }

        public List<Vector3D> Polygon3D(Vector3D center, int nSides, float radius, string plane = "XY")
        {
            List<Vector3D> points = new List<Vector3D>();
            float angleStep = 2 * (float)Math.PI / nSides;

            for (int i = 0; i < nSides; i++)
            {
                float angle = i * angleStep;
                float x = 0, y = 0, z = 0;

                switch (plane.ToUpper())
                {
                    case "XY":
                        x = center.X + radius * (float)Math.Cos(angle);
                        y = center.Y + radius * (float)Math.Sin(angle);
                        z = center.Z;
                        break;
                    case "XZ":
                        x = center.X + radius * (float)Math.Cos(angle);
                        y = center.Y;
                        z = center.Z + radius * (float)Math.Sin(angle);
                        break;
                    case "YZ":
                        x = center.X;
                        y = center.Y + radius * (float)Math.Cos(angle);
                        z = center.Z + radius * (float)Math.Sin(angle);
                        break;
                }

                points.Add(new Vector3D(x, y, z));
            }

            return points;
        }

        public void RotateX(float angleDelta, PictureBox picCanvas)
        {
            mAngleX += angleDelta;
            PlotShape(picCanvas);
        }

        public void RotateY(float angleDelta, PictureBox picCanvas)
        {
            mAngleY += angleDelta;
            PlotShape(picCanvas);
        }

        public void RotateZ(float angleDelta, PictureBox picCanvas)
        {
            mAngleZ += angleDelta;
            PlotShape(picCanvas);
        }

       
        public void Move(float dx, float dy, PictureBox picCanvas)
        {
            mPosX += dx;
            mPosY += dy;
            PlotShape(picCanvas);
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
        public (List<Vector3D> vertices, List<int[]> faces) CreatePrism(int nSides, float radius, float height)
        {
            var basePolygon = Polygon3D(new Vector3D(0, 0, -height / 2), nSides, radius, "XY");
            var topPolygon = Polygon3D(new Vector3D(0, 0, height / 2), nSides, radius, "XY");

            List<Vector3D> vertices = new List<Vector3D>();
            vertices.AddRange(basePolygon);
            vertices.AddRange(topPolygon);

            List<int[]> faces = new List<int[]>();

            // Caras laterales
            for (int i = 0; i < nSides; i++)
            {
                int next = (i + 1) % nSides;
                faces.Add(new int[] { i, next, next + nSides, i + nSides });
            }

            // Cara inferior
            faces.Add(Enumerable.Range(0, nSides).ToArray());

            // Cara superior (reversa para que se vea correctamente)
            faces.Add(Enumerable.Range(nSides, nSides).Reverse().ToArray());

            return (vertices, faces);
        }

    }
}
