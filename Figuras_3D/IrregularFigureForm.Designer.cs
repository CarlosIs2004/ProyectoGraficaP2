namespace Figuras_3D
{
    partial class IrregularFigureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRotateZPos = new System.Windows.Forms.Button();
            this.btnRotateZNeg = new System.Windows.Forms.Button();
            this.btnRotateYPos = new System.Windows.Forms.Button();
            this.btnRotateYNeg = new System.Windows.Forms.Button();
            this.btnRotateXNeg = new System.Windows.Forms.Button();
            this.btnRotateXPos = new System.Windows.Forms.Button();
            this.scaleBar = new System.Windows.Forms.TrackBar();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scaleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(36, 167);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(2);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(56, 19);
            this.btnDraw.TabIndex = 4;
            this.btnDraw.Text = "Dibujar";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(120, 167);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(56, 19);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "label1";
            // 
            // btnRotateZPos
            // 
            this.btnRotateZPos.Location = new System.Drawing.Point(48, 387);
            this.btnRotateZPos.Margin = new System.Windows.Forms.Padding(2);
            this.btnRotateZPos.Name = "btnRotateZPos";
            this.btnRotateZPos.Size = new System.Drawing.Size(56, 19);
            this.btnRotateZPos.TabIndex = 19;
            this.btnRotateZPos.Text = "Z pos";
            this.btnRotateZPos.UseVisualStyleBackColor = true;
            this.btnRotateZPos.Click += new System.EventHandler(this.btnRotateZPos_Click);
            // 
            // btnRotateZNeg
            // 
            this.btnRotateZNeg.Location = new System.Drawing.Point(134, 387);
            this.btnRotateZNeg.Margin = new System.Windows.Forms.Padding(2);
            this.btnRotateZNeg.Name = "btnRotateZNeg";
            this.btnRotateZNeg.Size = new System.Drawing.Size(56, 19);
            this.btnRotateZNeg.TabIndex = 18;
            this.btnRotateZNeg.Text = "Z neg";
            this.btnRotateZNeg.UseVisualStyleBackColor = true;
            this.btnRotateZNeg.Click += new System.EventHandler(this.btnRotateZNeg_Click);
            // 
            // btnRotateYPos
            // 
            this.btnRotateYPos.Location = new System.Drawing.Point(48, 334);
            this.btnRotateYPos.Margin = new System.Windows.Forms.Padding(2);
            this.btnRotateYPos.Name = "btnRotateYPos";
            this.btnRotateYPos.Size = new System.Drawing.Size(56, 19);
            this.btnRotateYPos.TabIndex = 17;
            this.btnRotateYPos.Text = "Y pos";
            this.btnRotateYPos.UseVisualStyleBackColor = true;
            this.btnRotateYPos.Click += new System.EventHandler(this.btnRotateYPos_Click);
            // 
            // btnRotateYNeg
            // 
            this.btnRotateYNeg.Location = new System.Drawing.Point(134, 334);
            this.btnRotateYNeg.Margin = new System.Windows.Forms.Padding(2);
            this.btnRotateYNeg.Name = "btnRotateYNeg";
            this.btnRotateYNeg.Size = new System.Drawing.Size(56, 19);
            this.btnRotateYNeg.TabIndex = 16;
            this.btnRotateYNeg.Text = "Y neg";
            this.btnRotateYNeg.UseVisualStyleBackColor = true;
            this.btnRotateYNeg.Click += new System.EventHandler(this.btnRotateYNeg_Click);
            // 
            // btnRotateXNeg
            // 
            this.btnRotateXNeg.Location = new System.Drawing.Point(134, 286);
            this.btnRotateXNeg.Margin = new System.Windows.Forms.Padding(2);
            this.btnRotateXNeg.Name = "btnRotateXNeg";
            this.btnRotateXNeg.Size = new System.Drawing.Size(56, 19);
            this.btnRotateXNeg.TabIndex = 15;
            this.btnRotateXNeg.Text = "X neg";
            this.btnRotateXNeg.UseVisualStyleBackColor = true;
            this.btnRotateXNeg.Click += new System.EventHandler(this.btnRotateXNeg_Click);
            // 
            // btnRotateXPos
            // 
            this.btnRotateXPos.Location = new System.Drawing.Point(48, 286);
            this.btnRotateXPos.Margin = new System.Windows.Forms.Padding(2);
            this.btnRotateXPos.Name = "btnRotateXPos";
            this.btnRotateXPos.Size = new System.Drawing.Size(56, 19);
            this.btnRotateXPos.TabIndex = 14;
            this.btnRotateXPos.Text = "X pos";
            this.btnRotateXPos.UseVisualStyleBackColor = true;
            this.btnRotateXPos.Click += new System.EventHandler(this.btnRotateXPos_Click);
            // 
            // scaleBar
            // 
            this.scaleBar.Location = new System.Drawing.Point(273, 11);
            this.scaleBar.Margin = new System.Windows.Forms.Padding(2);
            this.scaleBar.Name = "scaleBar";
            this.scaleBar.Size = new System.Drawing.Size(417, 45);
            this.scaleBar.TabIndex = 22;
            this.scaleBar.Scroll += new System.EventHandler(this.scaleBar_Scroll);
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(240, 60);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(2);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(538, 379);
            this.picCanvas.TabIndex = 21;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseDown);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove);
            this.picCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 111);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 28);
            this.button1.TabIndex = 23;
            this.button1.Text = "Prisma Pentagonal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 76);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 31);
            this.button2.TabIndex = 24;
            this.button2.Text = "Prisma heptagonal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(65, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // IrregularFigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scaleBar);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRotateZPos);
            this.Controls.Add(this.btnRotateZNeg);
            this.Controls.Add(this.btnRotateYPos);
            this.Controls.Add(this.btnRotateYNeg);
            this.Controls.Add(this.btnRotateXNeg);
            this.Controls.Add(this.btnRotateXPos);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IrregularFigureForm";
            this.Text = "IrregularFigureForm";
            ((System.ComponentModel.ISupportInitialize)(this.scaleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRotateZPos;
        private System.Windows.Forms.Button btnRotateZNeg;
        private System.Windows.Forms.Button btnRotateYPos;
        private System.Windows.Forms.Button btnRotateYNeg;
        private System.Windows.Forms.Button btnRotateXNeg;
        private System.Windows.Forms.Button btnRotateXPos;
        private System.Windows.Forms.TrackBar scaleBar;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}