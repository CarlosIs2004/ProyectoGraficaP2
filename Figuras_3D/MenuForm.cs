using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_3D
{
    public partial class MenuForm : Form
    {
        Form fn;
        private Panel sidePanel;
        private Panel headerPanel;
        private Button btnRegulares;
        private Button btnIrregulares;
        private Button btnSalir;
        private Label lblTitle;
        private Label lblSubtitle;
        private PictureBox logoBox;

        public MenuForm()
        {
            InitializeComponent();
            InitializeModernDesign();
        }

        private void InitializeModernDesign()
        {
            // Configuración general del form
            this.BackColor = Color.FromArgb(240, 242, 245);
            this.WindowState = FormWindowState.Maximized;
            this.Text = "Figuras 3D - Geometría Interactiva";
            this.Icon = SystemIcons.Application;

            // Panel lateral (sidebar)
            sidePanel = new Panel();
            sidePanel.BackColor = Color.FromArgb(45, 52, 67);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Width = 280;
            sidePanel.Paint += SidePanel_Paint;

            // Panel superior (header)
            headerPanel = new Panel();
            headerPanel.BackColor = Color.FromArgb(52, 73, 94);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 80;
            headerPanel.Paint += HeaderPanel_Paint;

            // Logo/Icono
            logoBox = new PictureBox();
            logoBox.Size = new Size(50, 50);
            logoBox.Location = new Point(20, 15);
            logoBox.BackColor = Color.FromArgb(52, 152, 219);
            logoBox.Paint += LogoBox_Paint;

            // Título principal
            lblTitle = new Label();
            lblTitle.Text = "FIGURAS 3D";
            lblTitle.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(85, 15);
            lblTitle.AutoSize = true;

            // Subtítulo
            lblSubtitle = new Label();
            lblSubtitle.Text = "Explorador de Geometría Tridimensional";
            lblSubtitle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblSubtitle.ForeColor = Color.FromArgb(189, 195, 199);
            lblSubtitle.Location = new Point(85, 45);
            lblSubtitle.AutoSize = true;

            // Botones del menú lateral
            btnRegulares = CreateModernButton("🔷 Poliedros Regulares", 30);
            btnIrregulares = CreateModernButton("🔶 Poliedros Irregulares", 100);
            btnSalir = CreateModernButton("🚪 Salir", 400);

            // Configurar eventos
            btnRegulares.Click += PoliedrosRegulares_Click;
            btnIrregulares.Click += PoliedrosIrregulares_Click;
            btnSalir.Click += BtnSalir_Click;

            // Agregar controles al panel lateral
            sidePanel.Controls.Add(btnRegulares);
            sidePanel.Controls.Add(btnIrregulares);
            sidePanel.Controls.Add(btnSalir);

            // Agregar controles al panel superior
            headerPanel.Controls.Add(logoBox);
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Controls.Add(lblSubtitle);

            // Modificar el panel principal existente
            if (panel1 != null)
            {
                panel1.BackColor = Color.White;
                panel1.Padding = new Padding(20);
            }

            // Agregar todos los paneles al form
            this.Controls.Add(sidePanel);
            this.Controls.Add(headerPanel);

            // Asegurar que el panel1 esté por encima
            if (panel1 != null)
            {
                panel1.BringToFront();
            }
        }

        private Button CreateModernButton(string text, int yPosition)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Size = new Size(240, 50);
            btn.Location = new Point(20, yPosition);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(52, 73, 94);
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(15, 0, 0, 0);
            btn.Cursor = Cursors.Hand;

            // Efectos hover
            btn.MouseEnter += (s, e) => {
                btn.BackColor = Color.FromArgb(52, 152, 219);
                btn.ForeColor = Color.White;
            };
            btn.MouseLeave += (s, e) => {
                btn.BackColor = Color.FromArgb(52, 73, 94);
                btn.ForeColor = Color.White;
            };

            return btn;
        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {
            // Agregar sombra al panel lateral
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(30, 0, 0, 0)))
            {
                e.Graphics.FillRectangle(brush, sidePanel.Width - 5, 0, 5, sidePanel.Height);
            }
        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {
            // Agregar sombra al panel superior
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(30, 0, 0, 0)))
            {
                e.Graphics.FillRectangle(brush, 0, headerPanel.Height - 5, headerPanel.Width, 5);
            }
        }

        private void LogoBox_Paint(object sender, PaintEventArgs e)
        {
            // Dibujar un icono simple de cubo 3D
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen whitePen = new Pen(Color.White, 2))
            {
                // Cara frontal del cubo
                g.DrawRectangle(whitePen, 8, 15, 20, 20);
                // Cara trasera del cubo
                g.DrawRectangle(whitePen, 15, 8, 20, 20);
                // Líneas de conexión
                g.DrawLine(whitePen, 8, 15, 15, 8);
                g.DrawLine(whitePen, 28, 15, 35, 8);
                g.DrawLine(whitePen, 28, 35, 35, 28);
                g.DrawLine(whitePen, 8, 35, 15, 28);
            }
        }

        private void openChildForm(object childForm)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);

            fn = childForm as Form;
            fn.TopLevel = false;
            fn.Dock = DockStyle.Fill;
            fn.BackColor = Color.White;
            this.panel1.Controls.Add(fn);
            this.panel1.Tag = fn;
            fn.Show();

            // Animación suave al cambiar de form
            fn.Opacity = 0;
            Timer fadeTimer = new Timer();
            fadeTimer.Interval = 20;
            fadeTimer.Tick += (s, e) => {
                fn.Opacity += 0.1;
                if (fn.Opacity >= 1.0)
                {
                    fadeTimer.Stop();
                    fadeTimer.Dispose();
                }
            };
            fadeTimer.Start();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            if (fn == null)
            {
                openChildForm(new Frm3D());
            }
        }

        private void PoliedrosRegulares_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm3D());
            UpdateButtonStates(btnRegulares);
        }

        private void PoliedrosIrregulares_Click(object sender, EventArgs e)
        {
            openChildForm(new IrregularFigureForm());
            UpdateButtonStates(btnIrregulares);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void UpdateButtonStates(Button activeButton)
        {
            // Resetear todos los botones
            btnRegulares.BackColor = Color.FromArgb(52, 73, 94);
            btnIrregulares.BackColor = Color.FromArgb(52, 73, 94);

            // Destacar el botón activo
            activeButton.BackColor = Color.FromArgb(52, 152, 219);
        }

        // Métodos de compatibilidad con el código existente
        private void poliedrosRegularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoliedrosRegulares_Click(sender, e);
        }

        private void poliedrosIrregularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoliedrosIrregulares_Click(sender, e);
        }
    }
}