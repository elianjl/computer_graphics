
namespace RectaDeEuler
{
    partial class Euler
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.txtSideA = new System.Windows.Forms.TextBox();
            this.txtSideB = new System.Windows.Forms.TextBox();
            this.txtSideC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chbHeigth = new System.Windows.Forms.CheckBox();
            this.chbMedians = new System.Windows.Forms.CheckBox();
            this.chbMediatrix = new System.Windows.Forms.CheckBox();
            this.chbEuler = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEquation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(249, 13);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(1071, 587);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // txtSideA
            // 
            this.txtSideA.Location = new System.Drawing.Point(97, 201);
            this.txtSideA.Name = "txtSideA";
            this.txtSideA.Size = new System.Drawing.Size(121, 22);
            this.txtSideA.TabIndex = 2;
            // 
            // txtSideB
            // 
            this.txtSideB.Location = new System.Drawing.Point(97, 229);
            this.txtSideB.Name = "txtSideB";
            this.txtSideB.Size = new System.Drawing.Size(121, 22);
            this.txtSideB.TabIndex = 4;
            // 
            // txtSideC
            // 
            this.txtSideC.Location = new System.Drawing.Point(97, 257);
            this.txtSideC.Name = "txtSideC";
            this.txtSideC.Size = new System.Drawing.Size(121, 22);
            this.txtSideC.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lado a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lado b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lado c:";
            // 
            // chbHeigth
            // 
            this.chbHeigth.AutoSize = true;
            this.chbHeigth.Location = new System.Drawing.Point(35, 304);
            this.chbHeigth.Name = "chbHeigth";
            this.chbHeigth.Size = new System.Drawing.Size(74, 21);
            this.chbHeigth.TabIndex = 11;
            this.chbHeigth.Text = "Alturas";
            this.chbHeigth.UseVisualStyleBackColor = true;
            this.chbHeigth.CheckedChanged += new System.EventHandler(this.chbHeigth_CheckedChanged);
            // 
            // chbMedians
            // 
            this.chbMedians.AutoSize = true;
            this.chbMedians.Location = new System.Drawing.Point(35, 331);
            this.chbMedians.Name = "chbMedians";
            this.chbMedians.Size = new System.Drawing.Size(91, 21);
            this.chbMedians.TabIndex = 12;
            this.chbMedians.Text = "Medianas";
            this.chbMedians.UseVisualStyleBackColor = true;
            this.chbMedians.CheckedChanged += new System.EventHandler(this.chbMedians_CheckedChanged);
            // 
            // chbMediatrix
            // 
            this.chbMediatrix.AutoSize = true;
            this.chbMediatrix.Location = new System.Drawing.Point(35, 358);
            this.chbMediatrix.Name = "chbMediatrix";
            this.chbMediatrix.Size = new System.Drawing.Size(102, 21);
            this.chbMediatrix.TabIndex = 13;
            this.chbMediatrix.Text = "Mediatrices";
            this.chbMediatrix.UseVisualStyleBackColor = true;
            this.chbMediatrix.CheckedChanged += new System.EventHandler(this.chbMediatrix_CheckedChanged);
            // 
            // chbEuler
            // 
            this.chbEuler.AutoSize = true;
            this.chbEuler.Location = new System.Drawing.Point(35, 385);
            this.chbEuler.Name = "chbEuler";
            this.chbEuler.Size = new System.Drawing.Size(124, 21);
            this.chbEuler.TabIndex = 14;
            this.chbEuler.Text = "Recta de Euler";
            this.chbEuler.UseVisualStyleBackColor = true;
            this.chbEuler.CheckedChanged += new System.EventHandler(this.chbEuler_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ecuacion";
            // 
            // txtEquation
            // 
            this.txtEquation.Location = new System.Drawing.Point(24, 465);
            this.txtEquation.Name = "txtEquation";
            this.txtEquation.Size = new System.Drawing.Size(194, 22);
            this.txtEquation.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "Euler";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RectaDeEuler.Properties.Resources.euler;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(53, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 82);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Euler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1336, 613);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEquation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chbEuler);
            this.Controls.Add(this.chbMediatrix);
            this.Controls.Add(this.chbMedians);
            this.Controls.Add(this.chbHeigth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSideC);
            this.Controls.Add(this.txtSideB);
            this.Controls.Add(this.txtSideA);
            this.Controls.Add(this.picCanvas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Euler";
            this.Text = "Recta de Euler";
            this.Load += new System.EventHandler(this.Euler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.TextBox txtSideA;
        private System.Windows.Forms.TextBox txtSideB;
        private System.Windows.Forms.TextBox txtSideC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbHeigth;
        private System.Windows.Forms.CheckBox chbMedians;
        private System.Windows.Forms.CheckBox chbMediatrix;
        private System.Windows.Forms.CheckBox chbEuler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEquation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

