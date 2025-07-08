using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Figuras_3D
{
    public partial class Frm3D : Form
    {
        private CFigure figura = new CFigure();

        public Frm3D()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += frmSquare_KeyDown;
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

        
     

        private void tetraedrotxt_Click(object sender, EventArgs e)
        {
            float newSide = 3;
            figura.SetSide(newSide);
            figura.PlotShape(picCanvas);
        }

        private void cubotxt_Click(object sender, EventArgs e)
        {
            float newSide = 4;
            figura.SetSide(newSide);
            figura.PlotShape(picCanvas);
        }

        private void icosaedrotxt_Click(object sender, EventArgs e)
        {
            float newSide = 6;
            figura.SetSide(newSide);
            figura.PlotShape(picCanvas);
        }
    }
}
