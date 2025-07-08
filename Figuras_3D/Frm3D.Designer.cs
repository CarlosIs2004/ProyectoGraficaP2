namespace Figuras_3D
{
    partial class Frm3D
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
            this.btnReset = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.scaleBar = new System.Windows.Forms.TrackBar();
            this.btnRotateXPos = new System.Windows.Forms.Button();
            this.btnRotateXNeg = new System.Windows.Forms.Button();
            this.btnRotateYNeg = new System.Windows.Forms.Button();
            this.btnRotateYPos = new System.Windows.Forms.Button();
            this.btnRotateZNeg = new System.Windows.Forms.Button();
            this.btnRotateZPos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tetraedrotxt = new System.Windows.Forms.Button();
            this.cubotxt = new System.Windows.Forms.Button();
            this.icosaedrotxt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleBar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(154, 93);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(56, 19);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(278, 93);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(2);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(417, 297);
            this.picCanvas.TabIndex = 5;
            this.picCanvas.TabStop = false;
            // 
            // scaleBar
            // 
            this.scaleBar.Location = new System.Drawing.Point(287, 28);
            this.scaleBar.Margin = new System.Windows.Forms.Padding(2);
            this.scaleBar.Name = "scaleBar";
            this.scaleBar.Size = new System.Drawing.Size(417, 45);
            this.scaleBar.TabIndex = 6;
            this.scaleBar.Scroll += new System.EventHandler(this.scaleBar_Scroll);
            // 
            // btnRotateXPos
            // 
            this.btnRotateXPos.Location = new System.Drawing.Point(50, 249);
            this.btnRotateXPos.Margin = new System.Windows.Forms.Padding(2);
            this.btnRotateXPos.Name = "btnRotateXPos";
            this.btnRotateXPos.Size = new System.Drawing.Size(56, 19);
            this.btnRotateXPos.TabIndex = 7;
            this.btnRotateXPos.Text = "X pos";
            this.btnRotateXPos.UseVisualStyleBackColor = true;
            this.btnRotateXPos.Click += new System.EventHandler(this.btnRotateXPos_Click);
            // 
            // btnRotateXNeg
            // 
            this.btnRotateXNeg.Location = new System.Drawing.Point(136, 249);
            this.btnRotateXNeg.Margin = new System.Windows.Forms.Padding(2);
            this.btnRotateXNeg.Name = "btnRotateXNeg";
            this.btnRotateXNeg.Size = new System.Drawing.Size(56, 19);
            this.btnRotateXNeg.TabIndex = 8;
            this.btnRotateXNeg.Text = "X neg";
            this.btnRotateXNeg.UseVisualStyleBackColor = true;
            this.btnRotateXNeg.Click += new System.EventHandler(this.btnRotateXNeg_Click);
            // 
            // btnRotateYNeg
            // 
            this.btnRotateYNeg.Location = new System.Drawing.Point(136, 297);
            this.btnRotateYNeg.Margin = new System.Windows.Forms.Padding(2);
            this.btnRotateYNeg.Name = "btnRotateYNeg";
            this.btnRotateYNeg.Size = new System.Drawing.Size(56, 19);
            this.btnRotateYNeg.TabIndex = 9;
            this.btnRotateYNeg.Text = "Y neg";
            this.btnRotateYNeg.UseVisualStyleBackColor = true;
            this.btnRotateYNeg.Click += new System.EventHandler(this.btnRotateYNeg_Click);
            // 
            // btnRotateYPos
            // 
            this.btnRotateYPos.Location = new System.Drawing.Point(50, 297);
            this.btnRotateYPos.Margin = new System.Windows.Forms.Padding(2);
            this.btnRotateYPos.Name = "btnRotateYPos";
            this.btnRotateYPos.Size = new System.Drawing.Size(56, 19);
            this.btnRotateYPos.TabIndex = 10;
            this.btnRotateYPos.Text = "Y pos";
            this.btnRotateYPos.UseVisualStyleBackColor = true;
            this.btnRotateYPos.Click += new System.EventHandler(this.btnRotateYPos_Click);
            // 
            // btnRotateZNeg
            // 
            this.btnRotateZNeg.Location = new System.Drawing.Point(136, 350);
            this.btnRotateZNeg.Margin = new System.Windows.Forms.Padding(2);
            this.btnRotateZNeg.Name = "btnRotateZNeg";
            this.btnRotateZNeg.Size = new System.Drawing.Size(56, 19);
            this.btnRotateZNeg.TabIndex = 11;
            this.btnRotateZNeg.Text = "Z neg";
            this.btnRotateZNeg.UseVisualStyleBackColor = true;
            this.btnRotateZNeg.Click += new System.EventHandler(this.btnRotateZNeg_Click);
            // 
            // btnRotateZPos
            // 
            this.btnRotateZPos.Location = new System.Drawing.Point(50, 350);
            this.btnRotateZPos.Margin = new System.Windows.Forms.Padding(2);
            this.btnRotateZPos.Name = "btnRotateZPos";
            this.btnRotateZPos.Size = new System.Drawing.Size(56, 19);
            this.btnRotateZPos.TabIndex = 12;
            this.btnRotateZPos.Text = "Z pos";
            this.btnRotateZPos.UseVisualStyleBackColor = true;
            this.btnRotateZPos.Click += new System.EventHandler(this.btnRotateZPos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // tetraedrotxt
            // 
            this.tetraedrotxt.Location = new System.Drawing.Point(38, 54);
            this.tetraedrotxt.Margin = new System.Windows.Forms.Padding(2);
            this.tetraedrotxt.Name = "tetraedrotxt";
            this.tetraedrotxt.Size = new System.Drawing.Size(74, 19);
            this.tetraedrotxt.TabIndex = 14;
            this.tetraedrotxt.Text = "Tetraedro";
            this.tetraedrotxt.UseVisualStyleBackColor = true;
            this.tetraedrotxt.Click += new System.EventHandler(this.tetraedrotxt_Click);
            // 
            // cubotxt
            // 
            this.cubotxt.Location = new System.Drawing.Point(38, 93);
            this.cubotxt.Margin = new System.Windows.Forms.Padding(2);
            this.cubotxt.Name = "cubotxt";
            this.cubotxt.Size = new System.Drawing.Size(74, 19);
            this.cubotxt.TabIndex = 15;
            this.cubotxt.Text = "Cubo";
            this.cubotxt.UseVisualStyleBackColor = true;
            this.cubotxt.Click += new System.EventHandler(this.cubotxt_Click);
            // 
            // icosaedrotxt
            // 
            this.icosaedrotxt.Location = new System.Drawing.Point(38, 130);
            this.icosaedrotxt.Margin = new System.Windows.Forms.Padding(2);
            this.icosaedrotxt.Name = "icosaedrotxt";
            this.icosaedrotxt.Size = new System.Drawing.Size(74, 19);
            this.icosaedrotxt.TabIndex = 16;
            this.icosaedrotxt.Text = "Icosaedro";
            this.icosaedrotxt.UseVisualStyleBackColor = true;
            this.icosaedrotxt.Click += new System.EventHandler(this.icosaedrotxt_Click);
            // 
            // Frm3D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 435);
            this.Controls.Add(this.icosaedrotxt);
            this.Controls.Add(this.cubotxt);
            this.Controls.Add(this.tetraedrotxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRotateZPos);
            this.Controls.Add(this.btnRotateZNeg);
            this.Controls.Add(this.btnRotateYPos);
            this.Controls.Add(this.btnRotateYNeg);
            this.Controls.Add(this.btnRotateXNeg);
            this.Controls.Add(this.btnRotateXPos);
            this.Controls.Add(this.scaleBar);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.btnReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm3D";
            this.Text = "Frm3D";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.TrackBar scaleBar;
        private System.Windows.Forms.Button btnRotateXPos;
        private System.Windows.Forms.Button btnRotateXNeg;
        private System.Windows.Forms.Button btnRotateYNeg;
        private System.Windows.Forms.Button btnRotateYPos;
        private System.Windows.Forms.Button btnRotateZNeg;
        private System.Windows.Forms.Button btnRotateZPos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tetraedrotxt;
        private System.Windows.Forms.Button cubotxt;
        private System.Windows.Forms.Button icosaedrotxt;
    }
}