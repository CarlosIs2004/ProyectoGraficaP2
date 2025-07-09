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

        // Paneles de diseño moderno
        private Panel controlPanel;
        private Panel canvasPanel;
        private GroupBox figuresGroupBox;
        private GroupBox rotationGroupBox;
        private GroupBox toolsGroupBox;

        // Botones estilizados
        private Button btnFigure1Modern;
        private Button btnFigure2Modern;
        private Button btnRotateXPosModern;
        private Button btnRotateXNegModern;
        private Button btnRotateYPosModern;
        private Button btnRotateYNegModern;
        private Button btnRotateZPosModern;
        private Button btnRotateZNegModern;
        private Button btnResetModern;

        // Controles de escala
        private Label lblScale;
        private TrackBar scaleBarModern;
        private Label lblScaleValue;

        // Información de ayuda
        private Label lblHelp;
        private Panel helpPanel;

        public IrregularFigureForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += frmSquare_KeyDown;
            picCanvas.MouseDown += picCanvas_MouseDown;
            picCanvas.MouseMove += picCanvas_MouseMove;
            picCanvas.MouseUp += picCanvas_MouseUp;
            InitializeModernDesign();
        }

        private void InitializeModernDesign()
        {
            // Configuración general del formulario
            this.BackColor = Color.White;
            this.Padding = new Padding(20);

            // Panel principal de controles (lateral derecho)
            controlPanel = new Panel();
            controlPanel.BackColor = Color.FromArgb(248, 249, 250);
            controlPanel.Dock = DockStyle.Right;
            controlPanel.Width = 300;
            controlPanel.BorderStyle = BorderStyle.FixedSingle;
            controlPanel.Padding = new Padding(20);

            // Panel del canvas (área principal)
            canvasPanel = new Panel();
            canvasPanel.BackColor = Color.White;
            canvasPanel.Dock = DockStyle.Fill;
            canvasPanel.Padding = new Padding(0);

            // Configurar el PictureBox existente
            if (picCanvas != null)
            {
                picCanvas.BackColor = Color.FromArgb(250, 252, 255);
                picCanvas.BorderStyle = BorderStyle.FixedSingle;
                picCanvas.Dock = DockStyle.Fill;
                canvasPanel.Controls.Add(picCanvas);
                CenterPicCanvas();
            }

            // Panel de ayuda (superior)
            helpPanel = new Panel();
            helpPanel.BackColor = Color.FromArgb(52, 152, 219);
            helpPanel.Dock = DockStyle.Top;
            helpPanel.Height = 60;
            helpPanel.Padding = new Padding(20, 15, 20, 15);

            lblHelp = new Label();
            lblHelp.Text = "💡 Usa las flechas del teclado para mover la figura | Selecciona una figura y utiliza los controles de rotación";
            lblHelp.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblHelp.ForeColor = Color.White;
            lblHelp.Dock = DockStyle.Fill;
            lblHelp.TextAlign = ContentAlignment.MiddleLeft;
            helpPanel.Controls.Add(lblHelp);

            // Grupo de Figuras
            figuresGroupBox = CreateModernGroupBox("🔷 Poliedros Irregulares");
            figuresGroupBox.Location = new Point(0, 10);
            figuresGroupBox.Size = new Size(260, 120);

            btnFigure1Modern = CreateModernButton("🔷 Prisma Pentagonal", Color.FromArgb(231, 76, 60));
            btnFigure1Modern.Location = new Point(20, 30);
            btnFigure1Modern.Click += BtnFigure1Modern_Click;

            btnFigure2Modern = CreateModernButton("🔷 Prisma Heptagonal", Color.FromArgb(46, 204, 113));
            btnFigure2Modern.Location = new Point(20, 70);
            btnFigure2Modern.Click += BtnFigure2Modern_Click;

            figuresGroupBox.Controls.Add(btnFigure1Modern);
            figuresGroupBox.Controls.Add(btnFigure2Modern);

            // Grupo de Rotación
            rotationGroupBox = CreateModernGroupBox("🔄 Controles de Rotación");
            rotationGroupBox.Location = new Point(0, 130);
            rotationGroupBox.Size = new Size(260, 200);

            // Rotación X
            Label lblRotX = CreateLabel("Eje X:");
            lblRotX.Location = new Point(20, 30);
            btnRotateXPosModern = CreateSmallButton("↗️", Color.FromArgb(52, 152, 219));
            btnRotateXPosModern.Location = new Point(60, 25);
            btnRotateXPosModern.Click += BtnRotateXPosModern_Click;
            btnRotateXNegModern = CreateSmallButton("↙️", Color.FromArgb(52, 152, 219));
            btnRotateXNegModern.Location = new Point(110, 25);
            btnRotateXNegModern.Click += BtnRotateXNegModern_Click;

            // Rotación Y
            Label lblRotY = CreateLabel("Eje Y:");
            lblRotY.Location = new Point(20, 70);
            btnRotateYPosModern = CreateSmallButton("↖️", Color.FromArgb(52, 152, 219));
            btnRotateYPosModern.Location = new Point(60, 65);
            btnRotateYPosModern.Click += BtnRotateYPosModern_Click;
            btnRotateYNegModern = CreateSmallButton("↘️", Color.FromArgb(52, 152, 219));
            btnRotateYNegModern.Location = new Point(110, 65);
            btnRotateYNegModern.Click += BtnRotateYNegModern_Click;

            // Rotación Z
            Label lblRotZ = CreateLabel("Eje Z:");
            lblRotZ.Location = new Point(20, 110);

            btnRotateZNegModern = CreateSmallButton("↻", Color.FromArgb(52, 152, 219));
            btnRotateZNegModern.Location = new Point(110, 105);
            btnRotateZNegModern.Click += BtnRotateZNegModern_Click;

            btnRotateZPosModern = CreateSmallButton("↺", Color.FromArgb(52, 152, 219));
            btnRotateZPosModern.Location = new Point(60, 105);
            btnRotateZPosModern.Click += BtnRotateZPosModern_Click;

            rotationGroupBox.Controls.Add(lblRotX);
            rotationGroupBox.Controls.Add(btnRotateXPosModern);
            rotationGroupBox.Controls.Add(btnRotateXNegModern);
            rotationGroupBox.Controls.Add(lblRotY);
            rotationGroupBox.Controls.Add(btnRotateYPosModern);
            rotationGroupBox.Controls.Add(btnRotateYNegModern);
            rotationGroupBox.Controls.Add(lblRotZ);
            rotationGroupBox.Controls.Add(btnRotateZPosModern);
            rotationGroupBox.Controls.Add(btnRotateZNegModern);

            // Grupo de Herramientas
            toolsGroupBox = CreateModernGroupBox("🛠️ Herramientas");
            toolsGroupBox.Location = new Point(0, 330);
            toolsGroupBox.Size = new Size(260, 150);

            // Control de escala
            lblScale = CreateLabel("Escala:");
            lblScale.Location = new Point(20, 30);

            scaleBarModern = new TrackBar();
            scaleBarModern.Location = new Point(20, 50);
            scaleBarModern.Size = new Size(180, 45);
            scaleBarModern.Minimum = 10;
            scaleBarModern.Maximum = 200;
            scaleBarModern.Value = 100;
            scaleBarModern.TickFrequency = 20;
            scaleBarModern.BackColor = Color.FromArgb(248, 249, 250);
            scaleBarModern.Scroll += ScaleBarModern_Scroll;

            lblScaleValue = CreateLabel("100%");
            lblScaleValue.Location = new Point(210, 55);
            lblScaleValue.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblScaleValue.ForeColor = Color.FromArgb(52, 152, 219);

            // Botón Reset
            btnResetModern = CreateModernButton("🔄 Reiniciar Vista", Color.FromArgb(241, 196, 15));
            btnResetModern.Location = new Point(20, 100);
            btnResetModern.Click += BtnResetModern_Click;

            toolsGroupBox.Controls.Add(lblScale);
            toolsGroupBox.Controls.Add(scaleBarModern);
            toolsGroupBox.Controls.Add(lblScaleValue);
            toolsGroupBox.Controls.Add(btnResetModern);

            // Agregar grupos al panel de control
            controlPanel.Controls.Add(figuresGroupBox);
            controlPanel.Controls.Add(rotationGroupBox);
            controlPanel.Controls.Add(toolsGroupBox);

            // Agregar paneles al formulario
            this.Controls.Add(canvasPanel);
            this.Controls.Add(controlPanel);
            this.Controls.Add(helpPanel);

            // Configurar orden de los controles
            helpPanel.BringToFront();
            controlPanel.BringToFront();
        }

        private GroupBox CreateModernGroupBox(string text)
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Text = text;
            groupBox.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            groupBox.ForeColor = Color.FromArgb(52, 73, 94);
            groupBox.BackColor = Color.White;
            groupBox.FlatStyle = FlatStyle.Flat;
            return groupBox;
        }

        private void CenterPicCanvas()
        {
            if (picCanvas != null && canvasPanel != null)
            {
                int x = (canvasPanel.Width - picCanvas.Width) / 2;
                int y = (canvasPanel.Height - picCanvas.Height) / 2;

                // Asegurar que las coordenadas no sean negativas
                x = Math.Max(0, x);
                y = Math.Max(0, y);

                picCanvas.Location = new Point(x, y);
            }
        }

        private Button CreateModernButton(string text, Color color)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Size = new Size(220, 35);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            // Efectos hover
            btn.MouseEnter += (s, e) => {
                btn.BackColor = ControlPaint.Light(color, 0.1f);
            };
            btn.MouseLeave += (s, e) => {
                btn.BackColor = color;
            };

            return btn;
        }

        private Button CreateSmallButton(string text, Color color)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Size = new Size(40, 30);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = color;
            btn.BackColor = Color.White;
            btn.ForeColor = color;
            btn.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            btn.Cursor = Cursors.Hand;

            // Efectos hover
            btn.MouseEnter += (s, e) => {
                btn.BackColor = color;
                btn.ForeColor = Color.White;
            };
            btn.MouseLeave += (s, e) => {
                btn.BackColor = Color.White;
                btn.ForeColor = color;
            };

            return btn;
        }

        private Label CreateLabel(string text)
        {
            Label lbl = new Label();
            lbl.Text = text;
            lbl.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lbl.ForeColor = Color.FromArgb(52, 73, 94);
            lbl.AutoSize = true;
            return lbl;
        }

        // Event handlers para los nuevos botones modernos
        private void BtnResetModern_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            AnimateButton(sender as Button);
        }

        private void ScaleBarModern_Scroll(object sender, EventArgs e)
        {
            float newSize = scaleBarModern.Value;
            lblScaleValue.Text = $"{newSize}%";
            figura.SetSize(newSize);
            figura.PlotShape(picCanvas);
        }

        private void BtnRotateXPosModern_Click(object sender, EventArgs e)
        {
            figura.RotateX(5 * (float)Math.PI / 180f, picCanvas);
            AnimateButton(sender as Button);
        }

        private void BtnRotateXNegModern_Click(object sender, EventArgs e)
        {
            figura.RotateX(-5 * (float)Math.PI / 180f, picCanvas);
            AnimateButton(sender as Button);
        }

        private void BtnRotateYPosModern_Click(object sender, EventArgs e)
        {
            figura.RotateY(5 * (float)Math.PI / 180f, picCanvas);
            AnimateButton(sender as Button);
        }

        private void BtnRotateYNegModern_Click(object sender, EventArgs e)
        {
            figura.RotateY(-5 * (float)Math.PI / 180f, picCanvas);
            AnimateButton(sender as Button);
        }

        private void BtnRotateZPosModern_Click(object sender, EventArgs e)
        {
            figura.RotateZ(5 * (float)Math.PI / 180f, picCanvas);
            AnimateButton(sender as Button);
        }

        private void BtnRotateZNegModern_Click(object sender, EventArgs e)
        {
            figura.RotateZ(-5 * (float)Math.PI / 180f, picCanvas);
            AnimateButton(sender as Button);
        }

        private void BtnFigure1Modern_Click(object sender, EventArgs e)
        {
            figura.SetSide(5);
            figura.PlotShape(picCanvas);
            UpdateFigureButtons(btnFigure1Modern);
            AnimateButton(sender as Button);
        }

        private void BtnFigure2Modern_Click(object sender, EventArgs e)
        {
            figura.SetSide(7);
            figura.PlotShape(picCanvas);
            UpdateFigureButtons(btnFigure2Modern);
            AnimateButton(sender as Button);
        }

        // Métodos originales mantenidos para compatibilidad
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
            TrackBar tb = sender as TrackBar;
            if (tb != null)
            {
                float newSize = tb.Value;
                figura.SetSize(newSize);
                figura.PlotShape(picCanvas);
            }
        }

        private void btnRotateXPos_Click(object sender, EventArgs e)
        {
            figura.RotateX(5 * (float)Math.PI / 180f, picCanvas);
        }

        private void btnRotateXNeg_Click(object sender, EventArgs e)
        {
            figura.RotateX(-5 * (float)Math.PI / 180f, picCanvas);
        }

        private void btnRotateYPos_Click(object sender, EventArgs e)
        {
            figura.RotateY(5 * (float)Math.PI / 180f, picCanvas);
        }

        private void btnRotateYNeg_Click(object sender, EventArgs e)
        {
            figura.RotateY(-5 * (float)Math.PI / 180f, picCanvas);
        }

        private void btnRotateZPos_Click(object sender, EventArgs e)
        {
            figura.RotateZ(5 * (float)Math.PI / 180f, picCanvas);
        }

        private void btnRotateZNeg_Click(object sender, EventArgs e)
        {
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
            float dy = figura.GetPosY() - (e.Y - picCanvas.Height / 2f);
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
            if (newX.HasValue && newY.HasValue && e.Button == MouseButtons.Left)
            {
                figura.SetPosX(((float)newX) - (picCanvas.Width / 2f));
                figura.SetPosY(((float)newY) - (picCanvas.Height / 2f));
                figura.PlotShape(picCanvas);
            }
        }

        // Métodos auxiliares para efectos visuales
        private void UpdateFigureButtons(Button activeButton)
        {
            btnFigure1Modern.BackColor = Color.FromArgb(231, 76, 60);
            btnFigure2Modern.BackColor = Color.FromArgb(46, 204, 113);

            activeButton.BackColor = ControlPaint.Light(activeButton.BackColor, 0.2f);
        }

        private void AnimateButton(Button button)
        {
            if (button == null) return;

            Color originalColor = button.BackColor;
            button.BackColor = ControlPaint.Light(originalColor, 0.3f);

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 100;
            timer.Tick += (s, e) => {
                button.BackColor = originalColor;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }


    }
}