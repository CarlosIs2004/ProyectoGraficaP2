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
        public MenuForm()
        {
            InitializeComponent();
        }
        private void openChildForm(object childForm)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            fn = childForm as Form;
            fn.TopLevel = false;
            fn.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fn);
            this.panel1.Tag = fn;
            fn.Show();

        }
        private void MenuForm_Load(object sender, EventArgs e)
        {
            if (fn == null)
            {
                openChildForm(new Frm3D());
            }
        }

        private void poliedrosRegularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm3D());
        }

        private void poliedrosIrregularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new IrregularFigureForm());
        }
    }
}
