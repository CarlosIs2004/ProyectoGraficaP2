using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_3D
{
    public partial class IrregularFigureForm : Form
    {
         private CFigurem figura = new CFigurem();
         int? newX = null;
         int? newY = null;
         const float radioSeleccion = 18f;

        public IrregularFigureForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += frmSquare_KeyDown;
            picCanvas.MouseDown += picCanvas_MouseDown;
            picCanvas.MouseMove += picCanvas_MouseMove;
            picCanvas.MouseUp += picCanvas_MouseUp;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            
            figura.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
             picCanvas.Refresh();
        }

  
        private void frmSquare_KeyDown(object sender, KeyEventArgs e)
        {
            float step = 10f;
            if (e.KeyCode == Keys.Left)
                figura.Move(-step, 0, picCanvas);
            else if (e.KeyCode == Keys.Right)
                figura.Move(step, 0, picCanvas);
            else if (e.KeyCode == Keys.Up)
                figura.Move(0, -step, picCanvas);
            else if (e.KeyCode == Keys.Down)
                figura.Move(0, step, picCanvas);
        }

        private void scaleBar_Scroll(object sender, EventArgs e)
        {
            float newSize = scaleBar.Value;
            figura.SetSize(newSize);
            figura.PlotShape(picCanvas);
        }

        private void btnRotateXPos_Click(object sender, EventArgs e)
        {
            // Rotar en X positivo
            figura.RotateX(5 * (float)Math.PI / 180f, picCanvas);
        }

        private void btnRotateXNeg_Click(object sender, EventArgs e)
        {
            // Rotar en X negativo
            figura.RotateX(-5 * (float)Math.PI / 180f, picCanvas);
        }

        private void btnRotateYPos_Click(object sender, EventArgs e)
        {
            // Rotar en Y positivo
            figura.RotateY(5 * (float)Math.PI / 180f, picCanvas);
        }

        private void btnRotateYNeg_Click(object sender, EventArgs e)
        {
            // Rotar en Y negativo
            figura.RotateY(-5 * (float)Math.PI / 180f, picCanvas);
        }

        private void btnRotateZPos_Click(object sender, EventArgs e)
        {
            // Rotar en Z positivo (igual que btnRotateRight)
            figura.RotateZ(5 * (float)Math.PI / 180f, picCanvas);
        }

        private void btnRotateZNeg_Click(object sender, EventArgs e)
        {
            // Rotar en Z negativo (igual que btnRotateLeft)
            figura.RotateZ(-5 * (float)Math.PI / 180f, picCanvas);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            figura.SetSide(5);
            figura.PlotShape(picCanvas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            figura.SetSide(7);
            figura.PlotShape(picCanvas);
        }



        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            
                float dx = figura.GetPosX() - (e.X - picCanvas.Width / 2f);
                float dy = figura.GetPosY()- (e.Y - picCanvas.Height / 2f);
                if (dx * dx + dy * dy <= radioSeleccion * radioSeleccion)
                {
                newX = e.X;
                newY = e.Y;


                }
            
        }


        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            newX = null;

            newY = null;
        }


        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (newX.HasValue && newY.HasValue  && e.Button == MouseButtons.Left)
            {
                figura.SetPosX( ((float)newX) -(picCanvas.Width / 2f));
                figura.SetPosY(((float)newY) - (picCanvas.Height / 2f));
                figura.PlotShape(picCanvas);
            }
        }

     
    }
}

