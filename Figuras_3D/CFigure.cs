using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_3D
{
    internal class CFigure
    {
        private float mSize = 8.0f; // Medida de cada lado del polígono
        private int mSides = 3; // Valor mínimo para un polígono válido
        private Graphics mGraph;
        private const float SF = 10;
        private float mPosX = 0f;
        private float mPosY = 0f;

        // Ángulos de rotación en radianes
        private float mAngleX = 0f;
        private float mAngleY = 0f;
        private float mAngleZ = 0f;


        // Proyección ortográfica de un punto 3D a 2D (sin perspectiva, sin distorsión ni saltos)
        private PointF Project3DTo2D(float x, float y, float z, float centerX, float centerY)
        {
            float px = centerX + x;
            float py = centerY - y;
            return new PointF(px, py);
        }

        // Aplica rotación 3D a un punto
        private void Rotate3D(ref float x, ref float y, ref float z)
        {
            // Rotación en X
            float cosX = (float)Math.Cos(mAngleX);
            float sinX = (float)Math.Sin(mAngleX);
            float y1 = y * cosX - z * sinX;
            float z1 = y * sinX + z * cosX;

            y = y1;
            z = z1;

            // Rotación en Y
            float cosY = (float)Math.Cos(mAngleY);
            float sinY = (float)Math.Sin(mAngleY);
            float x1 = x * cosY + z * sinY;
            float z2 = -x * sinY + z * cosY;

            x = x1;
            z = z2;

            // Rotación en Z
            float cosZ = (float)Math.Cos(mAngleZ);
            float sinZ = (float)Math.Sin(mAngleZ);
            float x2 = x * cosZ - y * sinZ;
            float y2 = x * sinZ + y * cosZ;

            x = x2;
            y = y2;
        }

        public void PlotShape(PictureBox picCanvas)
        {
            if (mSides < 3) return;

            picCanvas.Refresh();

            float centerX = picCanvas.Width / 2f + mPosX;
            float centerY = picCanvas.Height / 2f + mPosY;

            // Definir vértices y caras según el número de lados
            List<float[]> vertices = new List<float[]>();
            List<int[]> faces = new List<int[]>();

            float scale = mSize * SF;

            switch (mSides)
            {
                case 3: // Tetraedro
                    vertices.AddRange(new[]
                    {
                        new float[] { 1, 1, 1 },
                        new float[] { -1, -1, 1 },
                        new float[] { -1, 1, -1 },
                        new float[] { 1, -1, -1 }
                    });
                    faces.AddRange(new[]
                    {
                        new int[] { 0, 1, 2 },
                        new int[] { 0, 3, 1 },
                        new int[] { 0, 2, 3 },
                        new int[] { 1, 3, 2 }
                    });
                    break;
                case 4: // Cubo
                    vertices.AddRange(new[]
                    {
                        new float[] { -1, -1, -1 },
                        new float[] { 1, -1, -1 },
                        new float[] { 1, 1, -1 },
                        new float[] { -1, 1, -1 },
                        new float[] { -1, -1, 1 },
                        new float[] { 1, -1, 1 },
                        new float[] { 1, 1, 1 },
                        new float[] { -1, 1, 1 }
                    });
                    faces.AddRange(new[]
                    {
                        new int[] { 0, 1, 2, 3 },
                        new int[] { 4, 5, 6, 7 },
                        new int[] { 0, 1, 5, 4 },
                        new int[] { 2, 3, 7, 6 },
                        new int[] { 1, 2, 6, 5 },
                        new int[] { 0, 3, 7, 4 }
                    });
                    break;
                case 6: // Icosaedro
                    {
                        float phi = (1f + (float)Math.Sqrt(5)) / 2f;
                        vertices.AddRange(new[]
                        {
                            new float[] { -1,  phi, 0 }, new float[] { 1,  phi, 0 }, new float[] { -1, -phi, 0 }, new float[] { 1, -phi, 0 },
                            new float[] { 0, -1,  phi }, new float[] { 0, 1,  phi }, new float[] { 0, -1, -phi }, new float[] { 0, 1, -phi },
                            new float[] {  phi, 0, -1 }, new float[] {  phi, 0, 1 }, new float[] { -phi, 0, -1 }, new float[] { -phi, 0, 1 }
                        });
                        faces.AddRange(new[]
                        {
                            new int[] { 0, 11, 5 }, new int[] { 0, 5, 1 }, new int[] { 0, 1, 7 }, new int[] { 0, 7, 10 }, new int[] { 0, 10, 11 },
                            new int[] { 1, 5, 9 }, new int[] { 5, 11, 4 }, new int[] { 11, 10, 2 }, new int[] { 10, 7, 6 }, new int[] { 7, 1, 8 },
                            new int[] { 3, 9, 4 }, new int[] { 3, 4, 2 }, new int[] { 3, 2, 6 }, new int[] { 3, 6, 8 }, new int[] { 3, 8, 9 },
                            new int[] { 4, 9, 5 }, new int[] { 2, 4, 11 }, new int[] { 6, 2, 10 }, new int[] { 8, 6, 7 }, new int[] { 9, 8, 1 }
                        });
                    }
                    break;
                default:
                    MessageBox.Show("Solo se soportan poliedros regulares con 3 (tetraedro), 4 (cubo) o 6 (icosaedro) caras.", "No soportado");
                    return;
            }

            // Aplica rotación y proyección a los vértices
            PointF[] projected = new PointF[vertices.Count];
            for (int i = 0; i < vertices.Count; i++)
            {
                float x = vertices[i][0] * scale;
                float y = vertices[i][1] * scale;
                float z = vertices[i][2] * scale;
                Rotate3D(ref x, ref y, ref z);
                projected[i] = Project3DTo2D(x, y, z, centerX, centerY);
            }

            mGraph = picCanvas.CreateGraphics();

            // Colores claros
            Color[] faceColors = new Color[]
            {
                Color.FromArgb(180, 200, 220, 255), // azul claro
                Color.FromArgb(180, 255, 255, 200), // amarillo claro
                Color.FromArgb(180, 200, 255, 200), // verde claro
                Color.FromArgb(180, 255, 200, 255), // rosa claro
                Color.FromArgb(180, 255, 220, 200), // naranja claro
                Color.FromArgb(180, 220, 255, 255)  // celeste claro
            };

            using (Pen pen = new Pen(Color.SkyBlue, 2))
            {
                for (int f = 0; f < faces.Count; f++)
                {
                    var face = faces[f];
                    PointF[] poly = face.Select(idx => projected[idx]).ToArray();
                    using (SolidBrush brush = new SolidBrush(faceColors[f % faceColors.Length]))
                    {
                        mGraph.FillPolygon(brush, poly);
                        mGraph.DrawPolygon(pen, poly);
                    }
                }
            }
        }

        // Métodos para rotar en cada eje
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

        public void SetSide(float newSide)
        {
            mSides = (int)newSide;
        }
        public void SetSize(float newSize)
        {
            mSize = (int)newSize;
        }

        public void Move(float dx, float dy, PictureBox picCanvas)
        {
            mPosX += dx;
            mPosY += dy;
            PlotShape(picCanvas);
        }

        


    }
}
